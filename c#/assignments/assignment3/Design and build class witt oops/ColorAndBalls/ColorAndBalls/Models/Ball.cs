using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorAndBalls.Models
{
    public class Ball
    {
        public int Id {get;set;}
        public int size { get; set; }
        public int[] color { get; set; }
        public int throws { get; set; }
    }
}
