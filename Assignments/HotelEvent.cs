using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class HotelEvent
    {
        public string? EventName { get; set; }
        public string? EventDate { get; set; }
        public string? Location { get; set; }
        public int Capacity { get; set; }

        public static List<HotelEvent>He = new List<HotelEvent>();

        public HotelEvent(string? eventName, string? eventDate, string? location, int capacity)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
            Capacity = capacity;
        }

        public static void AddEvent(HotelEvent hotelevent)
        {
            He.Add(hotelevent);
            Console.WriteLine("AddedEvent");
        }
        public static void RegisterEvent()
        {
            foreach(var hotel in He)
            {
                if(DateOnly.Parse(hotel.EventDate).ToString() == DateTime.Today.ToShortDateString())
                {
                    Console.WriteLine("Event is today");
                }
            }
        }
        public static void Statusreg()
        {
            foreach (var hotel in He)
            {
                if (DateOnly.Parse(hotel.EventDate).ToString() != DateTime.Today.ToShortDateString())
                {
                    Console.WriteLine("Event date is: {0}",hotel.EventDate);
                }
            }
        }
    }
}
