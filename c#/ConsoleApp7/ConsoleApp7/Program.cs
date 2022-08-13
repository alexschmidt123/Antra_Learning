
namespace ConsoleApp7{

    public class Program
    {
        public static void outputInThreeLine(string str)
        {
            int length = str.Length;
            char[] chars = str.ToCharArray();
            // Input string should not be null
            if (length == 1)
            {
                Console.WriteLine(chars[0]);
            } 
            else if (length == 2)
            {
                Console.WriteLine(" " + chars[1]);
                Console.WriteLine(chars[0]);
            }
            else if (length == 3)
            {
                Console.WriteLine(" " + chars[1]);
                Console.WriteLine(chars[0]+ " " + chars[2]);
            } else
            {
                for (int i = 1; i < length; i = i + 4)
                {
                    //1 space + char + 2 spaces
                    Console.Write(" " + chars[i] + "  ");
                }
                Console.WriteLine();
                for (int i = 0; i < length; i = i + 2)
                {
                    Console.Write(chars[i] + " ");
                }
                Console.WriteLine();
                for (int i = 3; i < length; i = i + 4)
                {
                    //3 spaces + char
                    Console.Write("   " + chars[i]);
                }
            }
        }

        public static bool isNumber (char c)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int stringToInteger(string str)
        {
            char[] chars = str.ToCharArray();
            if (chars.Length == 0 || chars.Length > 2147483647)
            { return 0;}
            else if (chars.Length == 1)
            {
                if (isNumber(chars[0])) { 
                    return (chars[0] - '0'); 
                } else { return 0; }
            }
            else
            {
                if (isNumber(chars[0]) || chars[0] == '+' || chars[0] == '-')
                {
                    int i = 1;
                    while (i < chars.Length && isNumber(chars[i]))
                    {
                        i++;
                    }
                    if (i== chars.Length) 
                    {
                        string str1 = new string(chars);
                        return int.Parse(str1);
                    } else { return 0; }
                } else {return 0;}             
            }
        }
        public static void Main(string[] args)
        {
            
            string str1 = "Hello, World!";
            string str2 = "JHI";
            string str3 = "-000576";
            string str4 = "advc";
            string str5 = "-000sa576";
            outputInThreeLine(str1);
            Console.WriteLine(" ");
            outputInThreeLine(str2);
            Console.WriteLine(stringToInteger(str3));
            Console.WriteLine(stringToInteger(str4));
            Console.WriteLine(stringToInteger(str5));
        }
    }    
}

