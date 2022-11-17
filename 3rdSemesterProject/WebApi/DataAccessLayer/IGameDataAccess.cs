using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public interface IGameDataAccess
    {
        public void CreateGame(Game game);
        public Game FindGameFromId(int gameId);
        public IEnumerable<Game> GetAllGames();
        public bool UpdateGame(Game game);
        public bool DeleteGame(Game game);
    }
}
