using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Order
    {
        public BookType[] books = new BookType[10];
        public string? Date { get; set; }
        public int TotalCost { get; set; }
        //public void OrderBook()
        //{

        //}
        public int CalculateTotal()
        {
            if (books != null)
            {
                foreach (var book in books)
                {
                    TotalCost += book.Price;
                }
            }
            return TotalCost;
        }
        //public void PlaceOrder()
        //{


        //}
        //public string? SearchBook(string? searchword)
        //{
        //}
    }
}
