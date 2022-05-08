using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.PiechartTile
{
    /// <summary>
    /// Class PiechartTileProvider.
    /// </summary>
    public static class PiechartTileProvider
    {
        /// <summary>
        /// Adds an piechart tile mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddPiechartTileEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<PiechartTile>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.Aggregator)
                    .HasColumnName("Aggregator");

                entity.Property(e => e.AutoRefresh)
                    .HasColumnName("AutoRefresh");

                entity.Property(e => e.CategoryLimit)
                    .HasColumnName("CategoryLimit");

                entity.Property(e => e.ShowOthers)
                    .HasColumnName("ShowOthers");

                entity.Property(e => e.TileId)
                    .HasColumnName("TileId");

                entity.Property(e => e.LegendInTiledMode)
                    .HasColumnName("LegendInTiledMode");
            });

            return modelBuilder;
        }
    }
}
