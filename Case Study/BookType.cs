using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class BookType :Book
    {
        public BookType(string? title, string? author, string? iSBN, int price, bool availability,string? type) : base (title,author,iSBN,price,availability)
        {
            Type = type;
        }

        public string? Type { get; set; }
        public void AddBook(string? title, string? author, string? isbn, int price, bool availability, string? booktype)
        {
            Title = title; Author = author; ISBN = isbn; Price = price; Availability = availability; Type = booktype;
        }
        public void DisplayBookDetails()
        {
            Console.WriteLine("Title: {0} \nAuthor: {1}\nISBN:{2}\nPrice:{3}\nAvailability:{4}\nType:{5}", Title, Author, ISBN, Price, Availability, Type);
        }
    }
}
