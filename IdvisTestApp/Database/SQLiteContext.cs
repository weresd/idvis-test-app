using IdvisTestApp.Entities.Tiles;
using IdvisTestApp.Entities.Axes;
using IdvisTestApp.Entities.BarchartTiles;
using IdvisTestApp.Entities.Dashboards;
using IdvisTestApp.Entities.DatasourceConnections;
using IdvisTestApp.Entities.Datasources;
using IdvisTestApp.Entities.Filters;
using IdvisTestApp.Entities.Folders;
using IdvisTestApp.Entities.GaugeTiles;
using IdvisTestApp.Entities.HeatmapTiles;
using IdvisTestApp.Entities.HistogramTiles;
using IdvisTestApp.Entities.LinechartTiles;
using IdvisTestApp.Entities.PiechartTiles;
using IdvisTestApp.Entities.ScatterchartTiles;
using IdvisTestApp.Entities.Serieses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace IdvisTestApp.Database
{
    /// <summary>
    /// Class SQLiteContext.
    /// </summary>
    public class SQLiteContext : DbContext, IDbContext
    {
        /// <summary>
        /// Database options.
        /// </summary>
        protected DbOptions Options { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options">Database options.</param>
        /// <param name="contextOptions">Context options.</param>
        public SQLiteContext(IOptions<DbOptions> options, DbContextOptions<SQLiteContext> contextOptions) : base(contextOptions)
        {
            this.Options = options.Value;
        }

        /// <summary>
        /// Sets up a connection to a database.
        /// </summary>
        /// <param name="optionsBuilder">Options builder.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(this.Options.ConnectionString);
        }

        /// <summary>
        /// Sets up models.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .AddAxisEntity("Axis")
                .AddBarchartTileEntity("BarchartTiles")
                .AddDashboardEntity("Dashboards")
                .AddDatasourceConnectionEntity("DatasourceConnections")
                .AddDatasourceEntity("Datasources")
                .AddFilterEntity("Filters")
                .AddFolderEntity("Folders")
                .AddGaugeTileEntity("GaugeTiles")
                .AddHeatmapTileEntity("HeatmapTiles")
                .AddHistogramTileEntity("HistogramTiles")
                .AddLinechartTileEntity("LinechartTiles")
                .AddPiechartTileEntity("PiechartTiles")
                .AddScatterchartTileEntity("ScatterchartTiles")
                .AddSeriesEntity("Series")
                .AddTileEntity("Tiles");
        }
    }
}
