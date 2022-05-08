using System.ComponentModel.DataAnnotations.Schema;

namespace IdvisTestApp.Entities.Dashboard
{
    /// <summary>
    /// Class Dashboard.
    /// </summary>
    public class Dashboard
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Parent Id.
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Parent Dashboard.
        /// </summary>
        [ForeignKey("ParentId")]
        public Dashboard? ParentDashboard { get; set; }
    }
}
