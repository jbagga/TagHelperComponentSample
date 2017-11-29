
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;

namespace TagHelperComponentSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITagHelperComponentManager _tagHelperComponentManager;

        public HomeController(ITagHelperComponentManager tagHelperComponentManager)
        {
            _tagHelperComponentManager = tagHelperComponentManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddComponent()
        {
            _tagHelperComponentManager.Components.Add(new MyTagHelperComponent(2, System.IO.File.ReadAllText("commentForm.html")));
            return View("AddComponent");
        }
    }
}
