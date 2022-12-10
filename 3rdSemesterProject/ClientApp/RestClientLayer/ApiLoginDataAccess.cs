using ClientApp.ModelLayer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestClientLayer
{
    internal class ApiLoginDataAccess
    {
        public string BaseUri { get; private set; }

        private RestClient RestClient { get; set; }

        public ApiLoginDataAccess(string baseUri)
        {
            BaseUri = baseUri;
            RestClient = new RestClient(baseUri);
        }
        public IEnumerable<Login> GetAllLogins()
        {
            var request = new RestRequest();
            var response = RestClient.Execute<IEnumerable<Login>>(request);
            return response.Data;
        }

        #region Helper Methods

        public bool ValidateLogin(Login incomingLogin)
        {
            IEnumerable<Login> logins = GetAllLogins();
            foreach (Login login in logins)
            {
                bool IsValidUserName = incomingLogin.UserName.Equals(login.UserName);
                bool IsValidPassword = Login.ValidatePassword(incomingLogin.Password,login.Password);
                if (IsValidUserName == true && IsValidPassword == true)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
