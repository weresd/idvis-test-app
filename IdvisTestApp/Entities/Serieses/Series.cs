using IdvisTestApp.Entities.BarchartTiles;
using IdvisTestApp.Entities.GaugeTiles;
using IdvisTestApp.Entities.HeatmapTiles;
using IdvisTestApp.Entities.HistogramTiles;
using IdvisTestApp.Entities.LinechartTiles;
using IdvisTestApp.Entities.PiechartTiles;
using IdvisTestApp.Entities.ScatterchartTiles;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdvisTestApp.Entities.Serieses
{
    /// <summary>
    /// Class Series.
    /// </summary>
    public class Series
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Barchart Id.
        /// </summary>
        public int? BarchartId { get; set; }

        /// <summary>
        /// Gauge Id.
        /// </summary>
        public int? GaugeId { get; set; }

        /// <summary>
        /// Heatmap Id.
        /// </summary>
        public int? HeatmapId { get; set; }

        /// <summary>
        /// Histogram Id.
        /// </summary>
        public int? HistogramId { get; set; }

        /// <summary>
        /// Key.
        /// </summary>
        public string? Key { get; set; }

        /// <summary>
        /// Legended Heatmap Id.
        /// </summary>
        public int? LegendedHeatmapId { get; set; }

        /// <summary>
        /// Legended Linechart Id.
        /// </summary>
        public int? LegendedLinechartId { get; set; }

        /// <summary>
        /// Linechart Id.
        /// </summary>
        public int? LinechartId { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Ordinal.
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// Piechart Id.
        /// </summary>
        public int? PiechartId { get; set; }

        /// <summary>
        /// Precision.
        /// </summary>
        public int? Precision { get; set; }

        /// <summary>
        /// Scatterchart Id.
        /// </summary>
        public int? ScatterchartId { get; set; }

        /// <summary>
        /// Type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Unit.
        /// </summary>
        public string? Unit { get; set; }

        /// <summary>
        /// X Base Type.
        /// </summary>
        public string? XBaseType { get; set; }

        /// <summary>
        /// X Base Types.
        /// </summary>
        public string? XBaseTypes { get; set; }

        /// <summary>
        /// Aggregator.
        /// </summary>
        public string? Aggregator { get; set; }

        /// <summary>
        /// Color.
        /// </summary>
        public string? Color { get; set; }

        /// <summary>
        /// Barchart Tile.
        /// </summary>
        [ForeignKey("BarchartId")]
        public BarchartTile? BarchartTile  { get; set; }

        /// <summary>
        /// Gauge Tile.
        /// </summary>
        [ForeignKey("GaugeId")]
        public GaugeTile? GaugeTile { get; set; }

        /// <summary>
        /// Heatmap Tile.
        /// </summary>
        [ForeignKey("HeatmapId")]
        public HeatmapTile? HeatmapTile { get; set; }

        /// <summary>
        /// Legended Heatmap Tile.
        /// </summary>
        [ForeignKey("LegendedHeatmapId")]
        public HeatmapTile? LegendedHeatmapTile { get; set; }

        /// <summary>
        /// Histogram Tile.
        /// </summary>
        [ForeignKey("HistogramId")]
        public HistogramTile? HistogramTile { get; set; }

        /// <summary>
        /// Legended Linechart Tile.
        /// </summary>
        [ForeignKey("LegendedLinechartId")]
        public LinechartTile? LegendedLinechartTile { get; set; }

        /// <summary>
        /// Linechart Tile.
        /// </summary>
        [ForeignKey("LinechartId")]
        public LinechartTile? LinechartTile { get; set; }

        /// <summary>
        /// Piechart Tile.
        /// </summary>
        [ForeignKey("PiechartId")]
        public PiechartTile? PiechartTile { get; set; }

        /// <summary>
        /// Scatterchart Tile.
        /// </summary>
        [ForeignKey("ScatterchartId")]
        public ScatterchartTile? ScatterchartTile { get; set; }
    }
}
