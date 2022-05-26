using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class Judgement
    {
        public int PrimeNumberJudgement(int num)
        {
            int a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num%i == 0)
                {
                    a++;
                }
                
            }
            return a;
            // a=2, num is prime number. Otherwise, num is not.
        }
    }
}
