namespace IdvisTestApp.Entities.DatasourceConnection
{
    /// <summary>
    /// Class DatasourceConnection.
    /// </summary>
    public class DatasourceConnection
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Host.
        /// </summary>
        public string? Host { get; set; }

        /// <summary>
        /// Integrated Security.
        /// </summary>
        public int IntegratedSecurity { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Port.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Realm.
        /// </summary>
        public string? Realm { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        public string? User { get; set; }
    }
}
