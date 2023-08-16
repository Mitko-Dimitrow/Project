using Microsoft.AspNetCore.Mvc;

namespace Zoro.Controllers
{
    public class MoviesController : BaseController
    {
        public IActionResult Movies()
        {
            return View();
        }
    }
}
