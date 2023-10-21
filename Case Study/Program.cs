//Case Study 1 - 21/10/23
using Case_Study;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

BookType[] booktype = new BookType[]
{
    new("Balarama", "Bheem", "987", 1000, true, "Comedy"),
    new("Balabhoomi", "Bheems", "879", 900, true, "Serious"),
};
Order order = new Order();
order.books = booktype;
string? titleread;
Console.WriteLine("Books in store:");
foreach(var bk in booktype)
{
    Console.WriteLine(bk.Title);
}
repeat:
Console.WriteLine("1.Add customer 2.Place order 3.Search");
string? choose = Console.ReadLine();
if(choose =="1")
{
    Customer customer = new("Raju", "9876543456", 123);
    customer.DisplayCustomerDetails();
}
else if(choose =="2")
{
    Console.WriteLine("Enter book title for placing order:");
    titleread = Console.ReadLine();

    foreach (var book in booktype)
    {
        if (book.Title == titleread)
        {
            Console.WriteLine("Enter order Date:");
            order.Date = Console.ReadLine();
            book.DisplayBookDetails();
            order.CalculateTotal();
            Console.WriteLine("Total Cost:{0}", order.TotalCost);
            break;
        }
        else { Console.WriteLine("Book Not available"); break; }
    }
}
else if(choose =="3")
{
    Console.WriteLine("Enter title for searching:");
    titleread = Console.ReadLine();
    foreach (var book in booktype)
    {
        if (book.Title == titleread)
        {
            book.DisplayBookDetails();
            break;
        }
        else 
        { 
            Console.WriteLine("Book Not available");
            break;
        }
    }

}
Console.WriteLine("Do you want to continue? (Y/N");
titleread = Console.ReadLine();
if(titleread =="y")
{
    goto repeat;
}



