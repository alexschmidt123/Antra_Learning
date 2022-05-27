using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
   public class Controls
    {
        public int[] GenerateNumbers(int num)
        {
            int[] result = new int[num];
            for (int i = 0; i < num;i++)
            {
                result[i] = i + 1;
            }
            return result;      
        }

        public void Reverse(int[] nums)
        {
            for (int i = 0; i < nums.Length/2;i++)
            {
                var temp = nums[i];
                nums[i] = nums[nums.Length - 1 - i];
                nums[nums.Length - 1 - i] = temp;
            }
        }

        public void PrintNumbers(int[] nums)
        {
            Console.WriteLine("elements in string array: ");
            foreach (int i in nums)
                Console.Write(i + ", ");
        }
    }
}
