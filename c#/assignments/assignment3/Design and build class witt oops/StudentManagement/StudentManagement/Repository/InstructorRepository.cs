using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.DataModel;

namespace SchoolManagement.Repository
{
    public class InstructorRepository : IRepository<Instructor>
    {
        List<Instructor> instructors = new List<Instructor>();
        public int Delete(int id)
        {
            Instructor instructor = GetById(id);
            if (instructor != null)
            {
                instructors.Remove(instructor);
                return 1;
            }
            return 0;
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            for (int i = 0; i < instructors.Count; i++)
            {
                if (instructors[i].Id == id)
                {
                    return instructors[i];
                }
            }
            return null;
        }

        public int Insert(Instructor obj)
        {
            instructors.Add(obj);

            return 1;
        }

        public int Update(Instructor obj)
        {
            Instructor instructor = new Instructor();
            if (instructor != null)
            {
                instructor.Id = obj.Id;
                instructor.Name = obj.Name;
                instructor.Age = obj.Age;
                instructor.Salary = obj.Salary;
                instructor.Address = obj.Address;
                instructor.Department=obj.Department;
                instructor.IsHead = obj.IsHead;
                instructor.JoinDate = obj.JoinDate;
                return 1;
            }
            return 0;
        }
    }
}
