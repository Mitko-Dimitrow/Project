using Microsoft.AspNetCore.Mvc;
using Zoro.Contracts;

namespace Zoro.Controllers
{
    public class MoviesController : BaseController
    {
        private readonly IAnimeService anime;

        public MoviesController(IAnimeService anime)
        {
            this.anime = anime;
        }
        public async Task<IActionResult> Movies()
        {
            var model = await anime.GetAllMoviesAnime();

            return View(model);
        }
    }
}
