using System;
using Microsoft.AspNetCore.Mvc;
using Northwind_.Models;
using System.Linq;
using Northwind_.Models;

namespace Northwind_.Controllers
{
    public class HomeController : Controller
    {
        // this controller depends on the NorthwindRepository
        private NorthwindContext _northwindContext;
        public HomeController(NorthwindContext db) => _northwindContext = db;

        public ActionResult Index() => View(_northwindContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3));

    }
}