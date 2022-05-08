using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdvisTestApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ParentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dashboards_Dashboards_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Dashboards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DatasourceConnections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Host = table.Column<string>(type: "TEXT", nullable: true),
                    IntegratedSecurity = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Port = table.Column<int>(type: "INTEGER", nullable: false),
                    Realm = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    User = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatasourceConnections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ParentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Folders_Folders_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Folders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Datasources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConnectionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TableOrStoreName = table.Column<string>(type: "TEXT", nullable: true),
                    DatPathFrom = table.Column<string>(type: "TEXT", nullable: true),
                    DatPathReplace = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    DatPathTo = table.Column<string>(type: "TEXT", nullable: true),
                    PdfPathFrom = table.Column<string>(type: "TEXT", nullable: true),
                    PdfPathReplace = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    PdfPathTo = table.Column<string>(type: "TEXT", nullable: true),
                    DatPassword = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datasources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datasources_DatasourceConnections_ConnectionId",
                        column: x => x.ConnectionId,
                        principalTable: "DatasourceConnections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DashboardId = table.Column<int>(type: "INTEGER", nullable: false),
                    DatasourceId = table.Column<int>(type: "INTEGER", nullable: true),
                    H = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    UseDatFiles = table.Column<int>(type: "INTEGER", nullable: false),
                    W = table.Column<int>(type: "INTEGER", nullable: false),
                    X = table.Column<int>(type: "INTEGER", nullable: false),
                    Y = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tiles_Dashboards_DashboardId",
                        column: x => x.DashboardId,
                        principalTable: "Dashboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tiles_Datasources_DatasourceId",
                        column: x => x.DatasourceId,
                        principalTable: "Datasources",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BarchartTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AutoRefresh = table.Column<int>(type: "INTEGER", nullable: false),
                    Aggregator = table.Column<string>(type: "TEXT", nullable: true),
                    PercentageMode = table.Column<int>(type: "INTEGER", nullable: false),
                    DisplayMode = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryLimit = table.Column<int>(type: "INTEGER", nullable: true),
                    ShowOthers = table.Column<int>(type: "INTEGER", nullable: false),
                    LegendInTiledMode = table.Column<int>(type: "INTEGER", nullable: false),
                    TileId = table.Column<int>(type: "INTEGER", nullable: false),
                    SortMode = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarchartTiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarchartTiles_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DashboardId = table.Column<int>(type: "INTEGER", nullable: true),
                    DatasourceId = table.Column<int>(type: "INTEGER", nullable: true),
                    FileCount = table.Column<int>(type: "INTEGER", nullable: true),
                    IsRelative = table.Column<int>(type: "INTEGER", nullable: false),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    NumEnd = table.Column<float>(type: "REAL", nullable: true),
                    NumMultiEnd = table.Column<string>(type: "TEXT", nullable: true),
                    NumMultiRangeEnd = table.Column<float>(type: "REAL", nullable: true),
                    NumMultiStart = table.Column<string>(type: "TEXT", nullable: true),
                    NumStart = table.Column<float>(type: "REAL", nullable: true),
                    Operator = table.Column<string>(type: "TEXT", nullable: false),
                    RelativeDate = table.Column<string>(type: "TEXT", nullable: true),
                    StrPrefix = table.Column<string>(type: "TEXT", nullable: true),
                    StrValues = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    TileId = table.Column<int>(type: "INTEGER", nullable: true),
                    TimestampEnd = table.Column<int>(type: "INTEGER", nullable: true),
                    TimestampStart = table.Column<int>(type: "INTEGER", nullable: true),
                    WorkShiftEnd = table.Column<string>(type: "TEXT", nullable: true),
                    WorkShiftStart = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filters_Dashboards_DashboardId",
                        column: x => x.DashboardId,
                        principalTable: "Dashboards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Filters_Datasources_DatasourceId",
                        column: x => x.DatasourceId,
                        principalTable: "Datasources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Filters_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GaugeTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Aggregator = table.Column<string>(type: "TEXT", nullable: true),
                    AutoRefresh = table.Column<int>(type: "INTEGER", nullable: false),
                    Max = table.Column<float>(type: "REAL", nullable: false),
                    Min = table.Column<float>(type: "REAL", nullable: false),
                    ReverseColoring = table.Column<int>(type: "INTEGER", nullable: false),
                    TileId = table.Column<int>(type: "INTEGER", nullable: false),
                    LegendInTiledMode = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaugeTiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GaugeTiles_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeatmapTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AutoRefresh = table.Column<int>(type: "INTEGER", nullable: false),
                    LegendInTiledMode = table.Column<int>(type: "INTEGER", nullable: false),
                    ReverseColoring = table.Column<int>(type: "INTEGER", nullable: false),
                    TileId = table.Column<int>(type: "INTEGER", nullable: false),
                    UseEvents = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    QdrTimeMode = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeatmapTiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeatmapTiles_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistogramTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AutoRefresh = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryMode = table.Column<string>(type: "TEXT", nullable: true),
                    PercentageMode = table.Column<int>(type: "INTEGER", nullable: false),
                    RangeAuto = table.Column<int>(type: "INTEGER", nullable: false),
                    RangeCount = table.Column<int>(type: "INTEGER", nullable: true),
                    RangeEnd = table.Column<float>(type: "REAL", nullable: true),
                    RangeStart = table.Column<float>(type: "REAL", nullable: true),
                    RangeStep = table.Column<float>(type: "REAL", nullable: true),
                    TileId = table.Column<int>(type: "INTEGER", nullable: false),
                    LegendInTiledMode = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistogramTiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistogramTiles_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LinechartTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AutoRefresh = table.Column<int>(type: "INTEGER", nullable: false),
                    DatFileMode = table.Column<int>(type: "INTEGER", nullable: false),
                    TileId = table.Column<int>(type: "INTEGER", nullable: false),
                    LegendInTiledMode = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    UseEvents = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    QdrTimeMode = table.Column<int>(type: "INTEGER", nullable: true),
                    LastFileSignals = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinechartTiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinechartTiles_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PiechartTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Aggregator = table.Column<string>(type: "TEXT", nullable: true),
                    AutoRefresh = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryLimit = table.Column<int>(type: "INTEGER", nullable: true),
                    ShowOthers = table.Column<int>(type: "INTEGER", nullable: false),
                    TileId = table.Column<int>(type: "INTEGER", nullable: false),
                    LegendInTiledMode = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PiechartTiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PiechartTiles_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScatterchartTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AbsoluteTime = table.Column<int>(type: "INTEGER", nullable: false),
                    AutoRefresh = table.Column<int>(type: "INTEGER", nullable: false),
                    TileId = table.Column<int>(type: "INTEGER", nullable: false),
                    XAxisKey = table.Column<string>(type: "TEXT", nullable: true),
                    LegendInTiledMode = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScatterchartTiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScatterchartTiles_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Axis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarchartId = table.Column<int>(type: "INTEGER", nullable: true),
                    ColorAuto = table.Column<int>(type: "INTEGER", nullable: false),
                    ColorFrom = table.Column<string>(type: "TEXT", nullable: true),
                    ColorTo = table.Column<string>(type: "TEXT", nullable: true),
                    HeatmapId = table.Column<int>(type: "INTEGER", nullable: true),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    LinechartId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ScaleAuto = table.Column<int>(type: "INTEGER", nullable: false),
                    ScaleFrom = table.Column<float>(type: "REAL", nullable: true),
                    ScaleTo = table.Column<float>(type: "REAL", nullable: true),
                    ScatterchartId = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Axis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Axis_BarchartTiles_BarchartId",
                        column: x => x.BarchartId,
                        principalTable: "BarchartTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Axis_HeatmapTiles_HeatmapId",
                        column: x => x.HeatmapId,
                        principalTable: "HeatmapTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Axis_LinechartTiles_LinechartId",
                        column: x => x.LinechartId,
                        principalTable: "LinechartTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Axis_ScatterchartTiles_ScatterchartId",
                        column: x => x.ScatterchartId,
                        principalTable: "ScatterchartTiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarchartId = table.Column<int>(type: "INTEGER", nullable: true),
                    GaugeId = table.Column<int>(type: "INTEGER", nullable: true),
                    HeatmapId = table.Column<int>(type: "INTEGER", nullable: true),
                    HistogramId = table.Column<int>(type: "INTEGER", nullable: true),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    LegendedHeatmapId = table.Column<int>(type: "INTEGER", nullable: true),
                    LegendedLinechartId = table.Column<int>(type: "INTEGER", nullable: true),
                    LinechartId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Ordinal = table.Column<int>(type: "INTEGER", nullable: true),
                    PiechartId = table.Column<int>(type: "INTEGER", nullable: true),
                    Precision = table.Column<int>(type: "INTEGER", nullable: true),
                    ScatterchartId = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: true),
                    XBaseType = table.Column<string>(type: "TEXT", nullable: true),
                    XBaseTypes = table.Column<string>(type: "TEXT", nullable: true),
                    Aggregator = table.Column<string>(type: "TEXT", nullable: true),
                    Color = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_BarchartTiles_BarchartId",
                        column: x => x.BarchartId,
                        principalTable: "BarchartTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_GaugeTiles_GaugeId",
                        column: x => x.GaugeId,
                        principalTable: "GaugeTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_HeatmapTiles_HeatmapId",
                        column: x => x.HeatmapId,
                        principalTable: "HeatmapTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_HeatmapTiles_LegendedHeatmapId",
                        column: x => x.LegendedHeatmapId,
                        principalTable: "HeatmapTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_HistogramTiles_HistogramId",
                        column: x => x.HistogramId,
                        principalTable: "HistogramTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_LinechartTiles_LegendedLinechartId",
                        column: x => x.LegendedLinechartId,
                        principalTable: "LinechartTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_LinechartTiles_LinechartId",
                        column: x => x.LinechartId,
                        principalTable: "LinechartTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_PiechartTiles_PiechartId",
                        column: x => x.PiechartId,
                        principalTable: "PiechartTiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_ScatterchartTiles_ScatterchartId",
                        column: x => x.ScatterchartId,
                        principalTable: "ScatterchartTiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Axis_BarchartId",
                table: "Axis",
                column: "BarchartId");

            migrationBuilder.CreateIndex(
                name: "IX_Axis_HeatmapId",
                table: "Axis",
                column: "HeatmapId");

            migrationBuilder.CreateIndex(
                name: "IX_Axis_LinechartId",
                table: "Axis",
                column: "LinechartId");

            migrationBuilder.CreateIndex(
                name: "IX_Axis_ScatterchartId",
                table: "Axis",
                column: "ScatterchartId");

            migrationBuilder.CreateIndex(
                name: "IX_BarchartTiles_TileId",
                table: "BarchartTiles",
                column: "TileId");

            migrationBuilder.CreateIndex(
                name: "IX_Dashboards_ParentId",
                table: "Dashboards",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Datasources_ConnectionId",
                table: "Datasources",
                column: "ConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Filters_DashboardId",
                table: "Filters",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Filters_DatasourceId",
                table: "Filters",
                column: "DatasourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Filters_TileId",
                table: "Filters",
                column: "TileId");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_ParentId",
                table: "Folders",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_GaugeTiles_TileId",
                table: "GaugeTiles",
                column: "TileId");

            migrationBuilder.CreateIndex(
                name: "IX_HeatmapTiles_TileId",
                table: "HeatmapTiles",
                column: "TileId");

            migrationBuilder.CreateIndex(
                name: "IX_HistogramTiles_TileId",
                table: "HistogramTiles",
                column: "TileId");

            migrationBuilder.CreateIndex(
                name: "IX_LinechartTiles_TileId",
                table: "LinechartTiles",
                column: "TileId");

            migrationBuilder.CreateIndex(
                name: "IX_PiechartTiles_TileId",
                table: "PiechartTiles",
                column: "TileId");

            migrationBuilder.CreateIndex(
                name: "IX_ScatterchartTiles_TileId",
                table: "ScatterchartTiles",
                column: "TileId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_BarchartId",
                table: "Series",
                column: "BarchartId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_GaugeId",
                table: "Series",
                column: "GaugeId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_HeatmapId",
                table: "Series",
                column: "HeatmapId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_HistogramId",
                table: "Series",
                column: "HistogramId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_LegendedHeatmapId",
                table: "Series",
                column: "LegendedHeatmapId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_LegendedLinechartId",
                table: "Series",
                column: "LegendedLinechartId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_LinechartId",
                table: "Series",
                column: "LinechartId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_PiechartId",
                table: "Series",
                column: "PiechartId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_ScatterchartId",
                table: "Series",
                column: "ScatterchartId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiles_DashboardId",
                table: "Tiles",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiles_DatasourceId",
                table: "Tiles",
                column: "DatasourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Axis");

            migrationBuilder.DropTable(
                name: "Filters");

            migrationBuilder.DropTable(
                name: "Folders");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "BarchartTiles");

            migrationBuilder.DropTable(
                name: "GaugeTiles");

            migrationBuilder.DropTable(
                name: "HeatmapTiles");

            migrationBuilder.DropTable(
                name: "HistogramTiles");

            migrationBuilder.DropTable(
                name: "LinechartTiles");

            migrationBuilder.DropTable(
                name: "PiechartTiles");

            migrationBuilder.DropTable(
                name: "ScatterchartTiles");

            migrationBuilder.DropTable(
                name: "Tiles");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "Datasources");

            migrationBuilder.DropTable(
                name: "DatasourceConnections");
        }
    }
}
