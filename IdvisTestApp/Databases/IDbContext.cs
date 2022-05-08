using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Databases
{
    /// <summary>
    /// Interface IDbContext.
    /// </summary>
    public interface IDbContext
    {
        /// <summary>
        /// Database set by TEntity.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns>DB set by TEntity.</returns>
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        /// <summary>
        /// Saves changes.
        /// </summary>
        /// <returns>Number of affected entities.</returns>
        public int SaveChanges();
    }
}
