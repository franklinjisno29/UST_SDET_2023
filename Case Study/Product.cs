using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Product
    {
        public Product(int productId, string? productName, double price, int stockQuantity)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
