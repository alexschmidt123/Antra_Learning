Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Dodge", "Toyota", "Nissan", "Honda", "Merecede Benz", "Fiat" };
List<string> carList = new List<string>();
carList.AddRange(cars);
//foreach (string car in carList)
//{
//    Console.WriteLine(car);
//}
string command = Console.ReadLine();
string[] words = command.Split(' ');
//for (int i = 0; i < words.Length; i++)
//{
//    Console.WriteLine(words[i]);
//}
if (words[0] == "+")
{
    carList.Add(words[1]);
    foreach (string car in carList)
    {
        Console.WriteLine(car);
    }
}
else if (words[0] == "-")
{
    carList.Remove(words[1]);
    foreach (string car in carList)
    {
        Console.WriteLine(car);
    }
}
else if (words[0] == "--")
{
    carList.Clear();
    foreach (string car in carList)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Invalid input");
    foreach (string car in carList)
    {
        Console.WriteLine(car);
    }
}
