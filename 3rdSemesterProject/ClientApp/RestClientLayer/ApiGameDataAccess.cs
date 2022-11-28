using ClientApp.ModelLayer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestClientLayer
{
    internal class ApiGameDataAccess : IApiGameDataAccess
    {
        public string BaseUri { get; private set; }

        private RestClient RestClient { get; set; }

        public ApiGameDataAccess(string baseUri)
        {
            BaseUri = baseUri;
            RestClient = new RestClient(baseUri);
        }

        public bool CreateGame(Game game, GameFile gameFile)
        {
            var request = new RestRequest();
            request.AddJsonBody(game);
            return RestClient.Post<bool>(request).Data;
        }
    }
}
