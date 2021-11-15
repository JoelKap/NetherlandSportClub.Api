using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NetherlandSportClub.Core.Contracts;

namespace NetherlandSportClub.Core.Implementataion
{
    public class DbClient : IDbClient
    { 
        private readonly IMongoCollection<Sport> _sports;
        private readonly IMongoCollection<Member> _members;
        public DbClient(IOptions<NetherlandSportClubDbConfig> netherlandSportClubDbConfig )
        {
            var client = new MongoClient(netherlandSportClubDbConfig.Value.Connection_String);
            var database = client.GetDatabase(netherlandSportClubDbConfig.Value.Database_Name);
            _sports = database.GetCollection<Sport>(netherlandSportClubDbConfig.Value.Sports_Collection_Name);
            _members = database.GetCollection<Member>(netherlandSportClubDbConfig.Value.Members_Collection_Name);

        }

        public IMongoCollection<Member> GetMembersCollection() => _members;

        public IMongoCollection<Sport> GetSportCollection() => _sports;
    }
}
