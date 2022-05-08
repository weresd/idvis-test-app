namespace IdvisTestApp.Entities.BarchartTile
{
    /// <summary>
    /// Class BarchartTile.
    /// </summary>
    public class BarchartTile
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
        /// Aggregator.
        /// </summary>
        public string Aggregator { get; set; }

        /// <summary>
        /// Percentage Mode.
        /// </summary>
        public int PercentageMode { get; set; }

        /// <summary>
        /// Display Mode.
        /// </summary>
        public int DisplayMode { get; set; }

        /// <summary>
        /// Category Limit.
        /// </summary>
        public int CategoryLimit { get; set; }

        /// <summary>
        /// Show Others.
        /// </summary>
        public int ShowOthers { get; set; }

        /// <summary>
        /// Legend In Tiled Mode.
        /// </summary>
        public int LegendInTiledMode { get; set; }

        /// <summary>
        /// Tile Id.
        /// </summary>
        public int TileId { get; set; }

        /// <summary>
        /// Sort Mode.
        /// </summary>
        public int SortMode { get; set; }
    }
}
