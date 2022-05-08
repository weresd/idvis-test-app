using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.HistogramTile
{
    /// <summary>
    /// Class HistogramTileProvider.
    /// </summary>
    public static class HistogramTileProvider
    {
        /// <summary>
        /// Adds an histogram tile mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddHistogramTileEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<HistogramTile>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.AutoRefresh)
                    .HasColumnName("AutoRefresh");

                entity.Property(e => e.CategoryMode)
                    .HasColumnName("CategoryMode");

                entity.Property(e => e.PercentageMode)
                    .HasColumnName("PercentageMode");

                entity.Property(e => e.RangeAuto)
                    .HasColumnName("RangeAuto");

                entity.Property(e => e.RangeCount)
                    .HasColumnName("RangeCount");

                entity.Property(e => e.RangeEnd)
                    .HasColumnName("RangeEnd");

                entity.Property(e => e.RangeStart)
                    .HasColumnName("RangeStart");

                entity.Property(e => e.RangeStep)
                    .HasColumnName("RangeStep");

                entity.Property(e => e.TileId)
                    .HasColumnName("TileId");

                entity.Property(e => e.LegendInTiledMode)
                    .HasColumnName("LegendInTiledMode")
                    .HasDefaultValue(0);
            });

            return modelBuilder;
        }
    }
}
