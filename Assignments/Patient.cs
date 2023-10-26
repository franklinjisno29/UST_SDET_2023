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
    }
}
