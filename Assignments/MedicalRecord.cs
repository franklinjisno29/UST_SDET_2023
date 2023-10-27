using Assignments.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord : Patient
    {
        public MedicalRecord(int patientId, string? name, int age, string? diagnosis, int recordId, int treatmentCost) : base(patientId,name, age, diagnosis)
        {
            RecordId = recordId;
            TreatmentCost = treatmentCost;
        }
        public int RecordId { get; set; }
        public int TreatmentCost { get; set; }

        public static List<MedicalRecord> medrec = new List<MedicalRecord>();
        public static void AddRecord(MedicalRecord medrecd)
        {
            if (medrecd.TreatmentCost < 0)
            {
                throw new InvalidMedicalRecordException(MyException.exmlist[1]);
            }
            else if (medrecd.Name == "" || medrecd.Diagnosis == "")
            {
                throw new InvalidPatientDataException(MyException.exmlist[0]);
            }
            else
            {
                medrec.Add(medrecd);
                Console.WriteLine("Medical Record added");
            }
        }

    }
}
