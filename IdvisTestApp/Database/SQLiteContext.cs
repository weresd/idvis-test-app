using IdvisTestApp.Entities.Tile;
using IdvisTestApp.Entities.Axis;
using IdvisTestApp.Entities.BarchartTile;
using IdvisTestApp.Entities.Dashboard;
using IdvisTestApp.Entities.DatasourceConnection;
using IdvisTestApp.Entities.Datasource;
using IdvisTestApp.Entities.Filter;
using IdvisTestApp.Entities.Folder;
using IdvisTestApp.Entities.GaugeTile;
using IdvisTestApp.Entities.HeatmapTile;
using IdvisTestApp.Entities.HistogramTile;
using IdvisTestApp.Entities.LinechartTile;
using IdvisTestApp.Entities.PiechartTile;
using IdvisTestApp.Entities.ScatterchartTile;
using IdvisTestApp.Entities.Series;
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
