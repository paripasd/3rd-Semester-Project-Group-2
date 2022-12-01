using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.ModelLayer;

namespace ClientApp.RestClientLayer
{
    internal interface IApiLoginDataAccess
    {
        public IEnumerable<Login> GetAllLogins();
        public bool ValidateLogin(Login incomingLogin);
    }
}
