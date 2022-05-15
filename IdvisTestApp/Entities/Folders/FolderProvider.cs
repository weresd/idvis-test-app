using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.Folders
{
    /// <summary>
    /// Class FolderProvider.
    /// </summary>
    public static class FolderProvider
    {
        /// <summary>
        /// Adds an folder mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddFolderEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<Folder>(entity =>
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
