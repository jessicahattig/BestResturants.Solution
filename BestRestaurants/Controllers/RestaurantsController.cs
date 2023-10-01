using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
    public class RestaurantController : Controller
    {
      private readonly RestaurantContext _db;

      public RestaurantController(RestaurantContext db)
      {
        _db = db;
      }
    
      public ActionResult Index()
      {
        List<Restaurant> model = _db.Restaurants.ToList();
        return View(model);
      }

      public ActionResult Create()
        {
          return View();
        }
      
      [HttpPost]
      public ActionResult Details(int id)
      {
        Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId ==id);
        return View(thisRestaurant);
      }
    }
    
}