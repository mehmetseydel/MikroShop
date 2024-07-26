using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            //var user = User.Claims;
            //int x; deneme buracta yaptuk!
            return View();
        }
    }
}
