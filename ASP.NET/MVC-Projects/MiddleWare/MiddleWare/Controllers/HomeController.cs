using Microsoft.AspNetCore.Mvc;

namespace MiddleWare.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int Details(int id)
        {
            return id;
        }
    }
}
