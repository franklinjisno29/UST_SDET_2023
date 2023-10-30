using Basic_Program;
using Basic_Program.ExceptionMessages;
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
Console.WriteLine("Net Pay: {0}", employee.CalculateSalary());

//array
ArrayEx arrayEx = new();
arrayEx.Onedim();
arrayEx.Twodim();
arrayEx.Ja();

//single inheritence
StudentMarks marks = new ();
marks.RollNo = 1;
marks.StudentName = "raju";
marks.City = "tvm";
marks.Mark1 = 89;
marks.Mark2 = 90;
marks.Mark3 = 78;
marks.DisplayStudentDetails();
Console.WriteLine("Total:" + marks.CalculateTotal());
Console.WriteLine("Average:" + marks.CalculateAverage());

//multilevel inheritance
StudentGrade grade = new();
grade.RollNo = 1;
grade.StudentName = "raju";
grade.City = "tvm";
grade.Mark1 = 89;
grade.Mark2 = 90;
grade.Mark3 = 78;
grade.DisplayStudentDetails();
Console.WriteLine("Total:" + grade.CalculateTotal());
Console.WriteLine("Average:" + grade.CalculateAverage());
Console.WriteLine("Grade:" + grade.CalculateGrade());

//heirarchy inheritence
Console.WriteLine("1. TS \n2. NTS");
switch(Convert.ToInt32(Console.ReadLine()))
{
case 1:
TeachingStaff ts = new();
ts.Staffid = 1;
ts.Name = "raju";
ts.Dept = "CS";
ts.Specializations = "processor";
ts.Sem = 3;
ts.DisplayStaffDetails();
ts.DisplayTSDetails();
break;
case 2:
NonTeachingStaff nts = new();
nts.Staffid = 11;
nts.Name = "reju";
nts.Dept = "Office";
nts.Responsibilities = "excel";
nts.Experience = 3;
nts.DisplayStaffDetails();
nts.DisplayNTSDetails();
break;
}

Console.WriteLine("1. TS \n2. NTS \n3. S");
switch (Convert.ToInt32(Console.ReadLine()))
{
case 1:
TeachingStaff ts = new();
ts.Collegeid = 123;
ts.CollegeName = "CET";
ts.Staffid = 1;
ts.Name = "raju";
ts.Dept = "CS";
ts.Specializations = "processor";
ts.Sem = 3;
ts.DisplayCollegeDetails();
ts.DisplayStaffDetails();
ts.DisplayTSDetails();
break;
case 2:
NonTeachingStaff nts = new();
nts.Collegeid = 123;
nts.CollegeName = "CET";
nts.Staffid = 11;
nts.Name = "reju";
nts.Dept = "Office";
nts.Responsibilities = "excel";
nts.Experience = 3;
nts.DisplayCollegeDetails();
nts.DisplayStaffDetails();
nts.DisplayNTSDetails();
break;
case 3:
StudentDetails s = new();
s.Collegeid = 123;
s.CollegeName = "CET"; 
s.RollNo = 21;
s.StudentName = "reju";
s.City = "tvm";
s.DisplayCollegeDetails();
s.DisplayStudentDetails();
break;
}

//abstract ex
EV ev = new();
ev.Vehiclenum = 9228;
ev.Brand = "Honda";
ev.Model = "A2015";
ev.Disp();
Console.WriteLine(ev.SetTypeForVeh());
PV pv = new();
pv.Vehiclenum = 9228;
pv.Brand = "Honda";
pv.Model = "A2016";
pv.Disp();
Console.WriteLine(pv.SetTypeForVeh());

21/10/23
interface
IDoctor doc = new Doctor();
doc.ADDNewDoctor();
//doc.DisplayDoctor();
doc.ModifyDoctor();
//doc.DisplayDoctor();

Doctor doc = new Doctor();
doc.ADDNewDoctor(122, "dholu");
doc.DisplayDoctor();
doc.ModifyDoctor(123, "bholu");
doc.DisplayDoctor();
doc.BookApp(231, "raju");
doc.DelApp("raju");
doc.Add(2, 3);

BankDetails bd1 = new(123, 12343243, "vv", "inactive");
BankDetails bd2 = new(1234, 8686823, "dd", "inactive");
bd2.WelcomeMessage();
Console.WriteLine("1. custid 2. accno 3. name");
int ch = Convert.ToInt32(Console.ReadLine());

switch(ch)
{
case 1:
Console.WriteLine("custid:");
//bd1.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
bd2.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
break;
case 2:
Console.WriteLine("Acc.no:");
bd2.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
break;
case 3:
Console.WriteLine("Name:");
bd2.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
break;
default: Console.WriteLine("enter 1,2 or 3");
break;
}

NGC nGC = new NGC();
//nGC.ArrayListHandling();
//nGC.StackHandling();
//nGC.QueueHandling();
//nGC.HTHandling();
nGC.SortedListHandling();
Basic_Program.GC gC = new Basic_Program.GC();
//gC.ListHandling();
//gC.StackHandling();
//gC.QueueHandling();
//gC.DictionaryHandling();
gC.SortedListHandling();

//26/10/23
ExcepHandling exp = new(10,0);
ExcepHandling exp1 = new(10, 10);
exp.Divide();
exp1.Divide();

ExcepHandling exp = new(10, 0);
try
{
    exp.Divide();
}
catch (ArithmeticException ex)
{
    //Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
    //Console.WriteLine(ex.Source);
    Console.WriteLine(MyExceptions.exmsglist[0]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(MyExceptions.exmsglist[1]);
}
catch(Exception ex)
{
    Console.WriteLine(MyExceptions.exmsglist[2]);
}
finally { Console.WriteLine("done"); }

ExcepHandling exp = new(99, 102);
try
{
    exp.Numcheck();
}
catch(Num1Exception ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    exp.Numcheck1();
}
catch (Num2Exception ex)
{
    Console.WriteLine(ex.Message);
}

//27/10/23
FileOperations fo = new FileOperations();
fo.CreateFile();
fo.WriteData();
fo.ReadData();
//fo.CopyMoveFile();
fo.DeleteFile();
fo.FileProperties();

//30/10/23
GenEx<int> genEx = new GenEx<int>(10, 20);
Console.WriteLine(genEx.Val1 + " " + genEx.Val2);
GenEx<double> genEx1 = new GenEx<double>(10.9876, 20.1234);
Console.WriteLine(genEx1.Val1 + " " + genEx1.Val2);
GenEx<string> genEx2 = new GenEx<string>("hi", "hello");
Console.WriteLine(genEx2.Val1 + " " + genEx2.Val2);
GenEx<bool> genEx3 = new GenEx<bool>(true, false);
Console.WriteLine(genEx3.Val1 + " " + genEx3.Val2);

GenEx<int> ga = new GenEx<int>(new int[3] {10,20,30});
ga.Disp();

int n1 = 10, n2 = 20;
GenEx<int>.Swap(ref n1, ref n2);
Console.WriteLine("a={0}, b={1}",n1,n2);*/

