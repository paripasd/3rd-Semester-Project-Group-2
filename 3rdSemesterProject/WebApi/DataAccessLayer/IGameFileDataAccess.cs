using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public interface IGameFileDataAccess
    {
        public bool AddGame(GameFile gameFile);
        
    }
}
