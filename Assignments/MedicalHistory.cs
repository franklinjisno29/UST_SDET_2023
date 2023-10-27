using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public MedicalHistory(int patientId, int recordId, string? description, string? date)
        {
            PatientId = patientId;
            RecordId = recordId;
            Description = description;
            Date = date;
        }

        public int PatientId { get; set; }
        public int RecordId { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }

        public static List<MedicalHistory> mh = new List<MedicalHistory>();
        public static void AddMedicalHistory(MedicalHistory medhis)
        {
            mh.Add(medhis);
            Console.WriteLine("Medical History added");
        }
        public static  void CreateFiles()
        {
            FileStream fs = new FileStream("D:\\UST_SDET_2023\\Assignments\\Files\\medicalhistorydata.txt", FileMode.Create, FileAccess.Write);
        }

        public static void AddMHfile(MedicalHistory medhis)
        {
            FileInfo fi = new FileInfo("D:\\UST_SDET_2023\\Assignments\\Files\\medicalhistorydata.txt");
            if (!fi.Exists)
                CreateFiles();
            else
            {
                FileStream fs = new FileStream("D:\\UST_SDET_2023\\Assignments\\Files\\medicalhistorydata.txt", FileMode.Append, FileAccess.Write);
                mh.Add(medhis);
                Console.WriteLine("Medical History added");
                StreamWriter stw = new StreamWriter(fs);
                stw.Write(medhis.PatientId + "\t");
                stw.Write(medhis.RecordId + "\t");
                stw.Write(medhis.Description + "\t");
                stw.Write(medhis.Date + "\t");
                stw.WriteLine(" ");
                stw.Flush();
                stw.Close();
                fs.Close();
            }
        }
        public static void ViewMHData()
        {
            FileStream fs = new FileStream("D:\\UST_SDET_2023\\Assignments\\Files\\medicalhistorydata.txt", FileMode.Open, FileAccess.Read);
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
