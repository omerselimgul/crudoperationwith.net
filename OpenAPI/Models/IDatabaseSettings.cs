namespace OpenAPI.Models
{
    public interface IDatabaseSettings
    {
        string TodoCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
