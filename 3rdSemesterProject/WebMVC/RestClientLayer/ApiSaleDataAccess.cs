using System;
using RestSharp;
using WebMVC.Models;

namespace WebMVC.RestClientLayer
{
	public class ApiSaleDataAccess
	{
		public string BaseUri { get; private set; }
		public RestClient RestClient { get; set; }

		public ApiSaleDataAccess(string baseUri)
		{
			BaseUri = baseUri;
			RestClient = new(BaseUri);
		}

		public bool CreateSale(Sale sale)
		{
			var request = new RestRequest();
			request.AddJsonBody(sale);
			return RestClient.Post<bool>(request);
		}
	}
}

