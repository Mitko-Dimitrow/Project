using FashionStoreDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
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
        public async Task<IActionResult> GetInfo(string title)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.consumet.org/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var anime = StringSlugify.Slugify(title);

            HttpResponseMessage response = client.GetAsync("anime/gogoanime/info/" +anime).Result;



            if (response.IsSuccessStatusCode)
            {

                var animeRes = response.Content.ReadAsStringAsync().Result;
                //return Ok (responses.ForEach(r=>r.Content.ReadAsHttpResponseMessageAsync()));
                var animeInfo = JsonConvert.DeserializeObject<GogoAnimeInnfo>(animeRes);
                var myAnime = JsonConvert.DeserializeObject<AnimeInfo>(animeRes);
                var myAnimeDetails = JsonConvert.DeserializeObject<AnimeDetails>(animeRes);

                await zoroDb.AnimeDetails.AddAsync(myAnimeDetails);
                await zoroDb.GogoAnimeInnfo.AddAsync(animeInfo);
                if(myAnime.AnimeDetails==null)
                {
                    myAnime.AnimeDetailsId = myAnimeDetails.DetailsId;
                }
                await zoroDb.AnimeInfo.AddAsync(myAnime);

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
