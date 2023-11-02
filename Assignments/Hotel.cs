using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel : TourismDestination
    {
        public Hotel(string? name, string? country, double rating,string? hotelName, int availableRooms) : base(name,country,rating)
        {
            HotelName = hotelName;
            AvailableRooms = availableRooms;
        }

        public string? HotelName { get; set; }
        public int AvailableRooms { get; set; }

        public async Task BookHotel(int reqrooms)
        {
            if(reqrooms <= AvailableRooms)
            {
                await Task.Delay(1000);
                AvailableRooms -= reqrooms;
                Console.WriteLine($"{reqrooms} Booked. Available rooms are: {AvailableRooms}");
            }
            else
            {
                Console.WriteLine("Available rooms are less than reqsted rooms");
            }
        }
    }
}
