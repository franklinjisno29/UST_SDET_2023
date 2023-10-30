using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Case_Study
{
    internal class DigitalProduct : Product,IOrderable
    {
        public DigitalProduct(int productId, string? productName, double price, int stockQuantity,string? downloadLink, string? fileFormat) : base(productId,productName,price,stockQuantity)
        {
            DownloadLink = downloadLink;
            FileFormat = fileFormat;
        }

        public string? DownloadLink { get; set; }
        public string? FileFormat { get; set; }

        public void PlaceOrder()
        {
            Console.WriteLine($"Placing order for Digital Product: {ProductName}");
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Processing payment for Digital Product: {ProductName}");
        }

        public void DeliverProduct()
        {
            Console.WriteLine($"Delivering Digital Product: {ProductName}");
            ProvideDownloadLink();
        }
        private void ProvideDownloadLink()
        {
            // Logic to provide the download link to the customer
            Console.WriteLine($"Providing download link for Digital Product: {ProductName}");
            Console.WriteLine($"Download Link: {DownloadLink}");
        }
    }
}
