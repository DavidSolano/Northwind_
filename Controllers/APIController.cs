using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind_.Models;
using Northwind_.Models;

namespace Northwind_.Controllers
{
    public class APIController : Controller
    {
        // this controller depends on the NorthwindRepository
        private NorthwindContext _northwindContext;
        public APIController(NorthwindContext db) => _northwindContext = db;

        [HttpGet, Route("api/product")]
        // returns all products
        public IEnumerable<Product> Get() => _northwindContext.Products.OrderBy(p => p.ProductName);
    }
}