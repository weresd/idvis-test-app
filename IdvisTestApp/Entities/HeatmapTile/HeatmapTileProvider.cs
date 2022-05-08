using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.HeatmapTile
{
    /// <summary>
    /// Class HeatmapTileProvider.
    /// </summary>
    public static class HeatmapTileProvider
    {
        /// <summary>
        /// Adds an heatmap tile mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddHeatmapTileEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<HeatmapTile>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.AutoRefresh)
                    .HasColumnName("AutoRefresh");

                entity.Property(e => e.LegendInTiledMode)
                    .HasColumnName("LegendInTiledMode");

                entity.Property(e => e.ReverseColoring)
                    .HasColumnName("ReverseColoring");

                entity.Property(e => e.TileId)
                    .HasColumnName("TileId");

                entity.Property(e => e.UseEvents)
                    .HasColumnName("UseEvents");

                entity.Property(e => e.QdrTimeMode)
                    .HasColumnName("QdrTimeMode");
            });

            return modelBuilder;
        }
    }
}
