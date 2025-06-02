using MediatR;

namespace Acore.SeasonalStats.Application.Commands;

public record UpsertCategoryCommand(int CategoryId, string? CategoryName) : IRequest<CategoryViewModel>;
