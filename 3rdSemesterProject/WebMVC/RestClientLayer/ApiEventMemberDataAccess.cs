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
			string members = response.Content;
			int[] memberArray = JsonConvert.DeserializeObject<int[]>(members);
			int memberAmount = memberArray.Count();
			return JsonConvert.SerializeObject(memberAmount);
		}

		public bool JoinEvent(EventMember eventMember)
		{
			string json = System.Text.Json.JsonSerializer.Serialize(eventMember);
			var request = new RestRequest("", Method.Post);
			request.AddStringBody(json, DataFormat.Json);
			var response = RestClient.Execute(request);
			if (response.IsSuccessful) return true;
			else return false;
		}
	}
}

