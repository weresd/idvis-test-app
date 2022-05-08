namespace IdvisTestApp.Entities.Tile
{
    /// <summary>
    /// Class Tile.
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Dashboard id.
        /// </summary>
        public int DashboardId { get; set; }

        /// <summary>
        /// Datasource id.
        /// </summary>
        public int? DatasourceId { get; set; }

        /// <summary>
        /// H.
        /// </summary>
        public int H { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Use dat files.
        /// </summary>
        public int UseDatFiles { get; set; }

        /// <summary>
        /// W.
        /// </summary>
        public int W { get; set; }

        /// <summary>
        /// X.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y.
        /// </summary>
        public int Y { get; set; }
    }
}
