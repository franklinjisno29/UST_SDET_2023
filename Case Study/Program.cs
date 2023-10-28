//Case Study 1 - 21/10/23
using Case_Study;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

/*BookType[] booktype = new BookType[]
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
}*/
//casestudy 28/10/23
Customer customer = new Customer
{
    CustomerID = 101,
    Name = "John Doe",
    Email = "john@example.com"
};
PhysicalProduct physProduct = new PhysicalProduct(10, "sample physical", 50, 100, 2.5, "10*10");
PhysicalProduct physProduct1 = new PhysicalProduct(11, "sample physical1", 50, 100, 2.5, "10*10");
DigitalProduct digitalProduct = new DigitalProduct(21, "sample digital", 25, 500, "www", "pdf");
DigitalProduct digitalProduct1 = new DigitalProduct(22, "sample digital", 25, 500, "www", "pdf");
Order orders = new();
orders.AddProduct(physProduct);
orders.AddProduct(physProduct1);
orders.AddProduct(digitalProduct);
orders.AddProduct(digitalProduct1);
Console.WriteLine("Welcome");
repeat1:
Console.WriteLine("1.Admin 2.customer");
string? choose = Console.ReadLine();
if (choose == "1")
{
    repeat:
    Console.WriteLine("1.Add Product 2.View Product 3.Exit");
    string? choose1 = Console.ReadLine();
    if(choose1 == "1")
    {
        
        Console.WriteLine("Products Added Successfully");
    }
    else if(choose1 == "2")
    {
        Console.WriteLine("Products");
        foreach (var product in Order.products)
        {
            Console.WriteLine("ID: {0}, Name: {1}, Price: {2}, Stock: {3}", product.Value.ProductId, product.Value.ProductName, product.Value.Price, product.Value.StockQuantity);
        }
    }
    else if(choose1 == "3")
    {
        goto repeat1;
    }
    goto repeat;



}
else if(choose == "2")
{
    Console.WriteLine("Products");
    foreach (var product in Order.products)
    {
        Console.WriteLine("ID: {0}, Name: {1}, Price: {2}, Stock: {3}", product.Value.ProductId, product.Value.ProductName, product.Value.Price, product.Value.StockQuantity);
    }
    Console.WriteLine("1.Physical Product 2.Digital Product");
    string? choose2 = Console.ReadLine();
    if(choose2 == "1" || choose2 == "2")
    {
        Console.WriteLine("1.Place Order 2.Contact Support");
        string? choose3 = Console.ReadLine();
        if (choose3 == "1")
        {
            Order customerOrder = new Order
            {
                OrderID = 1,
                ProductID = 2,
                Quantity = 1,
                TotalAmount = 25,
                OrderDate = DateTime.Now,
                Status = "Pending"
            };
            customer.PlaceOrder(customerOrder);
            Console.WriteLine("Proceed for payment:");
            customer.ProcessPayment();
            customer.ViewOrderHistory();
        }
        else if(choose3 =="2")
        {
            customer.ContactSupport();
        }
    }


}