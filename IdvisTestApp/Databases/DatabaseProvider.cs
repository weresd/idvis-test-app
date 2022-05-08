namespace IdvisTestApp.Databases
{
    /// <summary>
    /// Class DatabaseProvider.
    /// </summary>
    public static class DatabaseProvider
    {
        /// <summary>
        /// Configures database service settings.
        /// </summary>
        /// <param name="services">Services.</param>
        /// <param name="configureOptions">Configure options.</param>
        public static void AddDatabase(this IServiceCollection services, Action<DbOptions> configureOptions)
        {
            DbOptions dbOptions = new DbOptions();

            configureOptions(dbOptions);

            services.Configure(configureOptions);
            services.AddDbContext<SQLiteContext>();
        }
    }
}
