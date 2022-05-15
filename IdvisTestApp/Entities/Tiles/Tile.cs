using IdvisTestApp.Entities.Dashboards;
using IdvisTestApp.Entities.Datasources;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdvisTestApp.Entities.Tiles
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

        /// <summary>
        /// Dashboard.
        /// </summary>
        [ForeignKey("DashboardId")]
        public Dashboard Dashboard { get; set; }

        /// <summary>
        /// Datasource.
        /// </summary>
        [ForeignKey("DatasourceId")]
        public Datasource? Datasource { get; set; }
    }
}
