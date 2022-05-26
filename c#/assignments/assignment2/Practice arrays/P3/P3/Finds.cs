using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class Finds
    {
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            Judgement demo = new Judgement();
            int[] result = new int[] { };
            for (int i = startNum; i <= endNum; i++)
            {
                if (demo.PrimeNumberJudgement(i) == 2)
                {
                    result = result.Append(i).ToArray();
                }
            }
            return result;
        }
    }
}
