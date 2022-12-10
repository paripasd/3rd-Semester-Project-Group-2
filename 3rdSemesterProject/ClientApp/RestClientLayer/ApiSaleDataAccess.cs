using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.ModelLayer;

namespace ClientApp.RestClientLayer
{
    internal class ApiSaleDataAccess
    {
        public string BaseUri { get; private set; }

        private RestClient RestClient { get; set; }

        public ApiSaleDataAccess(string baseUri)
        {
            BaseUri = baseUri;
            RestClient = new RestClient(baseUri);
        }

        public List<Sale> GetAllSales()
        {
            var request = new RestRequest();
            var response = RestClient.Execute<List<Sale>>(request);
            return response.Data;
        }
    }
}
