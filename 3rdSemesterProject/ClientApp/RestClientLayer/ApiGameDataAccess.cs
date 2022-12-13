using ClientApp.ModelLayer;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.Design.AxImporter;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

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
            // Serialize the object to JSON using a different library
            var json = JsonConvert.SerializeObject(game);
            // Add the JSON string to the request body
            request.AddParameter("application/json", json, ParameterType.RequestBody);
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

        public void UpdateGame(Game g)
        {
            var request = new RestRequest();
            // Serialize the object to JSON using a different library
            var json = JsonConvert.SerializeObject(g);
            // Add the JSON string to the request body
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            var response = RestClient.Put<bool>(request);

        }
        /*public bool UpdateGameFile(Game gameFile)
        {
            var request = new RestRequest("update/gamefile");
            request.AddJsonBody(gameFile);
            var response = RestClient.Put<bool>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error updating gamefile {gameFile}. Message was {response.StatusDescription}");
            }
            return response.Data;
        }*/

        public void DeleteGame(int id)
        {
            var request = new RestRequest(id.ToString());
            request.AddJsonBody(id);
            var response = RestClient.Delete<bool>(request);

            /*if (!response.IsSuccessful)
            {
                throw new Exception($"Error deleting game with id {id}. Message was {response.StatusDescription}");
            }
            return response.Data;*/
        }
    }
}
