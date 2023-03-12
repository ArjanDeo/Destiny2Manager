using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Destiny2ManagerMVC.Models;
using System.Collections.Specialized;
using System.Web;

namespace Destiny2ManagerMVC.Controllers
{
    public class APIController : Controller
    {
        private readonly string apikey = "cbd862bffe084ca896f9ee6371a6bbe3";
		private readonly string clientSecret = "";
		public async Task<IActionResult> DestinyInfo()
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
            #endregion
            var pt = Convert.ToInt32(playTime) / 60;
			ViewData["totalplayed"] = pt.ToString();
			ViewData["lightlevel"] = lightlevel;
			ViewData["lastplayed"] = lastplayedDT;
			ViewData["emblempath"] = $"https://www.bungie.net/{emblemPath}";
			ViewData["steamuser"] = steamUser;
			return View();
		}
	public async Task<IActionResult> Callback(string code)
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage(HttpMethod.Post, "https://www.bungie.net/Platform/App/OAuth/Token");
			request.Headers.Add("Authorization", "Basic NDMyMDk6aFFCZWVMWmc4SmhWdWxNU1llNFJJRHJIZFRkLmt2ZkM3NzIuc0QuTGpZdw==");
			var collection = new List<KeyValuePair<string, string>>();
			collection.Add(new("grant_type", "authorization_code"));
			collection.Add(new("code", code));
			var content = new FormUrlEncodedContent(collection);
			request.Content = content;
			var response = await client.SendAsync(request);
			response.EnsureSuccessStatusCode();
			return Ok(code);

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
