using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.DatasourceConnection
{
    /// <summary>
    /// Class DatasourceConnectionProvider.
    /// </summary>
    public static class DatasourceConnectionProvider
    {
        /// <summary>
        /// Adds an datasource connection mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddDatasourceConnectionEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<DatasourceConnection>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.Host)
                    .HasColumnName("Host");

                entity.Property(e => e.IntegratedSecurity)
                    .HasColumnName("IntegratedSecurity");

                entity.Property(e => e.Name)
                    .HasColumnName("Name");

                entity.Property(e => e.Port)
                    .HasColumnName("Port");

                entity.Property(e => e.Realm)
                    .HasColumnName("Realm");

                entity.Property(e => e.Password)
                    .HasColumnName("Password");

                entity.Property(e => e.Type)
                    .HasColumnName("Type");

                entity.Property(e => e.User)
                    .HasColumnName("User");
            });

            return modelBuilder;
        }
    }
}
