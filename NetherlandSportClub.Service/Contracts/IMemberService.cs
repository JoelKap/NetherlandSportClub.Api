using NetherlandSportClub.Core;
using System.Collections.Generic;

namespace NetherlandSportClub.Service.Contracts
{
    public interface IMemberService
    {
        List<Member> GetMembers();
        Member AddMember(Member member);
        Member Update(Member member);
        void Delete(string id); 
    }
}
