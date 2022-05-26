using P4;

namespace P4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5] {1,2,3, 4, 5};
            int[] result = RotatedSum.Rsum(nums);
            foreach (int i in result)
                Console.WriteLine(i);
        }

    }

}


