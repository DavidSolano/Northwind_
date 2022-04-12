using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind_.Models
{
    public class Product
    {
        // primary key
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string QuantityPerUnit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }

        public short UnitsOnOrder { get; set; }

        public short ReorderLevel { get; set; }

        public bool Discontinued { get; set; }



        // foreign key
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}