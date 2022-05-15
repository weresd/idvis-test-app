using IdvisTestApp.Entities.Tiles;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdvisTestApp.Entities.ScatterchartTiles
{
    /// <summary>
    /// Class ScatterchartTile.
    /// </summary>
    public class ScatterchartTile
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Absolute Time.
        /// </summary>
        public int AbsoluteTime { get; set; }

        /// <summary>
        /// Auto Refresh.
        /// </summary>
        public int AutoRefresh { get; set; }

        /// <summary>
        /// Tile Id.
        /// </summary>
        public int TileId { get; set; }

        /// <summary>
        /// X Axis Key.
        /// </summary>
        public string? XAxisKey { get; set; }

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
