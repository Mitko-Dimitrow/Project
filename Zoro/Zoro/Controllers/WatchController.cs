using Microsoft.AspNetCore.Mvc;

namespace Zoro.Controllers
{
    public class WatchController : BaseController
    {
        public IActionResult Watch()
        {
            return View();
        }
    }
}
