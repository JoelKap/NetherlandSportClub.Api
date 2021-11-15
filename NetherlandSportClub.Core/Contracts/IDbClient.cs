using MongoDB.Driver;
    
namespace NetherlandSportClub.Core.Contracts
{
    public interface IDbClient
    {
        IMongoCollection<Sport> GetSportCollection();
        IMongoCollection<Member> GetMembersCollection();
    }
}
