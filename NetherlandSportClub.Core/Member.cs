using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace NetherlandSportClub.Core
{
    public class Member
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public List<Sport> MemberSports { get; set; } = new List<Sport>();
    }
}
