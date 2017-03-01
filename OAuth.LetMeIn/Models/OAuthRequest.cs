using Newtonsoft.Json;
using OAuth.LetMeIn.Infrastructure;

namespace OAuth.LetMeIn.Models
{
    public class OAuthRequest
    {
        //[UrlParameter(ParamName = "client_id")]
        //public string ClientId { get; set; }

        //[UrlParameter(ParamName = "redirect_uri")]
        //public string RedirectUri { get; set; }
    }

    /// <summary>
    /// запрос на получение кода авторизации. передается GET запросом
    /// </summary>
    public class CodeRequest //: OAuthRequest
    {
        [UrlParameter(ParamName = "client_id")]
        public string ClientId { get; set; }

        [UrlParameter(ParamName = "redirect_uri")]
        public string RedirectUri { get; set; }

        [UrlParameter(ParamName = "display")]
        public string Display { get; set; }

        [UrlParameter(ParamName = "scope")]
        public string Scope { get; set; }

        [UrlParameter(ParamName = "response_type")]
        public string ResponseType { get; set; }

        [UrlParameter(ParamName = "v")]
        public string Version { get; set; }

        [UrlParameter(ParamName = "state")]
        public string VerificationCode { get; set; }
    }

    /// <summary>
    /// запрос на получение токена досутпа. передается POST запросом
    /// </summary>
    public class TokenRequest //: OAuthRequest
    {
        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        [JsonProperty(PropertyName = "redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty(PropertyName = "client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
    }

    /// <summary>
    /// ответ на запрос токена
    /// </summary>
    public class TokenResponse 
    {
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "error_description")]
        public string ErrorDescription { get; set; }

        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public string ExpiresIn { get; set; }

        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string UserEmail { get; set; }
    }


}
