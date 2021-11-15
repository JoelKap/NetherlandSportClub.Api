using NetherlandSportClub.Core;
using System.Collections.Generic;

namespace NetherlandSportClub.Service.Contracts
{
    public interface ISportService
    {
        List<Sport> GetSports();
        Sport AddSport(Sport sport);
        Sport Update(Sport sport);
        void Delete(string id);
    }
}
