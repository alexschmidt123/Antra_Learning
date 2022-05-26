using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class LongestSequence
    {
        public static int[] LS(int[] nums)
        {
            int temp_count = 1;
            int max_count = 1;
            int num = nums[0];
            for (int i = 0; i < nums.Length-1;i++)
            {
                if (nums[i] == nums[i+1])
                {
                    temp_count++;
                }
                else
                {
                    temp_count = 1;
                }

                if (temp_count > max_count)
                {
                    max_count = temp_count;
                    num = nums[i];
                }
            }

            int[] result = new int[max_count];
            for (int i = 0; i < max_count;i++)
            {
                result[i] = num;
            }
            return result;
        }
    }
}
