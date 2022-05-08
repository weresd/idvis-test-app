using Microsoft.EntityFrameworkCore;
using IdvisTestApp.Databases;

namespace IdvisTestApp.Entities
{
    /// <summary>
    /// Class Repository.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// DB set.
        /// </summary>
        protected DbSet<TEntity> Set { get; }

        /// <summary>
        /// DB context.
        /// </summary>
        protected IDbContext Context { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="context">Database context.</param>
        public Repository(IDbContext context)
        {
            this.Context = context;
            this.Set = context.Set<TEntity>();
        }

        /// <summary>
        /// Performs entity lookups.
        /// </summary>
        /// <returns>Entity query.</returns>
        public IQueryable<TEntity> Find()
        {
            return this.Set.AsQueryable();
        }

        /// <summary>
        /// Removes an entity.
        /// </summary>
        /// <param name="entity">The entity to be removed.</param>
        /// <returns>Deletion fact.</returns>
        public bool Delete(TEntity entity)
        {
            if (!this.Set.Local.Contains(entity))
            {
                return false;
            }

            this.Set.Remove(entity);

            return this.Context.SaveChanges() > 0;
        }

        /// <summary>
        /// Saves an entity.
        /// </summary>
        /// <param name="entity">The entity to be saved.</param>
        /// <returns>The fact of saving.</returns>
        public bool Save(TEntity entity)
        {
            if (this.Set.Local.Contains(entity))
            {
                this.Set.Update(entity);
            }
            else
            {
                this.Set.Add(entity);
            }

            return this.Context.SaveChanges() > 0;
        }
    }
}
