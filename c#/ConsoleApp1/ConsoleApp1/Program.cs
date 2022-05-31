namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            //c# is a strongly type language


            //out mode example:
            // ParamPassing demo = new ParamPassing();
            // string str;
            // Console.WriteLine(demo.IsAuthentic("rebecca", "liu", out str));
            // Console.WriteLine(str);

            // enum example:
            //enum is a value type variable.
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");  // output: Integral value of Autumn is 2
            var b = (Season)1;
            Console.WriteLine(b);  // output: Summer
            var c = (Season)0;
            Console.WriteLine(c);  // output: 4


        }
    }
}
