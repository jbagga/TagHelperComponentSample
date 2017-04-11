using Microsoft.AspNetCore.Mvc;

namespace TagHelperComponentSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
