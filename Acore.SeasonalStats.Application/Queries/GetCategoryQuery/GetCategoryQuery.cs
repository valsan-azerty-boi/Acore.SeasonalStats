using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetCategoryQuery(int CategoryId) : IRequest<CategoryViewModel>;
