using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataModel
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Student : Person
    {
        public string[] Courses { get; set; }
        public string[] Grade { get; set; }

        public float GPA { get; set; }
    }

    public class Instructor : Person
    {
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public string Department { get; set; }
        public Boolean IsHead { get; set; }
        public DateTime JoinDate { get; set; }
    }
}

