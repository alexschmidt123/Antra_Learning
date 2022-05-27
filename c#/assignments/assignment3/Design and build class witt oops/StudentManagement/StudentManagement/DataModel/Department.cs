using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataModel
{
    public class Department
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Head { get; set; }
        public decimal Budget { get; set; }
        public List<string> Courses { get; set; }
    }
}
