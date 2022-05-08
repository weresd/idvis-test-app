using Microsoft.EntityFrameworkCore;

namespace IdvisTestApp.Entities.Filter
{
    /// <summary>
    /// Class FilterProvider.
    /// </summary>
    public static class FilterProvider
    {
        /// <summary>
        /// Adds an filter mapping to a table in the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        /// <param name="tableName">Table name.</param>
        /// <returns>Model builder.</returns>
        public static ModelBuilder AddFilterEntity(this ModelBuilder modelBuilder, string tableName)
        {
            modelBuilder.Entity<Filter>(entity =>
            {
                entity.ToTable(tableName);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.DashboardId)
                    .HasColumnName("DashboardId");

                entity.Property(e => e.FileCount)
                    .HasColumnName("FileCount");

                entity.Property(e => e.IsRelative)
                    .HasColumnName("IsRelative");

                entity.Property(e => e.Key)
                    .HasColumnName("Key");

                entity.Property(e => e.Name)
                    .HasColumnName("Name");

                entity.Property(e => e.NumEnd)
                    .HasColumnName("NumEnd");

                entity.Property(e => e.NumMultiEnd)
                    .HasColumnName("NumMultiEnd");

                entity.Property(e => e.NumMultiRangeEnd)
                    .HasColumnName("NumMultiRangeEnd");

                entity.Property(e => e.NumMultiStart)
                    .HasColumnName("NumMultiStart");

                entity.Property(e => e.NumStart)
                    .HasColumnName("NumStart");

                entity.Property(e => e.Operator)
                    .HasColumnName("Operator");

                entity.Property(e => e.RelativeDate)
                    .HasColumnName("RelativeDate");

                entity.Property(e => e.StrPrefix)
                    .HasColumnName("StrPrefix");

                entity.Property(e => e.StrValues)
                    .HasColumnName("StrValues");

                entity.Property(e => e.Text)
                    .HasColumnName("Text");

                entity.Property(e => e.TileId)
                    .HasColumnName("TileId");

                entity.Property(e => e.TimestampEnd)
                    .HasColumnName("TimestampEnd");

                entity.Property(e => e.TimestampStart)
                    .HasColumnName("TimestampStart");

                entity.Property(e => e.WorkShiftEnd)
                    .HasColumnName("WorkShiftEnd");

                entity.Property(e => e.WorkShiftStart)
                    .HasColumnName("WorkShiftStart");
            });

            return modelBuilder;
        }
    }
}
