using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Case_Study
{
    internal class PhysicalProduct :Product,IOrderable
    {
        public PhysicalProduct(int productId, string? productName, double price, int stockQuantity,double weight, string? dimensions) :base(productId,productName,price,stockQuantity)
        {
            Weight = weight;
            Dimensions = dimensions;
        }

        public double Weight { get; set; }
        public string? Dimensions { get; set; }

        public void PlaceOrder()
        {
            Console.WriteLine($"Placing order for Physical Product: {ProductName}");
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Processing payment for Physical Product: {ProductName}");
        }

        public void DeliverProduct()
        {
            Console.WriteLine($"Delivering Physical Product: {ProductName}");
            CalculateShippingCosts();
            ProvideTrackingInformation();
        }
        private void CalculateShippingCosts()
        {
            Console.WriteLine($"Calculating shipping costs for Physical Product: {ProductName}");
        }

        private void ProvideTrackingInformation()
        {
            Console.WriteLine($"Providing tracking information for Physical Product: {ProductName}");
        }
    }
}
