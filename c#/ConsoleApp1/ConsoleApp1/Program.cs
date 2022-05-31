namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            ParamPassing demo = new ParamPassing();
            string str;
            Console.WriteLine(demo.IsAuthentic("rebecca", "liu", out str));
            Console.WriteLine(str);
        }
    }

}
