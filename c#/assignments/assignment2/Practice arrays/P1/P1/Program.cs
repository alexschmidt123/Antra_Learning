using System;
using System.Linq;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carsInitial = { "Volvo", "BMW", "Ford", "Mazda","Dodge", "Toyota","Nissan", "Honda", "Merecede Benz", "Fiat"};
            string[] carsCopy = new string[10];
            for (int i = 0; i < carsInitial.Length; i++)
            {
                carsCopy[i] = carsInitial[i];
                Console.WriteLine(carsCopy[i]);
            }
        }
    }
}
