﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Course : IEnrollable
    {
        public Course(int courseCode, string? title, string? instructor)
        {
            CourseCode = courseCode;
            Title = title;
            Instructor = instructor;
        }

        public int CourseCode { get; set; }
        public string? Title { get; set; }
        public string? Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public void CourseRegistration( Student student)
        {
            
        }

        public void CourseWithdrawal(int studentid)
        {
            
        }
    }
}
