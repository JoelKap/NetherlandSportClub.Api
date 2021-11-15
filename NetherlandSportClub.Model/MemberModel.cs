using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace NetherlandSportClub.Model
{
    public class MemberModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; } 
        public List<SportModel> MemberSports { get; set; }
    }
}
