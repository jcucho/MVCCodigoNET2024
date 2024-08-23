using Microsoft.AspNetCore.Mvc;

namespace MVCCodigoNET2024.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}
