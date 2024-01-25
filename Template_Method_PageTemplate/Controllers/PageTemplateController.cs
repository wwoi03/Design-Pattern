using Microsoft.AspNetCore.Mvc;

namespace Template_Method_PageTemplate.Controllers
{
    public abstract class PageTemplateController : Controller
    {
        public IActionResult Header()
        {
            return PartialView();
        }

        public IActionResult Footer()
        {
            return PartialView();
        }
    }
}
