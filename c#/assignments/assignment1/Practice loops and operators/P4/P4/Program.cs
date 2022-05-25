using System;

public class P4
{
    public static void Main()
    {
        Console.WriteLine("Enter your birth date (as mm/dd/yyyy): ");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(birthDay.ToString());
        DateTime thisDay = DateTime.Today;
        Console.WriteLine(thisDay.ToString());
        TimeSpan difference = thisDay - birthDay;
        Console.WriteLine("Your age in day format is "+difference.Days +" days.");
        int daysToNextAnniversary = 10000 - (difference.Days % 10000);
        Console.WriteLine("Your next 10,000 day (about 27 years) anniversary is in " + daysToNextAnniversary + " days.");
    }
}