using Basic_Program;
/*
 Console.WriteLine("Enter 2 numbers");
int x, y, z;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
z = x + y;
Console.WriteLine(z);


string? s1, s2, s3;
s1 = Console.ReadLine();
s2 = Console.ReadLine();
s3 = s1 +"  "+ s2;
Console.WriteLine(s3);
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());
Console.WriteLine(s2.Substring(3));
string[] s=s3.Split(' ');
for(int i=0;i<s.Length;i++)
    Console.WriteLine(s[i]);


double x = 5;
switch (x)
{
    case 7.1:
        Console.WriteLine("1");
        break;
    case 7.2:
        Console.WriteLine("2");
        break;
    case 7.3:
        Console.WriteLine("3");
        break;
    default: Console.WriteLine("4");
        break;
}

//driver

Calculation calculation = new Calculation();
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
double res = calculation.Add(x,y);
Console.WriteLine(res);

Electricity electricity = new(12345, 9000, 9312, "raju");
Console.WriteLine(electricity.consumernumber);
Console.WriteLine(electricity.consumername);
Console.WriteLine(electricity.CalculateBill());
Electricity electricity2 = new(12346, 9000, 10000, "reju");
Console.WriteLine(electricity2.consumernumber);
Console.WriteLine(electricity2.consumername);
Console.WriteLine(electricity2.CalculateBill());

Employeee employee = new(111, "raju", "testing", 10000);
Console.WriteLine("Emp ID: {0} \nName: {1} \nDept: {2} \nBasicPay: {3}", employee.Eid, employee.Ename, employee.Department, employee.Basicpay);
Console.WriteLine("Net Pay: {0}", employee.CalculateSalary());*/

ArrayEx arrayEx = new();
arrayEx.Onedim();
arrayEx.Twodim();