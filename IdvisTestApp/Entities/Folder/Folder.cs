namespace IdvisTestApp.Entities.Folder
{
    /// <summary>
    /// Class Folder.
    /// </summary>
    public class Folder
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Parent Id.
        /// </summary>
        public int ParentId { get; set; }
    }
}
