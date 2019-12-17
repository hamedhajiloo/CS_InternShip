using System;
using System.Collections.Generic;
using System.Text;

namespace P9
{
    class Student
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double AverageGrade { get; set; }
    }
    delegate bool IsValid(Student student);
}
