using System.Collections.Generic;

namespace Northwind_.Models
{
    public class ProductViewModel
    {
        public Category category { get; set; }
        
        public IEnumerable<Product> _products { get; set; }
    }
}