using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public Patient(int patientId, string? name, int age, string? diagnosis)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            Diagnosis = diagnosis;
        }

        public int PatientId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Diagnosis { get; set; }
        List<Patient>pats = new List<Patient>();
        public void AddPatient(Patient patient)
        {
            if((patient.Age < 0 || patient.Age > 120))
            {
                throw new ArgumentException("age should be between 0 and 120");
            }
            else if(patient.Name == "" || patient.Diagnosis == "")
            {
                throw new ArgumentException("patient name and diagnosis should not be null");

            }
            else
            {
                pats.Add(patient);
                Console.WriteLine("Patient added");
            }
            
        }
        public void CreateFile()
        {
           FileStream fs = new FileStream("D:\\UST_SDET_2023\\Assignments\\Files\\patientdata.txt", FileMode.Create, FileAccess.Write);
        }

        public void AddPatientfile(Patient patient)
        {
        FileInfo fi = new FileInfo("D:\\UST_SDET_2023\\Assignments\\Files\\patientdata.txt");
        if (!fi.Exists)
            CreateFile();
            else
            {
                FileStream fs = new FileStream("D:\\UST_SDET_2023\\Assignments\\Files\\patientdata.txt", FileMode.Append, FileAccess.Write);
                pats.Add(patient);
                Console.WriteLine("Patient added");
                StreamWriter stw = new StreamWriter(fs);
                stw.Write(patient.PatientId + "\t");
                stw.Write(patient.Name + "\t");
                stw.Write(patient.Age + "\t");
                stw.Write(patient.Diagnosis + "\t");
                stw.WriteLine(" ");
                stw.Flush();
                stw.Close();
                fs.Close();
            }   
        }
        public static void ViewPatientData()
        {
            FileStream fs = new FileStream("D:\\UST_SDET_2023\\Assignments\\Files\\patientdata.txt", FileMode.Open, FileAccess.Read);
            StreamReader stream = new StreamReader(fs);
            stream.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = stream.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = stream.ReadLine();
            }
            stream.Close();
            fs.Close();
        }
    }
}
