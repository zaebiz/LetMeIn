using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAuth.LetMeIn.Infrastructure;
using OAuth.LetMeIn.Models;
using RestSharp;

namespace OAuth.LetMeIn
{
    public class OAuthConnector
    {
        private IProviderSettiings _provider;
        private IClientSettings _client;

        public OAuthConnector(IProviderSettiings settings, IClientSettings client)
        {
            _client = client;
            _provider = settings;
        }

        public string CreateAuthCodeRequestUrl(CodeRequest request)
        {
            string url = $"{_provider.ProviderUrl}/{_provider.GetCodeMethod}?";

            var props = request.GetType()
                .GetProperties()
                .Where(x => x.GetValue(request) != null);

            foreach (var p in props)
            {
                var attr = p.GetCustomAttributes(typeof(UrlParameterAttribute), false)
                    .Cast<UrlParameterAttribute>()
                    .FirstOrDefault();

                if (attr != null)
                    url += $"{attr.ParamName}={p.GetValue(request)}&";
                else
                    url += $"{p.Name}={p.GetValue(request)}&";
            }

            return url;
        }


        public string RequestToken(string authCode)
        {
            var tokenRequestParams = new TokenRequest()
            {
                ClientId = _client.Id,
                ClientSecret = _client.Secret,
                RedirectUri = _client.RedirectUri,
                Code = authCode
            };

            var client = new RestClient(_settings.ProviderUrl);

            var request = new RestRequest(_settings.GetTokenMethod);
        }
    }
}
