using Microsoft.AspNetCore.Mvc;
using Zoro.Contracts;

namespace Zoro.Controllers
{
    public class TvSeriesController : BaseController
    {
        private readonly IAnimeService anime;

        public TvSeriesController(IAnimeService anime)
        {
            this.anime = anime;
        }

        public async Task<IActionResult> TvSeries()
        {
            var model = await anime.GetAllAnime();

            return View(model);
        }
    }
}
