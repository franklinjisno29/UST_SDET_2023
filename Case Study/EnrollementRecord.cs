using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class EnrollementRecord
    {
        public Student Student { get; set; }
        public Course Course { get; set; }

        public static List<Student> students = new List<Student>();
        public static List<Course> courses = new List<Course>();
        public static List<EnrollementRecord> enrollementRecords = new List<EnrollementRecord>();

        public EnrollementRecord(Student student, Course course)
        {
            Student = student;
            Course = course;
        }
        public static void AddEnroll(Student student, Course course)
        {
            EnrollementRecord enroll = new EnrollementRecord(student, course);
            int count = 10;
            if (count <= 10)
            {
                EnrollementRecord stud = enrollementRecords.FirstOrDefault(s => s.Student.Name == student.Name);
                if (stud==null)
                {
                    enrollementRecords.Add(enroll);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                throw new NotImplementedException();

            }
        }
        public static void RemoveEnroll(Student student, Course course)
        {
            EnrollementRecord enroll = new EnrollementRecord(student, course);
            EnrollementRecord stud = enrollementRecords.FirstOrDefault(s => s.Student.StudentID == student.StudentID);
            if (stud != null)
            {
                enrollementRecords.Remove(enroll);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
