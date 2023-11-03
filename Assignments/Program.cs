using Assignments;
using Assignments.Exceptions;
using System.Xml.Linq;
//assignment 18/10/2023
/*Student student1 = new("raju", 92, 70, 86);
Console.WriteLine(student1.studentname);
Console.WriteLine("Average:"+ student1.CalculateAverage());

//assignment1 19/10/2023
Product[] product = new Product[3];
product[0] = new Product("Mango", 130, 20);
product[1] = new Product("Apple", 350, 10);
product[2] = new Product("Orange", 80, 90);
product[0].SetPrice(160);
foreach (Product prod in product)
{
prod.DisplayProducts();
prod.ProductValue();

}
//assignment2 19/10/2023

Student[] student = new Student[3];
student[0] = new Student("raju", "A", new int[] { 90, 80, 85 });
student[1] = new Student("reni","B", new int[] { 80, 60, 85 });
student[2] = new Student("resto","A", new int[] { 90, 85, 95 });
foreach(Student s in student)
{
s.DisplayStudents();
s.CalculateAverage();
s.GetMarksSummary();
Console.WriteLine();

}

//assignment1 20/10/23
ElectronicsProduct ep = new("Apple", 150, 20, 6);
ep.DisplayProducts();
ep.DisplayWarrantyPeriod();

//assignment2 20/10/23
DigitalProduct dp = new("Apple", 150, 20, 6, "MP3");
dp.DisplayProducts();
dp.DisplayWarrantyPeriod();
dp.DisplayFileFormat();

//assignment3 20/10/23
Console.WriteLine("1. EP \n2. DP \n3. CP");
switch (Convert.ToInt32(Console.ReadLine()))
{
case 1:
    ElectronicsProduct ep = new("Apple", 150, 20, 6);
    ep.DisplayProducts();
    ep.DisplayWarrantyPeriod();
    break;
case 2:
    DigitalProduct dp = new("Apple", 150, 20, 6, "MP3");
    dp.DisplayProducts();
    dp.DisplayWarrantyPeriod();
    dp.DisplayFileFormat();
    break;
case 3:
    ClothingProduct cp = new("shirt", 750, 20, "small");
    cp.DisplayProducts();
    cp.DisplaySize();
    break;
}
//assignment 23/10/23
Circle c = new Circle();
c.Radius = 4;
c.Draw();
Rectangle r = new Rectangle();
r.Length = 4;
r.Width = 4;
r.Draw();

//assignment1 25/10/23
InsurancePolicy ip = new("jeevanraksha", 123, 25000);
ip.RenewPolicy(26000);
ip.RenewPolicy();

//assignment2
LifeInsurance li = new("jeeavnraksha", 1234, 12000, 45);
li.CalculatePremium();
Console.WriteLine("Life insurance Premium amount: {0}", li.PremiumAmount);
CarInsurance ci = new("vahanraksha", 321, 3000, "petrol");
ci.CalculatePremium();
Console.WriteLine("Car insurance Premium amount: {0}", ci.PremiumAmount);

//assignment1 26/10/23
Customer cust1 = new(123, "raju", "9876567890", 3000);
Customer cust2 = new(243, "reju", "9876568890", 6000);
Customer cust3 = new(236, "rajesh", "9566567890", 1000);
Customer.cust.Add(1,cust1);
Customer.cust.Add(2,cust2);
Customer.cust.Add(3,cust3);
Customer.searchcust("9876567890");
Customer.DisplayCustomers();

//assignment2
CallRecord cr1 = new(123,9876567890, 3000);
CallRecord cr2 = new(243,9876568890, 6000);
CallRecord cr3 = new(236,9876567890, 1000);
CallRecord.callrec.Add(1, cr1);
CallRecord.callrec.Add(2, cr2);
CallRecord.callrec.Add(3, cr3);
CallRecord.SearchRec(9876567890);
CallRecord.TotalCalls();

//assignment3
Patient pat = new(1, "", 20, "fever");
try
{
pat.AddPatient(pat);
}
catch(ArgumentException ex)
{
Console.WriteLine(ex.Message);
}

//27/10/23 assignment1
MedicalRecord med = new(1, "", 20, "fever", 321, 5000);
try
{
MedicalRecord.AddRecord(med);
}
catch(InvalidPatientDataException ex)
{
Console.WriteLine(ex.Message);
}
MedicalRecord med2 = new(1, "patient2", 20, "fever", 321, -5000);
try
{
MedicalRecord.AddRecord(med2);
}
catch (InvalidMedicalRecordException ex)
{
Console.WriteLine(ex.Message);
}
MedicalRecord med1 = new(1, "patient3", 20, "fever", 321, 5000);
try
{
MedicalRecord.AddRecord(med1);
}
catch (InvalidPatientDataException ex)
{
Console.WriteLine(ex.Message);
}
//assignment2
repeat:
Console.WriteLine("1.Add patient 2.View Patient 3.Exit");
string? choose = Console.ReadLine();
if(choose =="1")
{
    Console.WriteLine("enter patientid:");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter patient name:");
    string? name = Console.ReadLine();
    Console.WriteLine("enter age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter diagnosis:");
    string? diagnosis = Console.ReadLine();
    Patient pat = new(id, name, age, diagnosis);
    pat.AddPatientfile(pat);
}
else if (choose == "2")
{
    Patient.ViewPatientData();
}
Console.WriteLine("Do you want to continue? (Y/N");
string? titleread = Console.ReadLine();
if (titleread == "y")
{
    goto repeat;
}
//assignment3
MedicalHistory mh1 = new(1, 10,"fever", "11/12/23");
MedicalHistory mh2 = new(2, 20, "fever2", "12/12/23");
MedicalHistory mh3 = new(2, 30, "fever3", "12/12/23");
MedicalHistory.mh.Add(mh1);
MedicalHistory.mh.Add(mh2);
MedicalHistory.mh.Add(mh3);
repeat:
Console.WriteLine("1.Add Medical History 2.View Medical History 3.Exit");
string? choose = Console.ReadLine();
if (choose == "1")
{
    MedicalHistory.AddMHfile(mh1);
    MedicalHistory.AddMHfile(mh2);
    MedicalHistory.AddMHfile(mh3);
}
else if (choose == "2")
{
    MedicalHistory.ViewMHData();
}
Console.WriteLine("Do you want to continue? (Y/N");
string? titleread = Console.ReadLine();
if (titleread == "y")
{
    goto repeat;
}

//30/10/23 assignment1
var typ1 = "single";
var typ2 = 2;
RoomReservation<string>.BookRoom(123, ref typ1);
RoomReservation<int>.BookRoom(101, ref typ2);
RoomReservation<string>.CancelRoom(123);

//assignment2
var typ1 = "Iphone";
var typ2 = 1010;
var typ3 = "samsung";
Product<string>.AddProduct(1, ref typ1, 100, 2);
Product<int>.AddProduct(2, ref typ2, 50, 3);
Product<string>.UpdateProduct(1, typ3);
Product<string>.DeleteProduct(2);
Product<string>.SearchProduct(1);

//31/10/23 assinment1
public delegate double Emp1(double perfrate);
class Program
{
    public static void Main(string[] args)
    {
        repeat:
        Console.WriteLine("Enter Employee ID:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name:");
        string? b = Console.ReadLine();
        Employee employee = new();
        employee.EmployeeId = a;
        employee.Name = b;
        Console.WriteLine("Bonus Calculation Method:");
        Console.WriteLine("1. Performance Threshold 2. Department Specific Rules");
        string? choose = Console.ReadLine();
        if(choose == "1")
        {
            Emp1 emp1 = Employee.BonusCalculation;
            Console.WriteLine("Enter Performance Threshold:");
            Console.WriteLine(emp1.Invoke(Convert.ToDouble(Console.ReadLine())));
        }
        else if (choose == "2")
        {
            Emp1 emp1 = Employee.CalculateBonus; ;
            Console.WriteLine("Enter Department Spcific Rule Rate:");
            Console.WriteLine(emp1.Invoke(Convert.ToDouble(Console.ReadLine())));
        }
        Console.WriteLine("Do you want to continue? (Y/N");
        string? titleread = Console.ReadLine();
        if (titleread == "y")
        {
            goto repeat;
        }
    }
}
//assignment2
public delegate void Hotele1();

class Program
{
    public static void Main(string[] args)
    {
 
        HotelEvent hotelEvent = new HotelEvent("haloween","31-10-23","kochi",500);
        HotelEvent hotelEvent1 = new HotelEvent("djparty", "30-10-23", "kochi", 400);
        HotelEvent.AddEvent(hotelEvent);
        HotelEvent.AddEvent(hotelEvent1);
        Hotele1 hotelevent2 = HotelEvent.RegisterEvent;
        Hotele1 hotelevent3 = HotelEvent.Statusreg;
        Hotele1 objall = hotelevent2 + hotelevent3;
        objall.Invoke();
    }
}

//1/11/2023 assignment1
TourismDestination.tourismlist.Add(new TourismDestination("Eifel tower", "France", 5.0));
TourismDestination.tourismlist.Add(new TourismDestination("Taj Mahal", "India", 3.0));
TourismDestination.tourismlist.Add(new TourismDestination("Pyramid", "Egypt", 4.0));
TourismDestination.tourismlist.Add(new TourismDestination("Amazon forest", "Brazil", 1.0));
TourismDestination.tourismlist.Add(new TourismDestination("Padmanabhan temple", "India", 2.0));
TourismDestination.SortCountry();

//assignment2
TouristDestination.tourismlist.Add(new TouristDestination("Eifel tower", "France", 5.0,3000));
TouristDestination.tourismlist.Add(new TouristDestination("Taj Mahal", "India", 3.0,5000));
TouristDestination.tourismlist.Add(new TouristDestination("Pyramid", "Egypt", 5.0,4000));
TouristDestination.tourismlist.Add(new TouristDestination("Amazon forest", "Brazil", 1.0,6000));
TouristDestination.tourismlist.Add(new TouristDestination("Padmanabhan temple", "India", 2.0,2000));
TouristDestination.Filteringspot();

//2/11/23assignment1
class Program
{
    static async Task Main()
    {
        Hotel hotel1 = new Hotel("Eifel tower", "France", 5.0, "Taj", 300);
        Hotel hotel2 = new Hotel("Paris", "France", 4.0, "flamingo", 200);

        Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel1.HotelName, hotel1.AvailableRooms);
        Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel2.HotelName, hotel2.AvailableRooms);

        await BookRoom(hotel1, 10);
        await BookRoom(hotel2, 6);

        Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel1.HotelName, hotel1.AvailableRooms);
        Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel2.HotelName, hotel2.AvailableRooms);

    }
    static async Task BookRoom( Hotel hotel, int reqrooms )
    {
        await hotel.BookHotel(reqrooms);
    }
}

//assignment2
List<Thread> packageThreads = new List<Thread>();
TourPackage tourpack1 = new TourPackage(1,"kerala","21/11/23",3000);
TourPackage tourpack2 = new TourPackage(2, "tamilnadu", "2/11/23", 4000);
TourPackage tourpack3 = new TourPackage(3, "karnataka", "11/11/23", 5000);
Thread pack1 = new Thread(() => TourPackage.BookPackage(tourpack1));
Thread pack2 = new Thread(() => TourPackage.BookPackage(tourpack2));
Thread pack3 = new Thread(() => TourPackage.BookPackage(tourpack3));
packageThreads.Add(pack1);
packageThreads.Add(pack2);
packageThreads.Add(pack3);
foreach (Thread t in packageThreads)
{
    t.Start();
}
foreach (Thread t in packageThreads)
{
    t.Join();
}
foreach (var t in TourPackage.bookedpackages)
{
    Console.WriteLine("PackageID: {0},Destination:{1}, Date:{2}, Price: {3}",t.PackageId,t.Destination,t.Date,t.Price);
}

//3/11/23assignment1
//TaskItem taskManager1 = new TaskItem();
CustomLinkedList taskManager = new CustomLinkedList();

taskManager.AddTask(1, "Complete project proposal");
taskManager.AddTask(2, "Buy groceries");
taskManager.AddTask(3, "Read a book");

Console.WriteLine("All Tasks:");
taskManager.DisplayTasks();

taskManager.MarkTaskAsCompleted(2);
Console.WriteLine("\nCompleted Tasks:");
taskManager.DisplayCompletedTasks();

Console.WriteLine("\nPending Tasks:");
taskManager.DisplayPendingTasks();

taskManager.RemoveTask(3);
Console.WriteLine("\nTasks after removing one task:");
taskManager.DisplayTasks();*/

//assignment2
FamilyMember grandparent = new FamilyMember("Grandparent", 70);
FamilyTree familyTree = new FamilyTree(grandparent);

FamilyMember parent1 = new FamilyMember("Parent 1", 45);
FamilyMember parent2 = new FamilyMember("Parent 2", 40);
FamilyMember child1 = new FamilyMember("Child 1", 18);
FamilyMember child2 = new FamilyMember("Child 2", 16);
FamilyMember grandchild1 = new FamilyMember("Grandchild 1", 5);

// Build family tree relationships
grandparent.AddChild(parent1);
grandparent.AddChild(parent2);
parent1.AddChild(child1);
parent1.AddChild(child2);
child1.AddChild(grandchild1);

// Display family tree
Console.WriteLine("Family Tree:");
familyTree.DisplayFamilyTree();