using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    public class  ReverseString
    {
        public  static string RS(string str)
        {
            char[] array = str.ToCharArray();
            for (int i = 0; i < array.Length/2;i++)
            {
                var temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp; 
            }
            string result = string.Join("", array);
            return result;
        }
    }
}
