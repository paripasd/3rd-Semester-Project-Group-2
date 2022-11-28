using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public interface IGameDataAccess
    {
        public bool CreateGame(Game game);
        public Game FindGameFromId(int gameId);
        public IEnumerable<Game> GetAllGames();
        public bool UpdateAllGameDetails(Game game);
        public bool DeleteGame(int id);
    }
}
