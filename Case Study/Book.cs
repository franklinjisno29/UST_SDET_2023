using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Book
    {
        public Book(string? title, string? author, string? iSBN, int price, bool availability)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Price = price;
            Availability = availability;
        }

        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public int Price { get; set; }
        public bool Availability { get; set; }
       
    }
}
