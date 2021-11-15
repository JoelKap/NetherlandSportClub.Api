using MongoDB.Driver;
using NetherlandSportClub.Core;
using NetherlandSportClub.Core.Contracts;
using NetherlandSportClub.Service.Contracts;
using System.Collections.Generic;

namespace NetherlandSportClub.Service.Implementation
{
    public class MemberService: IMemberService
    {
        private readonly IMongoCollection<Member> _members;
        public MemberService(IDbClient dbClient)
        { 
            _members = dbClient.GetMembersCollection();
        }

        public Member AddMember(Member member)
        {
            _members.InsertOne(member);
            return member;
        }

        public void Delete(string id) => _members.DeleteOne(member => member.Id == id);

        public List<Member> GetMembers() => _members.Find(sport => true).ToList();

        public Member Update(Member member)
        {
            _members.ReplaceOne(m => m.Id == member.Id, member);
            return member;
        }
    }
}
