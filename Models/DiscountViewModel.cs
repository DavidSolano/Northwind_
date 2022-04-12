using System.Collections.Generic;
using Northwind_.Models;

namespace Northwind_.Models
{
    public class DiscountViewModel
    {
        public Product product { get; set; }
        
        public IEnumerable<Discount> _discounts { get; set; }
    }
}