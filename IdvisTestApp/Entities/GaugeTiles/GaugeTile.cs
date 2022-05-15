using IdvisTestApp.Entities.Tiles;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdvisTestApp.Entities.GaugeTiles
{
    /// <summary>
    /// Class GaugeTile.
    /// </summary>
    public class GaugeTile
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Aggregator.
        /// </summary>
        public string? Aggregator { get; set; }

        /// <summary>
        /// Auto Refresh.
        /// </summary>
        public int AutoRefresh { get; set; }

        /// <summary>
        /// Max.
        /// </summary>
        public float Max { get; set; }

        /// <summary>
        /// Min.
        /// </summary>
        public float Min { get; set; }

        /// <summary>
        /// Reverse Coloring.
        /// </summary>
        public int ReverseColoring { get; set; }

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
