using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class ProductModel
    {
        public List<Supplier> Suppliers { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public ProductModel()
        {
            // Initialize Suppliers
            Suppliers = new List<Supplier>
        {
            new Supplier { SupplierID = 1, SupplierName = "ACME", Address1 = "Collooney", Address2 = "Sligo" },
            new Supplier { SupplierID = 2, SupplierName = "Swift Electric", Address1 = "Finglas", Address2 = "Dublin" }
        };

            // Initialize Categories
            Categories = new List<Category>
        {
            new Category { CategoryID = 1, Description = "Hardware" },
            new Category { CategoryID = 2, Description = "Electrical Appliances" }
        };

            // Initialize Products
            Products = new List<Product>
        {
            new Product { ProductID = 1, Description = "9 Inch Nails", Quantity = 200, UnitPrice = 0.1M, CategoryID = 1 },
            new Product { ProductID = 2, Description = "9 Inch Bolts", Quantity = 120, UnitPrice = 0.2M, CategoryID = 1 },
            new Product { ProductID = 3, Description = "Chimney Hoover", Quantity = 10, UnitPrice = 100.3M, CategoryID = 2 },
            new Product { ProductID = 4, Description = "Washing Machine", Quantity = 7, UnitPrice = 399.5M, CategoryID = 2 }
        };
        }
    }
}
