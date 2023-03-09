using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Destiny2ManagerMVC.Models;

namespace Destiny2ManagerMVC.Controllers
{
    public class APIController : Controller
    {
        private readonly string apikey = "cbd862bffe084ca896f9ee6371a6bbe3";
        public async Task<IActionResult> Index()
        {
            #region API Links
            string CharInfo = "https://www.bungie.net/Platform/Destiny2/5/Profile/4611686018495570819/Character/2305843009776964460/?components=200";
            string GjallarhornD1 = "https://www.bungie.net/platform/Destiny/Manifest/InventoryItem/1274330687/?components=300";
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
            #endregion
            #region API Info Registration
            if (jsonDeserialize != null)
            {
                emblemPath = jsonDeserialize.Response.character.data.emblemPath;
                playTime = jsonDeserialize.Response.character.data.minutesPlayedTotal;
                lightlevel = jsonDeserialize.Response.character.data.light;
                var lastplayed = jsonDeserialize.Response.character.data.dateLastPlayed;
                lastplayedDT = Convert.ToDateTime(lastplayed).ToString("dd/MM/yyyy");
            }
            ViewData["totalplayed"] = playTime;
            ViewData["lightlevel"] = lightlevel;
            ViewData["lastplayed"] = lastplayedDT;
            ViewData["emblemPath"] = emblemPath;
            #endregion
            return View();
        }

   
    }
}
