using P5;

namespace P5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums =new int[] {1,1,1,5,56,7,65,45,45,45,45,45,45};
            int[] result = LongestSequence.LS(nums);
            foreach (int i in result)
                Console.WriteLine(i);
        }
    }

}

