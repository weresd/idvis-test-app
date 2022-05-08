namespace IdvisTestApp.Entities.HeatmapTile
{
    /// <summary>
    /// Class HeatmapTile.
    /// </summary>
    public class HeatmapTile
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
        /// Legend In Tiled Mode.
        /// </summary>
        public int LegendInTiledMode { get; set; }

        /// <summary>
        /// Reverse Coloring.
        /// </summary>
        public int ReverseColoring { get; set; }

        /// <summary>
        /// Tile Id.
        /// </summary>
        public int TileId { get; set; }

        /// <summary>
        /// Use Events.
        /// </summary>
        public int UseEvents { get; set; }

        /// <summary>
        /// Qdr Time Mode.
        /// </summary>
        public int QdrTimeMode { get; set; }
    }
}
