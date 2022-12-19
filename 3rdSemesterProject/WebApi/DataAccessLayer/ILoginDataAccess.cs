using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public interface ILoginDataAccess
    {
        public bool CreateLogin(Login login);
        public IEnumerable<Login> GetAllLoginInformation();
        //public bool UpdateLogin(Login login);
        public bool DeleteLogin(Login login);
    }
}
