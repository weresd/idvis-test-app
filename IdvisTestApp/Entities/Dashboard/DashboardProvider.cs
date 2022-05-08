using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.Dashboard
{
    /// <summary>
    /// Class DashboardProvider.
    /// </summary>
    public static class DashboardProvider
    {
        /// <summary>
        /// Adds an dashboard mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddDashboardEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<Dashboard>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.Name)
                    .HasColumnName("Name");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentId");
            });

            return modelBuilder;
        }
    }
}
