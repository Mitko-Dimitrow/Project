using FashionStoreDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Zoro.Contracts;
using Zoro.Data;
using Zoro.Models;

namespace Zoro.Controllers
{
    public class WatchController : BaseController
    {
        private readonly IAnimeService animeService;

        public WatchController(IAnimeService animeService)
        {
            this.animeService = animeService;
        }

        public async Task<IActionResult> Watch(string title,int episode)
        {
            var episodes = await animeService.GetAnimeEpisodes(title);

            var test = episodes.Episodes[0].Url;

            return View(episodes);
        }
    }
}
