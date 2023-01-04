using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public interface IGameFileDataAccess
    {
        //public bool AddGame(GameFile gameFile);
        public bool UpdateGameFile(GameFile gameFile);
        public GameFile GetGameFileById(int gameId);
    }
}
