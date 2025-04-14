using Microsoft.AspNetCore.Mvc;

namespace MarketSystemProduct.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
