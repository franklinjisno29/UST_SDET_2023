using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T>
    {
        public static List<HotelRoom<T>> hr = new();
        public static void BookRoom(int roomno, ref T roomtype)
        {
            HotelRoom<T> hroom = new(roomno, roomtype, true);
            hr.Add(hroom);
            Console.WriteLine("Room Booked, number: {0}, type:{1}",hroom.RoomNumber,hroom.RoomType);
        }
        public static void CancelRoom(int roomno)
        {
            foreach(var i in hr)
            {
                if(i.RoomNumber == roomno)
                {
                    i.IsBooked = false;
                    Console.WriteLine("Room Cancelled");
                    break;
                }    
            }
            
        }
    }
}
