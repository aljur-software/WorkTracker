using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Abstractions.Repositories
{
    public interface IBaseRepository<in TIdentifier, TEntity, out TRepository>
      where TEntity : class
      where TRepository : class, IBaseRepository<TIdentifier, TEntity, TRepository>
    {
        /// <summary>
        /// Returns a list of <see cref="TEntity"/> based on the current query.
        /// </summary>
        /// <returns><see cref="TEntity"/></returns>
        Task<IEnumerable<TEntity>> ToListAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Used to reset the Query for QueryBuilder.
        /// </summary>
        /// <returns><see cref="TRepository"/></returns>
        TRepository Reset();
    }
}
