using Destiny2ManagerMVC.Constants;
using Destiny2ManagerMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pathoschild.Http.Client;

namespace Destiny2ManagerMVC.Controllers
{
	public class DestinyInfoController : Controller
	{
		private readonly string apikey = "cbd862bffe084ca896f9ee6371a6bbe3";
		public async Task<IActionResult> Index()
		{
			if (BungieConstants.Auth != null) {
				FluentClient client = new FluentClient();
				IResponse ResponseData = await client.GetAsync("https://www.bungie.net/Platform/User/GetCurrentBungieNetUser/")
					.WithOptions(ignoreHttpErrors: true)
					.WithBearerAuthentication(BungieConstants.Auth.access_token);
				CharacterDataAPIModel ResponseDataModel = await ResponseData.As<CharacterDataAPIModel>();
				var ll = ResponseDataModel.Response.character.data.light;
				ViewData["ll"] = ll;
			
			}
				return View();
		}
	}
}
