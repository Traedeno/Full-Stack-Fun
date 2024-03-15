
namespace APIFun.Data
{
    public class EFBowlRepository : IBowlRepository
    {
        private BowlingleagueContext _BowlContext;
        public EFBowlRepository(BowlingleagueContext temp) {
            _BowlContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _BowlContext.Bowlers;

         public IEnumerable<BowlingFin> GetAllBowlers()
        {
            var BowlerTeam = from bowler in _BowlContext.Bowlers
                             join team in _BowlContext.Teams on bowler.TeamId equals team.TeamId into bowlerTeam
                             from bt in bowlerTeam.DefaultIfEmpty()
                             where bt != null && (bt.TeamName == "Sharks" || bt.TeamName == "Marlins")
                             select new BowlingFin
                             {
                                 BowlerId = bowler.BowlerId,
                                 BowlerLastName = bowler.BowlerLastName,
                                 BowlerFirstName = bowler.BowlerFirstName,
                                 BowlerMiddleInit = bowler.BowlerMiddleInit,
                                 BowlerAddress = bowler.BowlerAddress,
                                 BowlerCity = bowler.BowlerCity,
                                 BowlerState = bowler.BowlerState,
                                 BowlerZip = bowler.BowlerZip,
                                 BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                 TeamName = bt != null ? bt.TeamName : "No Team" // Handle cases where no team is assigned
                             };
            return BowlerTeam.ToList();
        }
    }
}
