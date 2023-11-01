using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TouristDestination
    {
        public TouristDestination(string? name, string? country, double rating, int pricePerNight)
        {
            Name = name;
            Country = country;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public double Rating { get; set; }
        public int PricePerNight { get; set; }
        public static List<TouristDestination> tourismlist = new List<TouristDestination>();
        public static void Filteringspot()
        {
            Console.WriteLine("Places with Rating 5");
            List<TouristDestination> tour = tourismlist.FindAll(s => s.Rating >= 5.0);
            foreach (var r in tour)
            {
                Console.WriteLine(r.Name + "\t" + r.Country + "\t" + r.Rating + "\t"+ r.PricePerNight);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Places ordered by price per night");
            IEnumerable<TouristDestination> tour1 = tourismlist.OrderBy(s => s.PricePerNight);
            foreach (var r in tour1)
            {
                Console.WriteLine(r.Name + "\t" + r.Country + "\t" + r.Rating + "\t" + r.PricePerNight);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Filtering by Location");
            List<TouristDestination> tour2 = tourismlist.FindAll(s => s.Country == "India");
            foreach (var r in tour2)
            {
                Console.WriteLine(r.Name + "\t" + r.Country + "\t" + r.Rating + "\t" + r.PricePerNight);
            }
        }


    }
}
