namespace FootballMatchesBetting.Database
{
    public interface IDbContextFactory
    {
        FootballMatchesDb Create();
    }

    public class DbContextFactory : IDbContextFactory
    {
        public FootballMatchesDb Create()
        {
            return new FootballMatchesDb();
        }
    }
}