using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.DataModel;
using SchoolManagement.Repository;

namespace SchoolManagement.Presentation
{
    public class ManageStudent
    {
        StudentRepository studentRepository = new StudentRepository();
        private void AddStudent()
        {
            Student student = new Student();
            Console.WriteLine("Enter student Id:");
            student.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student Name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter student Age:");
            student.Age = Convert.ToInt32(Console.ReadLine());
            student.Courses = new string[]{};
            student.Grade = new string[]{};
            student.GPA = 0;
            if (studentRepository.Insert(student) > 0)
            {
                Console.WriteLine("Student has been added");
            }
            else
            {
                Console.WriteLine("Error has occurred");
            }
        }

        private void printAllStudent()
        {
            List<Student> allstudents = studentRepository.GetAll();
            Console.WriteLine("Id" + "\t" + "Name" + "\t" + "Age" + "\t" + "GPA");
            foreach (var student in allstudents)
            {
                Console.WriteLine(student.Id + "\t" + student.Name + "\t" + student.Age + "\t" + student.GPA);
            }
        }

        private void DeleteStudent()
        {
            Console.WriteLine("Enter Id of the student you want to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (studentRepository.Delete(id) > 0)
            {
                Console.WriteLine("This student is deleted successfully.");
            }
            else
            {
                Console.WriteLine("Errors happened.");
            }
        }

        private void AddCourseforStudent()
        {

        }

        public void run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to add a new student");
            Console.WriteLine("Press 2 to print all students");
            Console.WriteLine("Press 3 to delete a student");
            Console.WriteLine("Press 9 to exit studentmanagement");

            Console.Write ("Enter to select the function you want to implement =>");
            int selection = Convert.ToInt32(Console.ReadLine());

            while(selection != 0)
            {
                switch (selection)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        printAllStudent();
                        break;
                    case 3:
                        DeleteStudent();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                Console.Write("Enter to continue =>");
                selection = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
