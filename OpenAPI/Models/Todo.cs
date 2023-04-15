

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OpenAPI.Models
{
    [BsonIgnoreExtraElements]
    public class Todo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("topic")]
        public string Topic { get; set; } = String.Empty;
        [BsonElement("complete")]
        public bool IsCompleted { get; set; } = false;

    }
}
