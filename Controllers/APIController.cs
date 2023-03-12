using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Destiny2ManagerMVC.Models;
using System.Collections.Specialized;
using System.Web;
using System.Text;
using Pathoschild.Http.Client;
using Destiny2ManagerMVC.Constants;

namespace Destiny2ManagerMVC.Controllers
{
    public class APIController : Controller
    {
        
        private readonly string apikey = "cbd862bffe084ca896f9ee6371a6bbe3";
        private readonly string clientSecret = "";
        public async Task<IActionResult> DestinyInfo()
        {
            if (BungieConstants.Auth != null)
            {
                FluentClient client = new FluentClient();
                IResponse ResponseData = await client.GetAsync("https://www.bungie.net/Platform/User/GetCurrentBungieNetUser/")
                    .WithOptions(ignoreHttpErrors: true)
                    .WithHeader("x-api-key", apikey)
                    .WithBearerAuthentication(BungieConstants.Auth.access_token);
                string x =  await ResponseData.AsString();
                CharacterDataAPIModel ResponseDataModel = await ResponseData.As<CharacterDataAPIModel>();
                var ll = ResponseDataModel.Response.character.data.light;
                ViewData["ll"] = ll;
            }
				return View();
			//    #region API Links
			//    string CharInfo = "https://www.bungie.net/Platform/Destiny2/5/Profile/4611686018495570819/Character/2305843009776964460/?components=200";
			//    string GjallarhornD1 = "https://www.bungie.net/platform/Destiny/Manifest/InventoryItem/1274330687/?components=300";
			//    string SanitizedPlatformUN = "https://www.bungie.net/Platform/User/GetSanitizedPlatformDisplayNames/4611686018495570819/";
			//    #endregion
			//    #region API Request / Deserialization

			//    HttpClient client = new HttpClient();
			//    client.DefaultRequestHeaders.Add("x-api-key", apikey);
			//    HttpResponseMessage responseRoute = await client.GetAsync(CharInfo);
			//    responseRoute.EnsureSuccessStatusCode();
			//    var responseRouteBody = await responseRoute.Content.ReadAsStringAsync();
			//    var jsonDeserialize = JsonConvert.DeserializeObject<CharacterDataAPIModel>(responseRouteBody);
			//    var playTime = "";
			//    int lightlevel = 0;
			//    string lastplayedDT = "";
			//    var emblemPath = "";
			//    var steamUser = "";
			//    #endregion
			//    #region API Info Registration
			//    if (jsonDeserialize != null)
			//    {
			//        emblemPath = jsonDeserialize.Response.character.data.emblemPath;
			//        playTime = jsonDeserialize.Response.character.data.minutesPlayedTotal;
			//        lightlevel = jsonDeserialize.Response.character.data.light;
			//        var lastplayed = jsonDeserialize.Response.character.data.dateLastPlayed;
			//        lastplayedDT = Convert.ToDateTime(lastplayed).ToString("dd/MM/yyyy");
			//        steamUser = jsonDeserialize.Response.SteamId;
			//    }
			//    #endregion


			//    var pt = Convert.ToInt32(playTime) / 60;
			//    ViewData["totalplayed"] = pt.ToString();
			//    ViewData["lightlevel"] = lightlevel;
			//    ViewData["lastplayed"] = lastplayedDT;
			//    ViewData["emblempath"] = $"https://www.bungie.net/{emblemPath}";
			//    ViewData["steamuser"] = steamUser;

		}
		public async Task<IActionResult> Callback(string code)
        {
            FluentClient client = new FluentClient();
            IResponse ResponseData = await client.PostAsync("https://www.bungie.net/platform/app/oauth/token/")
                .WithOptions(ignoreHttpErrors: true)
                .WithBasicAuthentication("43209", "hQBeeLZg8JhVulMSYe4RIDrHdTd.kvfC772.sD.LjYw")
                .WithBody(x => x.FormUrlEncoded(new BungieOAuthTokenRequestModel
                {
                    grant_type = "authorization_code",
                    code = code
                }));
            BungieOAuthTokenResponseModel ResponseDataModel = await ResponseData.As<BungieOAuthTokenResponseModel>();
            BungieConstants.Auth = ResponseDataModel;

            return RedirectToAction("DestinyInfo");

        }

        public async Task<IActionResult> Index()
        {
            #region API Links
            string CharInfo = "https://www.bungie.net/Platform/Destiny2/5/Profile/4611686018495570819/Character/2305843009776964460/?components=200";
            string GjallarhornD1 = "https://www.bungie.net/platform/Destiny/Manifest/InventoryItem/1274330687/?components=300";
            string SanitizedPlatformUN = "https://www.bungie.net/Platform/User/GetSanitizedPlatformDisplayNames/4611686018495570819/";
            #endregion
            #region API Request / Deserialization
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", apikey);
            HttpResponseMessage responseRoute = await client.GetAsync(CharInfo);
            responseRoute.EnsureSuccessStatusCode();
            var responseRouteBody = await responseRoute.Content.ReadAsStringAsync();
            var jsonDeserialize = JsonConvert.DeserializeObject<CharacterDataAPIModel>(responseRouteBody);
            var playTime = "";
            int lightlevel = 0;
            string lastplayedDT = "";
            var emblemPath = "";
            var steamUser = "";
            #endregion
            #region API Info Registration
            if (jsonDeserialize != null)
            {
                emblemPath = jsonDeserialize.Response.character.data.emblemPath;
                playTime = jsonDeserialize.Response.character.data.minutesPlayedTotal;
                lightlevel = jsonDeserialize.Response.character.data.light;
                var lastplayed = jsonDeserialize.Response.character.data.dateLastPlayed;
                lastplayedDT = Convert.ToDateTime(lastplayed).ToString("dd/MM/yyyy");
                steamUser = jsonDeserialize.Response.SteamId;
            }
            ViewData["totalplayed"] = playTime;
            ViewData["lightlevel"] = lightlevel;
            ViewData["lastplayed"] = lastplayedDT;
            ViewData["emblempath"] = $"https://www.bungie.net/{emblemPath}";
            ViewData["steamuser"] = steamUser;
            #endregion
            return View();
        }


    }
}
