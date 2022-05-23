using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EffenaarTest.Model
{
    public class achievementModel
    {
        [BsonId]
        [BsonRepresentation((BsonType.ObjectId))]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Achieved { get; set; }
    }
}