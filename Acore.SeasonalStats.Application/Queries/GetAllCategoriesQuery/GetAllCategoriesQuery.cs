using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetAllCategoriesQuery : IRequest<IEnumerable<CategoryViewModel>>;
