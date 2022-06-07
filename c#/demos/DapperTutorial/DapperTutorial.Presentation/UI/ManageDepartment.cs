using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.Presentation.UI
{
    public class ManageDepartment
    {
        DepartmentRepository departmentRepository = new DepartmentRepository();
        private void AddDepartment()
        {
            Department d = new Department();

            Console.WriteLine("Enter Id =>");
            d.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name =>");
            d.DName = Console.ReadLine();
            Console.WriteLine("Enter Location =>");
            d.Loc = Console.ReadLine();

            departmentRepository.Insert(d);

        }

        private void UpdateDepartment()
        {
            Department d = new Department();

            Console.WriteLine("Enter Id =>");
            d.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name =>");
            d.DName = Console.ReadLine();
            Console.WriteLine("Enter Location =>");
            d.Loc = Console.ReadLine();

            departmentRepository.Update(d);

        }

        private void GetDepartmentById()
        {
            Console.WriteLine("Enter Id =>");
            int id = Convert.ToInt32(Console.ReadLine());
            var d = departmentRepository.GetById(id);
            Console.WriteLine(d.Id + "\t" + d.DName + "\t" + d.Loc);
        }

        private void DeleteDepartment() {
            Console.WriteLine("Enter Id =>");
            int id = Convert.ToInt32(Console.ReadLine());
            departmentRepository.DeleteById(id);
        }

        private void GetAllDepartments()
        {
            IEnumerable<Department> departments = departmentRepository.GetAll();
            foreach (var d in departments)
            {
                Console.WriteLine(d.Id + "\t" + d.DName + "\t" + d.Loc);
            }

        }

        public void Run()
        {
            GetDepartmentById();
        }
    }
}
