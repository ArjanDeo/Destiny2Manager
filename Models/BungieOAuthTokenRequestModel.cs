namespace Destiny2ManagerMVC.Models
{
    public class BungieOAuthTokenRequestModel
    {
        public string grant_type { get; set; }
        public string code { get; set; }
    }
}
