namespace OpenAPI.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string TodoCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}
