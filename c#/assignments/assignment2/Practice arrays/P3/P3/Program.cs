using P3;

namespace P3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] result = Finds.FindPrimesInRange(3, 10);
            foreach (int i in result)
            Console.WriteLine(i);
        }
    }
   
}

