using Core.Abstractions.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    /// <summary>
    /// <inheritdoc cref="TRepository"/>
    /// </summary>
    /// <typeparam name="TIdentity"><see cref="TIdentity"/></typeparam>
    /// <typeparam name="TEntity"><see cref="TEntity"/></typeparam>
    /// <typeparam name="TRepository"><see cref="TRepository"/></typeparam>
    public abstract class BaseRepository<TIdentity, TEntity, TRepository> : IBaseRepository<TIdentity, TEntity, TRepository>
                where TEntity : class
                where TRepository : BaseRepository<TIdentity, TEntity, TRepository>
    {
        protected readonly DbContext Context;
        protected IQueryable<TEntity> Query;

        protected BaseRepository(DbContext context)
        {
            Context = context;
            Query = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> ToListAsync(CancellationToken cancellationToken = default)
        {
            return await
                Query.ToListAsync(cancellationToken);
        }

        public TRepository Reset()
        {
            Query = Context.Set<TEntity>().AsQueryable();
            return this as TRepository;
        }
    }
}