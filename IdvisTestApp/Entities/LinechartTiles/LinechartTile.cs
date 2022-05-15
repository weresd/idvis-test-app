using IdvisTestApp.Entities.Tiles;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdvisTestApp.Entities.LinechartTiles
{
    /// <summary>
    /// Class LinechartTile.
    /// </summary>
    public class LinechartTile
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
        /// Dat File Mode.
        /// </summary>
        public int DatFileMode { get; set; }

        /// <summary>
        /// Tile Id.
        /// </summary>
        public int TileId { get; set; }

        /// <summary>
        /// Legend In Tiled Mode.
        /// </summary>
        public int LegendInTiledMode { get; set; }

        /// <summary>
        /// Use Events.
        /// </summary>
        public int UseEvents { get; set; }

        /// <summary>
        /// Qdr Time Mode.
        /// </summary>
        public int? QdrTimeMode { get; set; }

        /// <summary>
        /// Last File Signals.
        /// </summary>
        public int LastFileSignals { get; set; }

        /// <summary>
        /// Tile.
        /// </summary>
        [ForeignKey("TileId")]
        public Tile Tile { get; set; }
    }
}
