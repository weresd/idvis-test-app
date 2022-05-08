namespace IdvisTestApp.Entities.Datasource
{
    /// <summary>
    /// Class Datasource.
    /// </summary>
    public class Datasource
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Connection Id.
        /// </summary>
        public int ConnectionId { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Table Or Store Name.
        /// </summary>
        public string TableOrStoreName { get; set; }

        /// <summary>
        /// Dat Path From.
        /// </summary>
        public string DatPathFrom { get; set; }

        /// <summary>
        /// Dat Path Replace.
        /// </summary>
        public int DatPathReplace { get; set; }

        /// <summary>
        /// Dat Path To.
        /// </summary>
        public string DatPathTo { get; set; }

        /// <summary>
        /// Pdf Path From.
        /// </summary>
        public string PdfPathFrom { get; set; }

        /// <summary>
        /// Pdf Path Replace.
        /// </summary>
        public int PdfPathReplace { get; set; }

        /// <summary>
        /// Pdf Path To.
        /// </summary>
        public string PdfPathTo { get; set; }

        /// <summary>
        /// Dat Password.
        /// </summary>
        public string DatPassword { get; set; }
    }
}
