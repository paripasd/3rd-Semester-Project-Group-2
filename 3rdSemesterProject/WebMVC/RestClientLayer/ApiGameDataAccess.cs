using System;
using RestSharp;
using WebMVC.Models;

namespace WebMVC.RestClientLayer
{
	public class ApiGameDataAccess
	{
		public string BaseUri { get; private set; }
		public RestClient RestClient { get; set; }

		public ApiGameDataAccess(string baseUri)
		{
			BaseUri = baseUri;
			RestClient = new(BaseUri);
		}

		public IEnumerable<Game> GetAllGames()
		{
			var response = RestClient.Execute<IEnumerable<Game>>(new RestRequest());
			return response.Data;
		}

		public Game GetGameUsingId(int id)
		{
			var response = RestClient.Execute<Game>(new RestRequest(id.ToString()));
			return response.Data;
		}

		//testing method, this shouldn't be here on release
		public void CreateGame(Game game)
		{
			var request = new RestRequest();
			request.AddJsonBody(game);
			RestClient.Post(request);
		}
	}
}

