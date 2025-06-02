using MediatR;

namespace Acore.SeasonalStats.Application.Commands;

public record UpsertWorldCommand(int ServerId, string? ServerName) : IRequest<WorldViewModel>;
