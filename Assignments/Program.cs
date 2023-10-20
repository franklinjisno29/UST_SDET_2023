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
dp.DisplayFileFormat();*/

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



