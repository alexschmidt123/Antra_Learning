﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ManageEmployee
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        private Employee Demo(Employee employee)
        {
            return employee;
        }
        private void SelectDemo()
        {
            //SELECT * FROM Employees
            //query syntax
            //var result = from employee in employeeRepository.GetEmployees()
            //             select employee;


            //method syntax
            //var result = employeeRepository.GetEmployees().Select(emp => emp);
            //var result = employeeRepository.GetEmployees().Select(Demo);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id + "\t" + item.FullName + "\t" + item.Salary + "\t" + item.Department + "\t" + item.Age);
            //}

            //select single property
            //query syntax
            //var result = from employee in employeeRepository.GetEmployees()
            //             select employee.FullName;

            //method syntax
            //var result = employeeRepository.GetEmployees().Select(emp => emp.FullName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //multiple properties
            //query syntax
            //var reuslt = from employee in employeeRepository.GetEmployees()
            //             select new
            //             {
            //                 Id = employee.Id,
            //                 FullName = employee.FullName,
            //                 Department = employee.Department
            //             };

            //method syntax
            //var reuslt = employeeRepository.GetEmployees().Select(emp => new
            //{
            //    Id = emp.Id,
            //    FullName = emp.FullName,
            //    Department = emp.Department
            //});

            //foreach (var item in reuslt)
            //{
            //    Console.WriteLine(item.Id + "\t" + item.FullName + "\t" + item.Department);
            //}

            //fetch distinct value
            //var result = (from employee in employeeRepository.GetEmployees()
            //              select employee.Department).Distinct();

            //var result = employeeRepository.GetEmployees().Select(emp => emp.Department).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = employeeRepository.GetEmployees().Select(x => new
            //{
            //    Id = x.Id,
            //    FullName = x.FullName,
            //    Department = x.Department
            //}).FirstOrDefault(x => x.Department == "IT") ?? new {Id = -1, FullName = "N/A", Department = "N/A"};
            //Console.WriteLine(result.Id + "\t" + result.FullName + "\t" + result.Department);

            var result = employeeRepository.GetEmployees().Select(x => new
            {
                Id = x.Id,
                FullName = x.FullName,
                Department = x.Department
            }).SingleOrDefault(x => x.Department == "sdgsdg");
            //Console.WriteLine(result.Id + "\t" + result.FullName + "\t" + result.Department);


        }

        private void OrderbyDemo()
        {
            //query syntax
            //var result = from employee in employeeRepository.GetEmployees()
            //             orderby employee.Salary descending, employee.FullName descending
            //             select new
            //             {
            //                 Id = employee.Id,
            //                 FullName = employee.FullName,
            //                 Salary = employee.Salary
            //             };

            //method syntax
            var result = employeeRepository.GetEmployees().OrderByDescending(x => x.Salary).ThenByDescending(x => x.FullName).Select(x => new { Id = x.Id, FullName = x.FullName, Salary = x.Salary });

            foreach (var item in result)
            {
                Console.WriteLine(item.Id + "\t" + item.FullName + "\t" + item.Salary);
            }

        }

        private void WhereDemo()
        {
            //query syntax
            //var result = from employee in employeeRepository.GetEmployees()
            //             where employee.Salary > 7000 
            //             select new
            //             {
            //                 Id = employee.Id,
            //                 FullName = employee.FullName,
            //                 Salary = employee.Salary
            //             };


            //method syntax
            var result = employeeRepository.GetEmployees().Where(x => x.Salary > 7000 && x.Department == "Sales").Select(x => new { Id = x.Id, FullName = x.FullName, Salary = x.Salary });

            foreach (var item in result)
            {
                Console.WriteLine(item.Id + "\t" + item.FullName + "\t" + item.Salary);
            }
        }

        private void QuantifierDemo()
        {
            var result = employeeRepository.GetEmployees().All(x => x.Salary >= 5000);
            Console.WriteLine(result);
        }

        private void GroupbyDemo()
        {
            //query syntax
            //var result = from employee in employeeRepository.GetEmployees()
            //             group employee by employee.Department;

            //method syntax
            var result = employeeRepository.GetEmployees().GroupBy(x => x.Department);
            foreach (var itemGroup in result)
            {
                Console.WriteLine($"{itemGroup.Key} Department");
                foreach (var emp in itemGroup)
                {
                    Console.WriteLine($"Employee: {emp.FullName}");
                }
                Console.WriteLine();
            }

        }

        private void AggregationDemo()
        {
            //var result = employeeRepository.GetEmployees().Average(x => x.Salary);
            //Console.WriteLine(result);

            var result = employeeRepository.GetEmployees().GroupBy(x => x.Department).Select(x => new
            {
                Department = x.Key,
                TotalSalary = x.Sum(emp => emp.Salary),
                AverageSalary = Math.Round(x.Average(emp => emp.Salary),2)
            });
            foreach (var item in result)
            {
                Console.WriteLine(item.Department + "\t" + item.TotalSalary + "\t" + item.AverageSalary);
            }
        }

        public void Run()
        {
            AggregationDemo();
        }
    }
}
