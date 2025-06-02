using Acore.SeasonalStats.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Acore.SeasonalStats.Infrastructure.Interfaces;

public interface ICategoryRepository : IRepository<Category>
{
    Task<Category?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
