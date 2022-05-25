using System;
using System.Globalization;

public class P5
{
    public static void Main()
    {
        DateTime nowtime = DateTime.Now;
        DateTime reference = DateTime.Today;
        TimeSpan difference = nowtime - reference;
        Console.WriteLine(difference.TotalHours);
        int df = (int)difference.TotalHours;
        Console.WriteLine(df);
        if (df <= 12 && df > 5)
        {
            Console.WriteLine("Good Morning");
        }else if (df <= 17 && df > 12)
        {
            Console.WriteLine("Good Afternoon");
        }else if (df >17 && df <= 20)
        {
            Console.WriteLine("Good Evening");
        }
        else
        {
            Console.WriteLine("Good Night");
        }
    }
}