using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.Series
{
    /// <summary>
    /// Class SeriesProvider.
    /// </summary>
    public static class SeriesProvider
    {
        /// <summary>
        /// Adds an series mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddSeriesEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<Series>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.BarchartId)
                    .HasColumnName("BarchartId");

                entity.Property(e => e.GaugeId)
                    .HasColumnName("GaugeId");

                entity.Property(e => e.HeatmapId)
                    .HasColumnName("HeatmapId");

                entity.Property(e => e.HistogramId)
                    .HasColumnName("HistogramId");

                entity.Property(e => e.Key)
                    .HasColumnName("Key");

                entity.Property(e => e.LegendedHeatmapId)
                    .HasColumnName("LegendedHeatmapId");

                entity.Property(e => e.LegendedLinechartId)
                    .HasColumnName("LegendedLinechartId");

                entity.Property(e => e.LinechartId)
                    .HasColumnName("LinechartId");

                entity.Property(e => e.Name)
                    .HasColumnName("Name");

                entity.Property(e => e.Ordinal)
                    .HasColumnName("Ordinal");

                entity.Property(e => e.PiechartId)
                    .HasColumnName("PiechartId");

                entity.Property(e => e.Precision)
                    .HasColumnName("Precision");

                entity.Property(e => e.ScatterchartId)
                    .HasColumnName("ScatterchartId");

                entity.Property(e => e.Type)
                    .HasColumnName("Type");

                entity.Property(e => e.Unit)
                    .HasColumnName("Unit");

                entity.Property(e => e.XBaseType)
                    .HasColumnName("XBaseType");

                entity.Property(e => e.XBaseTypes)
                    .HasColumnName("XBaseTypes");

                entity.Property(e => e.Aggregator)
                    .HasColumnName("Aggregator");

                entity.Property(e => e.Color)
                    .HasColumnName("Color");
            });

            return modelBuilder;
        }
    }
}
