using System;
using System.Linq;
using RestSharp;
using WebMVC.Models;
using Newtonsoft.Json;

namespace WebMVC.RestClientLayer
{
	public class ApiEventMemberDataAccess
	{
		public string BaseUri { get; private set; }
		public RestClient RestClient { get; set; }

		public ApiEventMemberDataAccess(string baseUri)
		{
			BaseUri = baseUri;
			RestClient = new(BaseUri);
		}

		public string GetMemberAmount(int eventId)
		{
			var response = RestClient.Execute<IEnumerable<Event>>(new RestRequest("event/" + eventId));
			int memberAmount = response.Data.Count();
			return JsonConvert.SerializeObject(memberAmount);
		}

		public void JoinEvent(int eventId)
		{
			string json = System.Text.Json.JsonSerializer.Serialize(new {EventID = eventId});
			var request = new RestRequest("", Method.Post);
			request.AddStringBody(json, DataFormat.Json);
			var response = RestClient.Execute(request);
		}
	}
}

