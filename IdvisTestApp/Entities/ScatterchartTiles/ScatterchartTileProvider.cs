using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.ScatterchartTiles
{
    /// <summary>
    /// Class ScatterchartTileProvider.
    /// </summary>
    public static class ScatterchartTileProvider
    {
        /// <summary>
        /// Adds an scatterchart tile mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddScatterchartTileEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<ScatterchartTile>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.AbsoluteTime)
                    .HasColumnName("AbsoluteTime");

                entity.Property(e => e.AutoRefresh)
                    .HasColumnName("AutoRefresh");

                entity.Property(e => e.TileId)
                    .HasColumnName("TileId");

                entity.Property(e => e.XAxisKey)
                    .HasColumnName("XAxisKey");

                entity.Property(e => e.LegendInTiledMode)
                    .HasColumnName("LegendInTiledMode")
                    .HasDefaultValue(0);
            });

            return modelBuilder;
        }
    }
}
