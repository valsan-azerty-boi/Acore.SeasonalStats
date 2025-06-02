using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Acore.SeasonalStats.Application.Commands;

public class UpsertCategoryCommandHandler : IRequestHandler<UpsertCategoryCommand, CategoryViewModel>
{
    public UpsertCategoryCommandHandler()
    {
        //_categoryRepository = categoryRepository;
    }

    public async Task<CategoryViewModel> Handle(UpsertCategoryCommand command, CancellationToken cancellationToken)
    {
        //bool alreadyExist = _categoryRepository.AlreadyExists(command.CategoryId);
        //if (alreadyExist)
        //    update;
        //else
        //    create;
        //var category = new Domain.Category(Id: command.CategoryId, Name: command.CategoryName);

        //var createdCategory = await _categoryRepository.CreateAsync(category);

        //return new CategoryViewModel(createdCategory);

        return await Task.FromResult(new CategoryViewModel(command.CategoryId, command.CategoryName));
    }
}
