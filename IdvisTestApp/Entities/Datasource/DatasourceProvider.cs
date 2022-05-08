using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.Datasource
{
    /// <summary>
    /// Class DatasourceProvider.
    /// </summary>
    public static class DatasourceProvider
    {
        /// <summary>
        /// Adds an datasource mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddDatasourceEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<Datasource>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.ConnectionId)
                    .HasColumnName("ConnectionId");

                entity.Property(e => e.Name)
                    .HasColumnName("Name");

                entity.Property(e => e.TableOrStoreName)
                    .HasColumnName("TableOrStoreName");

                entity.Property(e => e.DatPathFrom)
                    .HasColumnName("DatPathFrom");

                entity.Property(e => e.DatPathReplace)
                    .HasColumnName("DatPathReplace")
                    .HasDefaultValue(0);

                entity.Property(e => e.DatPathTo)
                    .HasColumnName("DatPathTo");

                entity.Property(e => e.PdfPathFrom)
                    .HasColumnName("PdfPathFrom");

                entity.Property(e => e.PdfPathReplace)
                    .HasColumnName("PdfPathReplace")
                    .HasDefaultValue(0);

                entity.Property(e => e.PdfPathTo)
                    .HasColumnName("PdfPathTo");

                entity.Property(e => e.DatPassword)
                    .HasColumnName("DatPassword");
            });

            return modelBuilder;
        }
    }
}
