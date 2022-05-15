using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.BarchartTiles
{
    /// <summary>
    /// Class BarchartTileProvider.
    /// </summary>
    public static class BarchartTileProvider
    {
        /// <summary>
        /// Adds an barchart tile mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddBarchartTileEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<BarchartTile>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.AutoRefresh)
                    .HasColumnName("AutoRefresh");

                entity.Property(e => e.Aggregator)
                    .HasColumnName("Aggregator");

                entity.Property(e => e.PercentageMode)
                    .HasColumnName("PercentageMode");

                entity.Property(e => e.DisplayMode)
                    .HasColumnName("DisplayMode");

                entity.Property(e => e.CategoryLimit)
                    .HasColumnName("CategoryLimit");

                entity.Property(e => e.ShowOthers)
                    .HasColumnName("ShowOthers");

                entity.Property(e => e.LegendInTiledMode)
                    .HasColumnName("LegendInTiledMode");

                entity.Property(e => e.TileId)
                    .HasColumnName("TileId");

                entity.Property(e => e.SortMode)
                    .HasColumnName("SortMode");
            });

            return modelBuilder;
        }
    }
}
