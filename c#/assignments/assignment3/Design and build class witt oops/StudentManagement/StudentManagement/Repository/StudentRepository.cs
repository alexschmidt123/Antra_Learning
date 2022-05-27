using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.DataModel;

namespace SchoolManagement.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        List<Student> students = new List<Student>();
        public int Delete(int id)
        {
            Student student = GetById(id);
            if (student != null)
            {
                students.Remove(student);
                return 1;
            }
            return 0;
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    return students[i];
                }
            }
            return null;
        }

        public int Insert(Student obj)
        {
            students.Add(obj);

            return 1;
        }

        public int Update(Student obj)
        {
            Student student = new Student();
            if (student != null)
            {
                student.Id = obj.Id;
                student.Name = obj.Name;
                student.Age = obj.Age;
                student.Courses = obj.Courses;
                student.Grade = obj.Grade;
                student.GPA = obj.GPA;
                return 1;
            }
            return 0;
        }


    }
}
