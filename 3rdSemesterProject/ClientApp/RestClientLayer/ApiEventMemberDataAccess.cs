using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.ModelLayer;

namespace ClientApp.RestClientLayer
{
    internal class ApiEventMemberDataAccess
    {
        public string BaseUri { get; private set; }

        private RestClient RestClient { get; set; }

        public ApiEventMemberDataAccess(string baseUri)
        {
            BaseUri = baseUri;
            RestClient = new RestClient(baseUri);
        }


        public bool DeleteEvent(EventMember em)
        {
            var request = new RestRequest();
            request.AddJsonBody(em);
            var response = RestClient.Delete<bool>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error deleting event member with id {em.EventMemberID}. Message was {response.StatusDescription}");
            }
            return response.Data;
        }

        public Event FindMemberFromEventId(int eventId)
        {
            var request = new RestRequest(eventId.ToString());
            var response = RestClient.Execute<Event>(request).Data;
            return response;
        }
    }
}
