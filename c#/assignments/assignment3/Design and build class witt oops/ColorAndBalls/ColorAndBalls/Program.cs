using ColorAndBalls.Controllers;

Console.Clear();
Console.WriteLine("Press 1 to Color Controller");
Console.WriteLine("Press 2 to Ball Controller");
Console.WriteLine("Press 9 to exit Main Menu");

Console.Write ("Enter to select =>");
BallController ballController = new BallController();
ColorController colorController = new ColorController();
int choice = Convert.ToInt32(Console.ReadLine());

while(choice != 0)
{
    switch (choice)
    {
        case 1:
            colorController.run();
            break;
        case 2:
            ballController.run();
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
    Console.Write("Enter to continue =>");
    choice = Convert.ToInt32(Console.ReadLine());
}