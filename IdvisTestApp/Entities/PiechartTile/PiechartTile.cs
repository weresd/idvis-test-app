namespace IdvisTestApp.Entities.PiechartTile
{
    /// <summary>
    /// Class PiechartTile.
    /// </summary>
    public class PiechartTile
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Aggregator.
        /// </summary>
        public string Aggregator { get; set; }

        /// <summary>
        /// Auto Refresh.
        /// </summary>
        public int AutoRefresh { get; set; }

        /// <summary>
        /// Category Limit.
        /// </summary>
        public int CategoryLimit { get; set; }

        /// <summary>
        /// Show Others.
        /// </summary>
        public int ShowOthers { get; set; }

        /// <summary>
        /// Tile Id.
        /// </summary>
        public int TileId { get; set; }

        /// <summary>
        /// Legend In Tiled Mode.
        /// </summary>
        public int LegendInTiledMode { get; set; }
    }
}
