using Acore.SeasonalStats.Domain;
using Acore.SeasonalStats.Infrastructure;
using Acore.SeasonalStats.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acore.SeasonalStats.Infrastructure.Repository;

public class CategoryRepository(SeasonalStatsDbContext context) : Repository<Category>(context), ICategoryRepository
{
    public async Task<Category?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await DbSet
            .OrderBy(c => c.Name)
            .FirstOrDefaultAsync(cancellationToken);
    }
}
