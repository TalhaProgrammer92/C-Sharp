using Microsoft.AspNetCore.Mvc;

namespace ActionMethods.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

            /* IActionResult holds/implements:
                - ViewResult
                - PartialViewResult
                - RedirectToActionResult
                - RedirectResult
                - ContentResult
                - JsonResult
                - FileResult
                - StatusCodeResult
                - ObjectResult
                - EmptyResult */
        }

        public string About()
        {
            return "This is the About action method of HomeController.";
        }
    }
}
