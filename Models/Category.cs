using System.Collections.Generic;
using Northwind_.Models;

namespace Northwind_.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}