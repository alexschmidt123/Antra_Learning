using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ParamPassing
    {
        // passing by value: a copy of actual parameters is created and will be passed into former parameters
        // default
        // so the previous parameters'values would not change after inmplementation.
        public void PassingByValue(int a, int b)
        {
            a = 80;
            b = 20;
            Console.WriteLine($"inside passing by value method: a = {a}, b = {b}");
        }

        // passing by type: the actual value is passed to the former parameters, so any change of former paramters will influence the actual parameters.
        //keyword ref
        public void PassingByReference(ref int a, ref int b)
        {
            a = 80;
            b = 20;
            Console.WriteLine($"inside passing by reference method: a = {a}, b = {b}");
        }

        // optional parameter: assign default values to optional parameters
        public void AreaOfCircle(double radius, double pi = 3.14)
        {
            Console.WriteLine($"Area of circle = {pi * radius * radius}");
        }

        // out mode example
        // returns more than one values
        public bool IsAuthentic(string uname, string password, out string msg)
        {
            msg = "";
            if (uname == "rebecca" && password == "liu")
            {
                msg = "You have sucessfully verified";
                return true;
            } 
            if (uname != "rebecca")
            {
                msg = "incorrect username";
            } else if(password != "liu")
            {
                msg = "incoorect password";
            }
            return false;
        }
        [Obsolete("User AddNubmers(params int[] arr) instead", true)]
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
        [Obsolete]
        public int AddThreeNumbers(int a, int b, int c)
        {
            return a + b  + c;
        }

        //parameters with variable length
        // keyword params
        public int AddNumbers(params int[] arr)
        {
            int length = arr.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

    }
}