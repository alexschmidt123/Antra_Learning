using ConsoleApp4.DataModel;
using ConsoleApp4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Presentation
{
    public class ManageEmployee
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public void Run()
        {
            List<Employee> empCollection = employeeRepository.Search(emp => emp.Department == "IT");
            foreach (var item in empCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.FullName + "\t" + item.City + "\t" + item.Department + "\t" + item.Salary);
            }
        }
    }
}
