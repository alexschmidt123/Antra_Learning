using System;

public class P6
{
    public static void Main()
    {
        Console.Write("Please input an integer as increment: ");
        int increment= int.Parse(Console.ReadLine());
        for (int i = 0; i < 25; i=i+increment)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine("Hello world");
    }
    
}