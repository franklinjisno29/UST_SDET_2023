using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourPackage
    {
        public int PackageId { get; set; }
        public string? Destination { get; set; }
        public string? Date { get; set; }
        public int Price { get; set; }

        public static List<TourPackage> bookedpackages = new List<TourPackage>();

        public TourPackage(int packageId, string? destination, string? date, int price)
        {
            PackageId = packageId;
            Destination = destination;
            Date = date;
            Price = price;
        }
        public static void BookPackage(TourPackage packageName)
        {
            Thread.Sleep(1000); // simulate the time it takes to register a student
            lock (bookedpackages)
            {
                bookedpackages.Add(packageName);
                Console.WriteLine($"{packageName.Destination} has booked for the {packageName.Date} with price:{packageName.Price}.");
            }
        }
    }
}
