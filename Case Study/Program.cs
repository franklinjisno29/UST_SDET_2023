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
}
//casestudy 28/10/23
Customer customer = new Customer
{
    CustomerID = 101,
    Name = "John Doe",
    Email = "john@example.com"
};
PhysicalProduct physProduct = new PhysicalProduct(10, "Iphone", 50, 100, 2.5, "10*10");
PhysicalProduct physProduct1 = new PhysicalProduct(11, "Samsung", 50, 100, 2.5, "10*10");
DigitalProduct digitalProduct = new DigitalProduct(21, "gift card", 25, 500, "www.amazon.com", "pdf");
DigitalProduct digitalProduct1 = new DigitalProduct(22, "welcome card", 25, 500, "www.amazon.com", "pdf");
Order orders = new();
orders.AddProduct(physProduct);
orders.AddProduct(physProduct1);
orders.AddProduct(digitalProduct);
orders.AddProduct(digitalProduct1);
Console.WriteLine("Welcome");
repeat1:
repeat2:
Console.WriteLine("1.Admin 2.customer");
string? choose = Console.ReadLine();
if (choose == "1")
{
    repeat:
    Console.WriteLine("1.Add Product 2.View Product 3.Go Back");
    string? choose1 = Console.ReadLine();
    if(choose1 == "1")
    {
        PhysicalProduct physProduct2 = new PhysicalProduct(12, "Iphone15", 50, 100, 2.5, "10*10");
        orders.AddProduct(physProduct2);
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
    if(choose2 == "1")
    {
        Console.WriteLine("1.Place Order 2.Contact Support");
        string? choose3 = Console.ReadLine();
        if (choose3 == "1")
        {
            Order customerOrder = new Order
            {
                OrderID = 1,
                ProductID = 10,
                Quantity = 1,
                TotalAmount = 25,
                OrderDate = DateTime.Now,
                Status = "Pending"
            };
            orders.GetProduct(10);
            Console.WriteLine("Confirm Order? y/n");
            string? choice = Console.ReadLine();
            if (choice == "y")
            {
                customer.PlaceOrder(customerOrder);
                physProduct.PlaceOrder();
                orders.AddOrder(101, customerOrder);
                orders.GetCustomerOrders(101);
                Console.WriteLine("Proceed for payment? y/n");
                string? choice1 = Console.ReadLine();
                if(choice1 == "y")
                {
                    physProduct.ProcessPayment();
                    customer.ProcessPayment();
                    customer.ViewOrderHistory();
                    physProduct.DeliverProduct();
                    Order.AddReport(customerOrder);
                }
            }
        }
        else if(choose3 =="2")
        {
            customer.ContactSupport();
        }
    }
    if (choose2 == "2")
    {
        Console.WriteLine("1.Place Order 2.Contact Support");
        string? choose4 = Console.ReadLine();
        if (choose4 == "1")
        {
            Order customerOrder = new Order
            {
                OrderID = 1,
                ProductID = 21,
                Quantity = 1,
                TotalAmount = 25,
                OrderDate = DateTime.Now,
                Status = "Pending"
            };
            orders.GetProduct(21);
            Console.WriteLine("Confirm? y/n");
            string? choice = Console.ReadLine();
            if (choice == "y")
            {
                customer.PlaceOrder(customerOrder);
                digitalProduct.PlaceOrder();
                orders.AddOrder(101, customerOrder);
                orders.GetCustomerOrders(101);
                customer.ViewOrderHistory();
                Console.WriteLine("Proceed for payment? y/n");
                string? choice1 = Console.ReadLine();
                if (choice1 == "y")
                {
                    digitalProduct.ProcessPayment();
                    customer.ProcessPayment();
                    customer.ViewOrderHistory();
                    digitalProduct.DeliverProduct();
                    Order.AddReport(customerOrder);
                }
            }
        }
        else if (choose4 == "2")
        {
            customer.ContactSupport();
        }
    }
}
Console.WriteLine("Do you want to continue? (Y/N)");
string? titleread = Console.ReadLine();
if (titleread == "y")
{
    goto repeat2;
}*/

//CaseStudy 4/11/23
public delegate void EnrollementHandler();

class Program
{
    public static void Main(string[] args)
    {
        Student studentrecord = new Student()
        {
            StudentID = 101,
            Name = "tintu",
            Email = "tintu@example.com"
        };
        Course courserecord1 = new Course(123, "BBA", "Bheem");
        Course courserecord2 = new Course(124, "BSC", "Raju");
        Course courserecord3 = new Course(125, "MBA", "Vikram");
        Course courserecord4 = new Course(126, "MSC", "Dhili");
        EnrollementRecord.courses.Add(courserecord1);
        EnrollementRecord.courses.Add(courserecord2);
        EnrollementRecord.courses.Add(courserecord3);
        EnrollementRecord.courses.Add(courserecord4);
    repeat1:
    repeat2:
        Console.WriteLine("1.Admin 2.student");
        string? choose = Console.ReadLine();
        if (choose == "1")
        {
        repeat:
            Console.WriteLine("1.Add Course 2.View Course 3.Remove Course 4.Go Back");
            string? choose1 = Console.ReadLine();
            if (choose1 == "1")
            {
                Course courserecord5 = new Course(127, "BTech", "Rolex");
                EnrollementRecord.courses.Add(courserecord5);
                Console.WriteLine("Courses Added Successfully");
            }
            else if (choose1 == "2")
            {
                Console.WriteLine("Courses");
                foreach (var crse in EnrollementRecord.enrollementRecords)
                {
                    Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}, StudentID:{3}, Student Name: {4}, Email: {5}", crse.Course.CourseCode, crse.Course.Title, crse.Course.Instructor, crse.Student.StudentID, crse.Student.Name, crse.Student.Email);
                }
            }
            else if (choose1 == "3")
            {
                EnrollementRecord.courses.Remove(courserecord4);
                Console.WriteLine("Courses Removed Successfully");
            }
            else if (choose1 == "4")
            {
                goto repeat1;
            }
            goto repeat;
        }
        else if (choose == "2")
        {
            Console.WriteLine("Courses:");
            foreach (var crse in EnrollementRecord.courses)
            {
                Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}", crse.CourseCode, crse.Title, crse.Instructor);
            }
            Console.WriteLine("1.Course Registration 2. Course Withdrawal");
            string? choose2 = Console.ReadLine();
            if (choose2 == "1")
            {
                Console.WriteLine("Course for Registration:");
                int regcourse = Convert.ToInt32(Console.ReadLine());
                Course regstrcourse = EnrollementRecord.courses.FirstOrDefault(c => c.CourseCode == regcourse);
                EnrollementRecord.AddEnroll(studentrecord, regstrcourse);
                Console.WriteLine("Enrolled in course");
                Console.WriteLine("Course Details:");
                EnrollementRecord reg = EnrollementRecord.enrollementRecords.FirstOrDefault(c => c.Course.CourseCode == regcourse);
                Console.WriteLine(reg.Course.CourseCode + "\t" + reg.Course.Title + "\t" + reg.Course.Instructor + "\t" + reg.Student.StudentID + "\t" + reg.Student.Name + "\t" + reg.Student.Email);
            }
            else if (choose2 == "2")
            {
                Console.WriteLine("Course for deletion");
                int regcourse = Convert.ToInt32(Console.ReadLine());
                Course regstrcourse = EnrollementRecord.courses.FirstOrDefault(c => c.CourseCode == regcourse);
                EnrollementRecord.RemoveEnroll(studentrecord, regstrcourse);
                Console.WriteLine("Removed from course");
            }
        }
        Console.WriteLine("Do you want to continue? (Y/N)");
        string? titleread = Console.ReadLine();
        if (titleread == "y")
        {
            goto repeat2;
        }
    }
}

