using Microsoft.AspNetCore.Mvc;

namespace MiddleWare.Controllers
{
    //[Route("home")]
    [Route("[controller]")] // For attribute routing - Tokken
    //[Route("")] // Method 1 - Display with root URL
    public class HomeController : Controller
    {
        [Route("")] /* For attribute routing */
        //[Route("home")]
        //[Route("index")]
        [Route("[action]")] // For attribute routing - Tokken
        [Route("~/")]   // Method 2 - Display with root URL
        public IActionResult Index()
        {
            //return View("~/Views/Home/Index.cshtml"); // Provding complete path of the view is compulsory if there's no controller name in the method name. [Attribute Routing]
            return View(); // It will look for the view in Views/Home/Index.cshtml by default.
        }

        //[Route("details/{id?}")] /* For attribute routing */
        [Route("[action]/{id?}")] // For attribute routing - Tokken
        public int Details(int id)
        {
            return id;
        }
    }
}
