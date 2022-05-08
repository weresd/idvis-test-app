namespace IdvisTestApp.Entities
{
    /// <summary>
    /// Interface IRepository.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Finds entities.
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> Find();

        /// <summary>
        /// Saves entities.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Save(TEntity entity);

        /// <summary>
        /// Delete entities.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(TEntity entity);
    }
}
