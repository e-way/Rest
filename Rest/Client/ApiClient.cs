using Rest.Model;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Client
{
    public class ApiClient
    {
        private IRestClient _client;
        private string _token;
        private string _baseUrl;

        public ApiClient(string baseUrl, string token)
        {
            _baseUrl = baseUrl;
            _token = token;
        }

        public IRestClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new RestClient(_baseUrl);
                }
                _client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(_token, "token");
                return _client;
            }
        }

        public List<Emails> GetEmails()
        {
            var request = new RestRequest(Method.GET)
            {
                Resource = "/user/emails"
            };

            var response = Client.Execute<List<Emails>>(request);
            if (!response.IsSuccessful)
            {
                throw new ApiClientException("Api client exception!");
            }
            return response.Data;
        }       
    }
}
