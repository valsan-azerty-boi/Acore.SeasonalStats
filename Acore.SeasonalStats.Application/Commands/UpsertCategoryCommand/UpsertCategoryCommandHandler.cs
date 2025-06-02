using Acore.SeasonalStats.Domain;
using Acore.SeasonalStats.Infrastructure.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Acore.SeasonalStats.Application.Commands;

public class UpsertCategoryCommandHandler(ICategoryRepository categoryRepository)
    : IRequestHandler<UpsertCategoryCommand, CategoryViewModel>
{

    public async Task<CategoryViewModel> Handle(UpsertCategoryCommand command, CancellationToken cancellationToken)
    {
        //TODO properly
        var existingCategory = await categoryRepository.GetByIdAsync(command.CategoryId, cancellationToken);

        if (existingCategory is not null)
        {
            existingCategory.Name = command.CategoryName;
            categoryRepository.Update(existingCategory);

            return new CategoryViewModel(existingCategory.Id, existingCategory.Name ?? string.Empty);
        }

        var newCategory = new Category
        {
            Id = command.CategoryId,
            Name = command.CategoryName
        };

        var created = categoryRepository.AddAsync(newCategory);

        return new CategoryViewModel(command.CategoryId, command.CategoryName ?? string.Empty);
    }
}
