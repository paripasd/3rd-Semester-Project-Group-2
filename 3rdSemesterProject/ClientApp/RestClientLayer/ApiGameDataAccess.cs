using ClientApp.ModelLayer;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.RestClientLayer
{
    internal class ApiGameDataAccess
    {
        public string BaseUri { get; private set; }

        private RestClient RestClient { get; set; }

        public ApiGameDataAccess(string baseUri)
        {
            BaseUri = baseUri;
            RestClient = new RestClient(baseUri);
        }

        public bool CreateGame(Game game)
        {
            var request = new RestRequest();
            request.AddJsonBody(game);
            return RestClient.Post<bool>(request).Data;
        }

        public IEnumerable<Game> GetGamesByDeveloperId(int developerId)
        {
            var request = new RestRequest("client/" + developerId.ToString());
            var response = RestClient.Execute<IEnumerable<Game>>(request);
            return response.Data;
        }

        public IEnumerable<Game> GetAllGames()
        {
            var request = new RestRequest();
            var response = RestClient.Execute<IEnumerable<Game>>(request);
            return response.Data;
        }

        public Game GetGameUsingId(int gameId)
        {
            var request = new RestRequest(gameId.ToString());
            var response = RestClient.Execute<Game>(request);
            return response.Data;
        }

        public Game GetGameFileByGameId(int gameId)
        {
            var request = new RestRequest("file/" + gameId.ToString());
            var response = RestClient.Execute<Game>(request);
            var keyResponse = JsonConvert.DeserializeObject<Game>(response.Content);
            return keyResponse;
        }

        public bool UpdateGame(Game g)
        {
            var request = new RestRequest("update/" + g);
            request.AddJsonBody(g);
            var response = RestClient.Put<bool>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error updating game {g}. Message was {response.StatusDescription}");
            }
            return response.Data;
        }
        public bool UpdateGameFile(Game gameFile)
        {
            var request = new RestRequest("update/gamefile/" + gameFile);
            request.AddJsonBody(gameFile);
            var response = RestClient.Put<bool>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error updating gamefile {gameFile}. Message was {response.StatusDescription}");
            }
            return response.Data;
        }

        public bool DeleteGame(int id)
        {
            var request = new RestRequest();
            request.AddJsonBody(id);
            var response = RestClient.Delete<bool>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error deleting game with id {id}. Message was {response.StatusDescription}");
            }
            return response.Data;
        }
    }
}
