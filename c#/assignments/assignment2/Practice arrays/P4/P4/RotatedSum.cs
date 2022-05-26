using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    public class RotatedSum
    {
        public static int[] Rsum(int[] nums)
        {
            int l = nums.Length;
            int[] sum = new int[l];
            for (int i=0; i<= l-1; i++)
            {
                sum[i] = nums.Sum() - nums[i% l] - nums[(i + 1) % l];
            }
            return sum;
        }

    }
}
