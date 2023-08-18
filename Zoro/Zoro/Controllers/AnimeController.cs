using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Zoro.Data;

namespace Zoro.Controllers
{
	public class AnimeController : BaseController
	{
		private readonly ZoroDbContext zoroDb;

		public AnimeController(ZoroDbContext zoroDb)
		{
			this.zoroDb = zoroDb;
		}
		public IActionResult Index()
		{
			

			HttpClient client = new HttpClient();

			client.BaseAddress = new Uri("https://api.consumet.org/");
			client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

			HttpResponseMessage response = client.GetAsync("anime/gogoanime/info/" + "one-piece").Result;



			if (response.IsSuccessStatusCode)
			{

				return Ok(response.Content.ReadAsStringAsync().Result);

				//return Ok (responses.ForEach(r=>r.Content.ReadAsHttpResponseMessageAsync()));

			}
			else
			{
				return BadRequest("something went wrong");
			}

		}
	}
}
