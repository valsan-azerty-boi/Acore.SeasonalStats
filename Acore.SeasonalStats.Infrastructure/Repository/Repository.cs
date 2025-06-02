using Acore.SeasonalStats.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Acore.SeasonalStats.Infrastructure.Repository;

public abstract class Repository<T> : IRepository<T> where T : class
{
    protected readonly SeasonalStatsDbContext Context;
    protected readonly DbSet<T> DbSet;

    protected Repository(SeasonalStatsDbContext context)
    {
        Context = context;
        DbSet = Context.Set<T>();
    }

    public virtual async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default) => await DbSet.AsNoTracking().ToListAsync(cancellationToken);
    public virtual async Task AddAsync(T entity) => await DbSet.AddAsync(entity);
    public virtual void Update(T entity) => DbSet.Update(entity);
    public virtual void Delete(T entity) => DbSet.Remove(entity);
    public virtual async Task SaveChangesAsync(CancellationToken cancellationToken = default) =>
        await Context.SaveChangesAsync(cancellationToken);
}
