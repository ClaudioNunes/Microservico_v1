using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Microservico.Models
{
    public class Aluno
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string RA{ get; set; }
        public string Nome { get; set; }
     

    }
}
