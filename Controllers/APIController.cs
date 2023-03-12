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
        private readonly FluentClient client;
        public APIController()
        {
            client = new FluentClient();
        }

        public async Task<IActionResult> DestinyInfo()
        {
            if (BungieConstants.Auth == null)
            {
                Response.Redirect("https://www.bungie.net/en/OAuth/Authorize/?client_id=43209&response_type=code");
            }
            else if (BungieConstants.Auth != null)
            {
                
                 
                    IResponse UserDataResponse = await client.GetAsync("https://www.bungie.net/Platform/User/GetCurrentBungieNetUser/")
                        .WithOptions(ignoreHttpErrors: true)
                        .WithHeader("x-api-key", apikey)
                        .WithBearerAuthentication(BungieConstants.Auth.access_token);

                    BungieUserModel ResponseDataModel = await UserDataResponse.As<BungieUserModel>();


                    IResponse BungieUserMembershipsResponse = await client
                        .GetAsync($"https://www.bungie.net/Platform/User/GetMembershipsById/{ResponseDataModel.Response.membershipId}/5/")
                        .WithOptions(ignoreHttpErrors: true)
                        .WithHeader("x-api-key", apikey)
                        .WithBearerAuthentication(BungieConstants.Auth.access_token);

                    BungieUserMembershipsModel MembershipData = await BungieUserMembershipsResponse.As<BungieUserMembershipsModel>();
                    DestinyMembership? Membership = MembershipData.Response.destinyMemberships.FirstOrDefault(x => x.membershipType is 3 or 5);

                    if (Membership != null)
                    {
                        IResponse CharactersDataResponse = await client
                            .GetAsync($"https://www.bungie.net/Platform/Destiny2/{Membership.membershipType}/Profile/{Membership.membershipId}/?components=200")
                            .WithOptions(ignoreHttpErrors: true)
                            .WithHeader("x-api-key", apikey)
                            .WithBearerAuthentication(BungieConstants.Auth.access_token);

                        BungieCharacterDataModel CharacterData = await CharactersDataResponse.As<BungieCharacterDataModel>();

                        // 0 = Titan
                        // 1 = Hunter
                        // 2 = Warlock
                        KeyValuePair<long, CharacterData> WarlockData = CharacterData.Response.characters.data.FirstOrDefault(x => x.Value.classType == 2);
				    	KeyValuePair<long, CharacterData> HunterData = CharacterData.Response.characters.data.FirstOrDefault(x => x.Value.classType == 1);
				    	KeyValuePair<long, CharacterData> TitanData = CharacterData.Response.characters.data.FirstOrDefault(x => x.Value.classType == 0);
                   double thoursPlayed = 0.0;
					double hhoursPlayed = 0.0;
					double whoursPlayed = 0.0;
                    
					if (TitanData.Value != null)
                    {
                            string titanemblembkg = $"https://www.bungie.net{TitanData.Value.emblemBackgroundPath}";
                            string titanemblem = $"https://www.bungie.net{TitanData.Value.emblemPath}";
						    ViewData["titanemblembkg"] = titanemblembkg;
                            ViewData["titanemblem"] = titanemblem;
						    int minutesPlayed = int.Parse(TitanData.Value.minutesPlayedTotal);
						     thoursPlayed = minutesPlayed / 60.0;
						    ViewData["tpt"] = thoursPlayed.ToString("F2");
					    	ViewData["tll"] = TitanData.Value.light;
					}
                    if (HunterData.Value != null)
                    {
						    string hunteremblembkg = $"https://www.bungie.net{HunterData.Value.emblemBackgroundPath}";
						    string hunteremblem = $"https://www.bungie.net{HunterData.Value.emblemPath}";
						    ViewData["hunteremblembkg"] = hunteremblembkg;
                            ViewData["hunteremblem"] = hunteremblem;
						    int minutesPlayed = int.Parse(HunterData.Value.minutesPlayedTotal);
						     hhoursPlayed = minutesPlayed / 60.0;
						    ViewData["hpt"] = hhoursPlayed.ToString("F2");
						    ViewData["hll"] = HunterData.Value.light;

					}
					if (WarlockData.Value != null)
                    {
                        string warlockemblembkg = $"https://www.bungie.net{WarlockData.Value.emblemBackgroundPath}";
                        string warlockemblem = $"https://www.bungie.net{WarlockData.Value.emblemPath}";
						ViewData["wll"] = WarlockData.Value.light;
						int minutesPlayed = int.Parse(WarlockData.Value.minutesPlayedTotal);
						 whoursPlayed = minutesPlayed / 60.0;
						ViewData["wlpt"] = whoursPlayed.ToString("F2");
						ViewData["lastplayed"] = WarlockData.Value.dateLastPlayed.Date.ToString("dd/MM/yyyy");
						ViewData["warlockemblembkg"] = warlockemblembkg;
						ViewData["warlockemblem"] = warlockemblem;


					}
					double totalHoursPlayed = whoursPlayed + thoursPlayed + hhoursPlayed;
					ViewData["pt"] = totalHoursPlayed.ToString("F2");


				}
			}
            return View();
          
            //        emblemPath = jsonDeserialize.Response.character.data.emblemPath;
            //        playTime = jsonDeserialize.Response.character.data.minutesPlayedTotal;
            //        lightlevel = jsonDeserialize.Response.character.data.light;
            //        var lastplayed = jsonDeserialize.Response.character.data.dateLastPlayed;
            //        lastplayedDT = Convert.ToDateTime(lastplayed).ToString("dd/MM/yyyy");
            //        steamUser = jsonDeserialize.Response.SteamId;

        }
        public async Task<IActionResult> Callback(string code)
        {
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

        public  IActionResult Index()
        {
            return View();
        }


    }
}
