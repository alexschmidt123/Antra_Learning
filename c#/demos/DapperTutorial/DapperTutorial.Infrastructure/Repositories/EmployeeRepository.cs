using DapperTutorial.Core.Entities;
using DapperTutorial.Core.Interfaces;
using DapperTutorial.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace DapperTutorial.Infrastructure.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        DbContext dbContext = new DbContext();
        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            IDbConnection conn = dbContext.GetConnection();
            //string str = "SELECT Id, EName, Age, DeptId FROM Employee";
            //return conn.Query<Employee>(str);
            string str = "SELECT e.Id, e.Ename, e.Age, d.Id, d.DName, d.Loc FROM Employee e INNER JOIN Department d ON e.deptId = d.id";
            return conn.Query<Employee, Department, Employee>(str, (e, d) =>
            {
                e.Dept = d;
                return e;
            });

        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Employee obj)
        {
            IDbConnection conn = dbContext.GetConnection();
            return conn.Execute("INSERT INTO Employee VALUES(@Id, @EName, @Age, @DeptId)", obj);
        }

        public int Update(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
