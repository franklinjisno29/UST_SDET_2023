using Assignments;
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
CallRecord.TotalCalls();*/

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
