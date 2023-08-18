using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Zoro.Data;
using Zoro.Data.Model;

namespace Zoro.Controllers
{
    public class AdminController : BaseController
    {
        private readonly ZoroDbContext zoroDb;

        public AdminController(ZoroDbContext zoroDb)
        {
            this.zoroDb = zoroDb;
        }
        public async Task<IActionResult> GetInfo()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.consumet.org/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("anime/gogoanime/info/" +"one-piece").Result;



            if (response.IsSuccessStatusCode)
            {

                var animeRes = response.Content.ReadAsStringAsync().Result;
                //return Ok (responses.ForEach(r=>r.Content.ReadAsHttpResponseMessageAsync()));
                var animeInfo = JsonConvert.DeserializeObject<GogoAnimeInnfo>(animeRes);

                await zoroDb.GogoAnimeInnfo.AddAsync(animeInfo);
                await zoroDb.SaveChangesAsync();

                return View(animeInfo);
            }
            else
            {
                return BadRequest("something went wrong");
            }


        }
        public IActionResult Admin()
        {
            return View();
        }
    }
}
