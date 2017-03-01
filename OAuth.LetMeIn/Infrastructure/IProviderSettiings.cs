namespace OAuth.LetMeIn.Infrastructure
{
    public interface IProviderSettiings
    {
        string ProviderUrl { get; }
        string GetCodeMethod { get; }
        string GetTokenMethod { get; }
    }

    internal class VkontakteOauthSettings : IProviderSettiings
    {
        public string ProviderUrl => "https://oauth.vk.com";
        public string GetCodeMethod => "authorize";
        public string GetTokenMethod => "access_token";
    }

}