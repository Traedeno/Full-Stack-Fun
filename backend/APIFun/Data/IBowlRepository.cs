namespace APIFun.Data
{
    public interface IBowlRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<BowlingFin> GetAllBowlers();
    }
}
