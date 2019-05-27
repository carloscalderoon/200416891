using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200416891_ECommerce.Models;

namespace _200416891_ECommerce.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carsList = new List<Car>()
    {
        new Car {Id = 1, Brand = "Tesla", Model = "Model 3", Type ="Electric", Year = 2019},
        new Car {Id = 2, Brand = "Tesla", Model = "Model S", Type ="Electric", Year = 2019},
        new Car {Id = 3, Brand = "Tesla", Model = "Model X", Type ="Electric", Year = 2019}
    };

    // GET: Cars - List of all Cars
    public ActionResult Index()
        {
            // return Content("/Cars - This is a List of Cars");
            return View(carsList);
        }

    //Details
    public ActionResult Details(int? id)
    {
            if (id == null || id > carsList.Count)
            {
                return Content("Invalid Car Id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carsList[ind];
            return View(car);
    }
    }
}