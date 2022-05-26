﻿using ConsoleApp4.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee> {
                new Employee() {Id=1, FullName="Scott", City="Sterling", Department="IT",Salary=5500 } ,
                new Employee() {Id=2, FullName="Peter", City="Sterling", Department="HR",Salary=4500 },
                new Employee() {Id=3, FullName="Laura", City="Leesburg", Department="IT",Salary=6500 },
                new Employee() {Id=4, FullName="David", City="Chicago", Department="IT",Salary=5000 },
                new Employee() {Id=5, FullName="Tracy", City="Chicago", Department="HR",Salary=5000 },
                new Employee() {Id=6, FullName="Fiona", City="Sterling", Department="IT",Salary=7500 }

            };
        }

        public List<Employee> Search(Func<Employee, bool> condition)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if(condition(emp))
                {
                    result.Add(emp);
                }
            }
            return result;
        }


        //public List<Employee> GetByCity(string city)
        //{
        //    List<Employee> result = new List<Employee> ();
        //    foreach (Employee employee in employees) {
        //        if (employee.City == city)
        //        {
        //            result.Add(employee);
        //        }
        //    }
        //    return result;
        //}

        //public List<Employee> GetByDepartment(string deparment)
        //{
        //    List<Employee> result = new List<Employee>();
        //    foreach (Employee employee in employees)
        //    {
        //        if (employee.Department == deparment)
        //        {
        //            result.Add(employee);
        //        }
        //    }
        //    return result;
        //}
    }
}
