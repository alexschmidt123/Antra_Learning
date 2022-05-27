using P2;

namespace P2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Controls controls = new Controls();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(controls.Finonacci(i));
            }
        }
    }
}