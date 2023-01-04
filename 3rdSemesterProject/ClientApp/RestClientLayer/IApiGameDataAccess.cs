using ClientApp.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestClientLayer
{
    internal interface IApiGameDataAccess
    {
        public bool CreateGame(Game game,GameFile gameFile);
    }
}
