using P1;

namespace P1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Controls controls = new Controls();
            int[] numbers = controls.GenerateNumbers(11);
            controls.Reverse(numbers);
            controls.PrintNumbers(numbers);
        }
    }
}