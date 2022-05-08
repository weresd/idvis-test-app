using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace IdvisTestApp.Entities.Tile
{
    /// <summary>
    /// Class TileProvider.
    /// </summary>
    public static class TileProvider
    {
        /// <summary>
        /// Adds a tile-to-table mapping in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddTileEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<Tile>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.DashboardId)
                    .HasColumnName("DashboardId");

                entity.Property(e => e.DatasourceId)
                    .HasColumnName("DatasourceId");

                entity.Property(e => e.H)
                    .HasColumnName("H");

                entity.Property(e => e.Name)
                    .HasColumnName("Name");

                entity.Property(e => e.Type)
                    .HasColumnName("Type");

                entity.Property(e => e.UseDatFiles)
                    .HasColumnName("UseDatFiles");

                entity.Property(e => e.W)
                    .HasColumnName("W");

                entity.Property(e => e.X)
                    .HasColumnName("X");

                entity.Property(e => e.Y)
                    .HasColumnName("Y");
            });

            return modelBuilder;
        }
    }
}
