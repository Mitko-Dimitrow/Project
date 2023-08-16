using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Zoro.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
