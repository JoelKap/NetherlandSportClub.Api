using MongoDB.Driver;
using NetherlandSportClub.Core;
using NetherlandSportClub.Core.Contracts;
using NetherlandSportClub.Service.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace NetherlandSportClub.Service.Implementation
{
    public class SportService : ISportService
    {
        private readonly IMongoCollection<Sport> _sports;
        public SportService(IDbClient dbClient)
        {
            _sports = dbClient.GetSportCollection();
        }

        public Sport AddSport(Sport sport)
        {
            _sports.InsertOne(sport);
            return sport;
        }
         
        public void Delete(string id)
        {
            _sports.DeleteOne(sport => sport.Id == id); 
        }

        public List<Sport> GetSports() => _sports.Find(sport => true).ToList();

        public Sport Update(Sport sport)
        {
            _sports.ReplaceOne(s => s.Id == sport.Id, sport);
            return sport;
        }
    }
}
