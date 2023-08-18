using Microsoft.AspNetCore.Mvc;

namespace Zoro.Controllers
{
    public class MostPopularController : BaseController
    {
        public IActionResult MostPopular()
        {
            return View();
        }
    }
}
