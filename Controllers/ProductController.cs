using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind_.Models;
using Northwind_.Models;

namespace Northwind_.Controllers
{
    public class ProductController : Controller
    {
        private NorthwindContext _northwindContext;
        public ProductController(NorthwindContext db) => _northwindContext = db;

        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(b => b.CategoryName));

        public IActionResult Products(int id) => View(new ProductViewModel
        {
            category = _northwindContext.Categories.FirstOrDefault(c => c.CategoryId == id),
            _products = _northwindContext.Products.Where(p => p.CategoryId == id).ToList()
        });



        public IActionResult Discounts() => View(_northwindContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now));

    }
}