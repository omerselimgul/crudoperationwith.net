namespace OpenAPI.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string TodoCollectionName { get; set; } = Environment.GetEnvironmentVariable("Collection_Name").ToString();
        public string ConnectionString { get; set; } = Environment.GetEnvironmentVariable("Connection_String").ToString();
        public string DatabaseName { get; set; } = Environment.GetEnvironmentVariable("Database_Name").ToString();
    }
}
