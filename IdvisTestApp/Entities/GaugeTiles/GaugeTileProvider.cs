using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.GaugeTiles
{
    /// <summary>
    /// Class GaugeTileProvider.
    /// </summary>
    public static class GaugeTileProvider
    {
        /// <summary>
        /// Adds an gauge tile mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddGaugeTileEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<GaugeTile>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.Aggregator)
                    .HasColumnName("Aggregator");

                entity.Property(e => e.AutoRefresh)
                    .HasColumnName("AutoRefresh");

                entity.Property(e => e.Max)
                    .HasColumnName("Max");

                entity.Property(e => e.Min)
                    .HasColumnName("Min");

                entity.Property(e => e.ReverseColoring)
                    .HasColumnName("ReverseColoring");

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
