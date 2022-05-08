using System.ComponentModel.DataAnnotations.Schema;

namespace IdvisTestApp.Entities.Axis
{
    /// <summary>
    /// Class Axis.
    /// </summary>
    public class Axis
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
        /// Color Auto.
        /// </summary>
        public int ColorAuto { get; set; }

        /// <summary>
        /// Color From.
        /// </summary>
        public string? ColorFrom { get; set; }

        /// <summary>
        /// Color To.
        /// </summary>
        public string? ColorTo { get; set; }

        /// <summary>
        /// Heatmap Id.
        /// </summary>
        public int? HeatmapId { get; set; }

        /// <summary>
        /// Key.
        /// </summary>
        public string? Key { get; set; }

        /// <summary>
        /// Linechart Id.
        /// </summary>
        public int? LinechartId { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Scale Auto.
        /// </summary>
        public int ScaleAuto { get; set; }

        /// <summary>
        /// Scale From.
        /// </summary>
        public float? ScaleFrom { get; set; }

        /// <summary>
        /// Scale To.
        /// </summary>
        public float? ScaleTo { get; set; }

        /// <summary>
        /// Scatterchart Id.
        /// </summary>
        public int? ScatterchartId { get; set; }

        /// <summary>
        /// Type.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Barchart Tile.
        /// </summary>
        [ForeignKey("BarchartId")]
        public BarchartTile.BarchartTile? BarchartTile { get; set; }

        /// <summary>
        /// Heatmap Tile.
        /// </summary>
        [ForeignKey("HeatmapId")]
        public HeatmapTile.HeatmapTile? HeatmapTile { get; set; }

        /// <summary>
        /// Linechart Tile.
        /// </summary>
        [ForeignKey("LinechartId")]
        public LinechartTile.LinechartTile? LinechartTile { get; set; }

        /// <summary>
        /// Scatterchart Tile.
        /// </summary>
        [ForeignKey("ScatterchartId")]
        public ScatterchartTile.ScatterchartTile? ScatterchartTile { get; set; }
    }
}
