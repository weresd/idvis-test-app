using IdvisTestApp.Entities.BarchartTiles;
using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.Axes
{
    /// <summary>
    /// Class AxisProvider.
    /// </summary>
    public static class AxisProvider
    {
        /// <summary>
        /// Adds an axis mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddAxisEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<Axis>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.BarchartId)
                    .HasColumnName("BarchartId");

                entity.Property(e => e.ColorAuto)
                    .HasColumnName("ColorAuto");

                entity.Property(e => e.ColorFrom)
                    .HasColumnName("ColorFrom");

                entity.Property(e => e.ColorTo)
                    .HasColumnName("ColorTo");

                entity.Property(e => e.HeatmapId)
                    .HasColumnName("HeatmapId");

                entity.Property(e => e.Key)
                    .HasColumnName("Key");

                entity.Property(e => e.LinechartId)
                    .HasColumnName("LinechartId");

                entity.Property(e => e.Name)
                    .HasColumnName("Name");

                entity.Property(e => e.ScaleAuto)
                    .HasColumnName("ScaleAuto");

                entity.Property(e => e.ScaleFrom)
                    .HasColumnName("ScaleFrom");

                entity.Property(e => e.ScaleTo)
                    .HasColumnName("ScaleTo");

                entity.Property(e => e.ScatterchartId)
                    .HasColumnName("ScatterchartId");

                entity.Property(e => e.Type)
                    .HasColumnName("Type");
            });

            return modelBuilder;
        }
    }
}
