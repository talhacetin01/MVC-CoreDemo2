using Microsoft.AspNetCore.Mvc;

namespace CoreDemo2.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
