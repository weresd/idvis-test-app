using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.LinechartTile
{
    /// <summary>
    /// Class LinechartTileProvider.
    /// </summary>
    public static class LinechartTileProvider
    {
        /// <summary>
        /// Adds an linechart tile mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddLinechartTileEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<LinechartTile>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.AutoRefresh)
                    .HasColumnName("AutoRefresh");

                entity.Property(e => e.DatFileMode)
                    .HasColumnName("DatFileMode");

                entity.Property(e => e.TileId)
                    .HasColumnName("TileId");

                entity.Property(e => e.LegendInTiledMode)
                    .HasColumnName("LegendInTiledMode")
                    .HasDefaultValue(0);

                entity.Property(e => e.UseEvents)
                    .HasColumnName("UseEvents")
                    .HasDefaultValue(0);

                entity.Property(e => e.QdrTimeMode)
                    .HasColumnName("QdrTimeMode");

                entity.Property(e => e.LastFileSignals)
                    .HasColumnName("LastFileSignals")
                    .HasDefaultValue(0);
            });

            return modelBuilder;
        }
    }
}
