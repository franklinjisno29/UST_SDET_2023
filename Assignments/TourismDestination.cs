using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public double Rating { get; set; }
        public static List<TourismDestination> tourismlist = new List<TourismDestination>();

        public static void SortCountry()
        {
            IEnumerable<TourismDestination> tour = tourismlist.OrderByDescending(s => s.Rating);
            foreach (var r in tour)
            {
                Console.WriteLine(r.Name + "\t" + r.Country + "\t" + r.Rating);
            }
        }
    }
}
