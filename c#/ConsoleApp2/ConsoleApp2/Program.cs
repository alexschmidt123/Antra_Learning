// Why OOP?
//write clean code; defend our code against errors; build API or .NET Application

// Class: blueprint implemented by code
// class contains properties and methods.
// properties: data that contained in a class
// methods: operations on a class

// object: an instance of class, with keyword new. Each object has its own values of properties.

namespace ConsoleApp2{
    public class Program{
        public static void Main(string[] args){
            //Customer:
            // Customer c = new Customer("Tom",24,1);
            // Console.WriteLine(c.Name);
            // Console.WriteLine(c.Age);
            // Console.WriteLine(c.Id);

            //Empoyee:
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.PerformWork();
            PartTimeEmployee pte = new PartTimeEmployee();
            pte.PerformWork();
        }
    }
}