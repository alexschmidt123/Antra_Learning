using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    public class Controls
    {
        public int Finonacci(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            else if(num>2)
            {
                return Finonacci(num - 1)+Finonacci(num - 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
