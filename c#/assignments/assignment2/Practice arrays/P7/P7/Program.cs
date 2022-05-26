using P7;
using System.Linq;

namespace P7
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5, 6,6,6,6,6,6,6,6, 6, 1, 2, 3, 4, 4, 4, 4, 4, 4, 4, 4 };
            int[,] result = MostFreq.MF(test);
            int[] To1 = result.Cast<int>().Select(c => c).ToArray();
            int[] freq = new int[To1.Length / 2];
            int[] diff = new int[To1.Length / 2];
            for (int i = 0; i < freq.Length; i++)
            {
                freq[i] = To1[2 * i + 1];
                diff[i] = To1[2 * i];
            }
            List<int> final = new List<int>();
            int max = freq.Max();
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] == max)
                {
                    final.Add(diff[i]);
                }
            }
            Console.Write("The most frequent values are ");
            final.ForEach(num => Console.Write(num + ", "));
            Console.WriteLine();
            Console.WriteLine("They occur "+max +" times.");
        }
    }

}

