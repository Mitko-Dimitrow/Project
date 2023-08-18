using Microsoft.AspNetCore.Mvc;

namespace Zoro.Controllers
{
    public class TvSeriesController : BaseController
    {
        public IActionResult TvSeries()
        {
            return View();
        }
    }
}
