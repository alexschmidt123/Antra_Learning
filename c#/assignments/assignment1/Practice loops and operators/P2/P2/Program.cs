// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("How many layers would you like to have for your Pyramid?");
string dp = Console.ReadLine();
int layer = int.Parse(dp);
for (int i = 1; i <= layer; i++)
{
    Console.WriteLine(string.Concat(Enumerable.Repeat(" ", layer - i + 5)) + string.Concat(Enumerable.Repeat("*", 2 * i - 1)));
}
