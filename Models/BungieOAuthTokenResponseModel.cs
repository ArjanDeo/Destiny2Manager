namespace Destiny2ManagerMVC.Models
{
    public class BungieOAuthTokenResponseModel
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
        public int refresh_expires_in { get; set; }
        public string membership_id { get; set; }
        public string error { get; set; }
        public string error_description { get; set; }
    }
}
