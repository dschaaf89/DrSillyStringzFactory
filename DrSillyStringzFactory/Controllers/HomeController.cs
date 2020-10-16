using Microsoft.AspNetCore.Mvc;
namespace DrSillyStringzFactory.Controllers
{
   public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        { 
            return View();
        } 
    }
}