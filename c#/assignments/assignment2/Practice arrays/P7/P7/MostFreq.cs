using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    public class MostFreq
    {
        public static int[,]MF(int[] nums)
        {
            int[] diff = new int[] {nums[0]};
            int[] count = new int[nums.Length];
            for (int i = 1; i < nums.Length; i++)
            {
                int match = 0;
                for (int j = 0; j < diff.Length; j++)
                {
                    if (diff[j] == nums[i])
                    {
                        match = j + 1;
                        count[j]++;
                    }
                }
                if (match == 0)
                {
                    var templist =diff.ToList();
                    templist.Add(nums[i]);
                    diff = templist.ToArray();  
                }
            }
            int[,] result = new int[diff.Length, 2];
            for (int k = 0; k < diff.Length; k++)
            {
                result[k,1]= count[k] + 1;
                result[k,0]= diff[k];
            }
            return result;
        }
    }
}
