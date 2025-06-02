using Acore.SeasonalStats.Api.Controllers;
using Acore.SeasonalStats.Application;
using Acore.SeasonalStats.Application.Queries;
using Acore.SeasonalStats.Infrastructure;
using Acore.SeasonalStats.Infrastructure.Repository;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Acore.SeasonalStats.Api.Tests;

public class CategoryControllerTests
{
    [Fact]
    public async Task Given_GetAllEndpoint_WhenGetAll_ReturnAllCategories()
    {
        var options = new DbContextOptionsBuilder<SeasonalStatsDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var categ1 = new Domain.Category { Id = 1, Name = "PvE" };
        var categ2 = new Domain.Category { Id = 2, Name = "PvP" };

        var context = new SeasonalStatsDbContext(options);
        await context.Categories.AddAsync(categ1);
        await context.Categories.AddAsync(categ2);
        await context.SaveChangesAsync();

        var repository = new CategoryRepository(context);

        var handler = new GetAllCategoriesQueryHandler(repository);

        var mediatorServiceMock = new Mock<IMediator>();
        mediatorServiceMock.Setup(m => m.Send(It.IsAny<GetAllCategoriesQuery>(), It.IsAny<CancellationToken>()))
            .Returns(async () =>
                await handler.Handle(new GetAllCategoriesQuery(), new CancellationToken()));

        var sut = new CategoryController(mediatorServiceMock.Object);
        var actionResult = await sut.GetAll(default);

        var result = (OkObjectResult)actionResult;
        result.Should().NotBeNull();
        var resultList = (result.Value as IEnumerable<CategoryViewModel> ?? Array.Empty<CategoryViewModel>()).ToList();
        resultList[0].CategoryId.Should().Be(categ1.Id);
        resultList[0].CategoryName.Should().Be(categ1.Name);
        resultList[1].CategoryId.Should().Be(categ2.Id);
        resultList[1].CategoryName.Should().Be(categ2.Name);
    }

    [Fact]
    public async Task Given_GetEndpoint_WhenGet_ReturnCategory()
    {
        var options = new DbContextOptionsBuilder<SeasonalStatsDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var categ1 = new Domain.Category { Id = 1, Name = "PvE" };
        var categ2 = new Domain.Category { Id = 2, Name = "PvP" };

        var context = new SeasonalStatsDbContext(options);
        await context.Categories.AddAsync(categ1);
        await context.Categories.AddAsync(categ2);
        await context.SaveChangesAsync();

        var repository = new CategoryRepository(context);

        var handler = new GetCategoryQueryHandler(repository);

        var mediatorServiceMock = new Mock<IMediator>();
        mediatorServiceMock.Setup(m => m.Send(It.IsAny<GetCategoryQuery>(), It.IsAny<CancellationToken>()))
            .Returns(async () =>
                await handler.Handle(new GetCategoryQuery(categ1.Id), new CancellationToken()));

        var sut = new CategoryController(mediatorServiceMock.Object);
        var actionResult = await sut.Get(categ1.Id, default);

        var result = (OkObjectResult)actionResult;
        result.Should().NotBeNull();
        var resultAssert = result.Value as CategoryViewModel ?? new CategoryViewModel(0, "bad value");
        resultAssert.CategoryId.Should().Be(categ1.Id);
        resultAssert.CategoryName.Should().Be(categ1.Name);
    }
}
