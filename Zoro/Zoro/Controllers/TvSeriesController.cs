using Microsoft.AspNetCore.Mvc;

namespace Zoro.Controllers
{
    public class TvSeriesController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
