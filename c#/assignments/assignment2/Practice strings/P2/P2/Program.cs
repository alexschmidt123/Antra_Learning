using P2;
namespace P2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/";
            //Console.WriteLine(ReverseSentence.RS(str));
            char[] delimiterChars = { ' ', ',', '.', ':', '!', '/', '=', '(', ')', '&', '[', ']', ';', '?', '\'', '\"', '\\' };
            string[] wordl = str.Split(delimiterChars);
            string[] words = str.Split(' ');
            Console.WriteLine($"{words.Length} words in text:");

            foreach (var word in words)
            {
                Console.WriteLine($"<{word}>");
            }
        }
    }
}