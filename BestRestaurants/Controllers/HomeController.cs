using Microsoft.AspNetCore.Mvc;

namespace BestRestaurants.Controllers
{
    public class HomeController : Controllers
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      
    }
}