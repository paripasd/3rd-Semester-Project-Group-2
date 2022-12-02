using System;
using RestSharp;
using WebMVC.Models;

namespace WebMVC.RestClientLayer
{
	public class ApiDeveloperDataAccess
	{
		public string BaseUri { get; private set; }
		public RestClient RestClient { get; set; }

		public ApiDeveloperDataAccess(string baseUri)
		{
			BaseUri = baseUri;
			RestClient = new(BaseUri);
		}

		public IEnumerable<Developer> GetAllDevelopers()
		{
			var response = RestClient.Execute<IEnumerable<Developer>>(new RestRequest());
			return response.Data;
		}
	}
}

