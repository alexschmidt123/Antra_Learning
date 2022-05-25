int max = 100;
for (int i = 1; i <= max; i++)
{
    if (i % 3 == 0&& i % 5 != 0)
    {
        Console.WriteLine("fizz");
    }else if (i % 5 == 0 && i % 3 != 0)
    {
        Console.WriteLine("buzz");
    }else if (i % 5 == 0 && i % 3 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Which number would you like to guess from 1 to 3?");
string dp = Console.ReadLine();
int guessedNumber = int.Parse(dp); 
if (guessedNumber == correctNumber)
{
    Console.WriteLine("You answer is correct");
}else if(guessedNumber < correctNumber)
{
    Console.WriteLine("low answer");
}
else
{
    Console.WriteLine("high answer");
}