﻿using System;
using System.Linq;
using RestSharp;
using WebMVC.Models;
using Newtonsoft.Json;

namespace WebMVC.RestClientLayer
{
	public class ApiMemberDataAccess
	{
		public string BaseUri { get; private set; }
		public RestClient RestClient { get; set; }

		public ApiMemberDataAccess(string baseUri)
		{
			BaseUri = baseUri;
			RestClient = new(BaseUri);
		}

		public void CreateMember(string email)
		{
			string json = System.Text.Json.JsonSerializer.Serialize(new { MemberID = 0, Email = email, Name = "No Name Provided" });
			var request = new RestRequest("", Method.Post);
			request.AddStringBody(json, DataFormat.Json);
			var response = RestClient.Execute(request);
		}

		public IEnumerable<Member> GetAllMembers()
		{
			var response = RestClient.Execute<IEnumerable<Member>>(new RestRequest());
			return response.Data;
		}
	}
}

