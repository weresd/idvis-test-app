using IdvisTestApp.Entities.Tiles;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdvisTestApp.Entities.HistogramTiles
{
    /// <summary>
    /// Class HistogramTile.
    /// </summary>
    public class HistogramTile
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Auto Refresh.
        /// </summary>
        public int AutoRefresh { get; set; }

        /// <summary>
        /// Category Mode.
        /// </summary>
        public string? CategoryMode { get; set; }

        /// <summary>
        /// Percentage Mode.
        /// </summary>
        public int PercentageMode { get; set; }

        /// <summary>
        /// Range Auto.
        /// </summary>
        public int RangeAuto { get; set; }

        /// <summary>
        /// Range Count.
        /// </summary>
        public int? RangeCount { get; set; }

        /// <summary>
        /// Range End.
        /// </summary>
        public float? RangeEnd { get; set; }

        /// <summary>
        /// Range Start.
        /// </summary>
        public float? RangeStart { get; set; }

        /// <summary>
        /// Range Step.
        /// </summary>
        public float? RangeStep { get; set; }

        /// <summary>
        /// Tile Id.
        /// </summary>
        public int TileId { get; set; }

        /// <summary>
        /// Legend In Tiled Mode.
        /// </summary>
        public int LegendInTiledMode { get; set; }

        /// <summary>
        /// Tile.
        /// </summary>
        [ForeignKey("TileId")]
        public Tile Tile { get; set; }
    }
}
