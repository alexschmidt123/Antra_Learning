public class Program { 
    public static void outputInThreeLine (string str)
    {
        int length = str.Length;
        char[] chars = str.ToCharArray();
        if (length == 0)
        {
            return;
        }
        else if (length == 1)
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
            Console.WriteLine(chars[0] + " " + chars[2]);
        } else
        {
            for (int i = 1; i < length; i= i+4)
            {
                Console.Write(" " + chars[i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < length; i= i + 2)
            {
                Console.Write(chars[i] + " ");
            }
            Console.WriteLine();
            for(int i = 3; i < length; i= i + 4)
            {
                Console.Write("   " + chars[i]);
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        outputInThreeLine("Hello, World!");
        outputInThreeLine("He");
        outputInThreeLine("Hel");
        outputInThreeLine("H");
    }

}
