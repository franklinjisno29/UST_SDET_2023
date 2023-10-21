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

//21/10/23
//interface
//IDoctor doc = new Doctor();
//doc.ADDNewDoctor();
////doc.DisplayDoctor();
//doc.ModifyDoctor();
////doc.DisplayDoctor();*/

Doctor doc = new Doctor();
doc.ADDNewDoctor(122,"dholu");
doc.DisplayDoctor();
doc.ModifyDoctor(123, "bholu");
doc.DisplayDoctor();
doc.BookApp(231, "raju");
doc.DelApp("raju");
doc.Add(2, 3);
