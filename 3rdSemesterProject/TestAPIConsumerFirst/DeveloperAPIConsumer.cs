using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace TestAPIConsumerFirst
{
    internal class DeveloperAPIConsumer
    {
        public string ServiceUri { get; private set; }
        public DeveloperAPIConsumer(string baseServiceUri)
        {
            ServiceUri = baseServiceUri;
        }

        public IEnumerable<Developer> GetAllDevelopers()
        {
            //create a client for calling the server
            var client = new RestClient(ServiceUri);

            //execute a RestRequest (default is GET)
            //and return a List<Account>,
            //which is automatically deserialized to objects
            var response = client.Execute<List<Developer>>(new RestRequest());

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error retrieving all Developers. Message was {response.StatusDescription}");
            }
            return response.Data;
        }

        public Developer AddDeveloper(Developer developerToAdd)
        {
            //get the JSON to send from the developer object
            string json = JsonSerializer.Serialize(developerToAdd);
            //create a new request, using POST, with the JSON from the developer
            var request = new RestRequest(Method.POST).AddJsonBody(json);
            //call the server
            var client = new RestClient(ServiceUri);
            //get a response
            var response = client.Post<Developer>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error adding developer. Message was {response.StatusDescription}");
            }
            return response.Data;
        }

        public void DeleteDeveloper(int idOfDeveloperToDelete)
        {
            //call the server
            var client = new RestClient($"{ServiceUri}/{idOfDeveloperToDelete}");
            //get a response
            var response = client.Delete(new RestRequest());

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error deleting developer with id {idOfDeveloperToDelete}. Message was {response.StatusDescription}");
            }

        }
    }
}
