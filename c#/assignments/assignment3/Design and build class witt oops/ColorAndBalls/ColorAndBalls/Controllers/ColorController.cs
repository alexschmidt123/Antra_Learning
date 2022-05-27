using ColorAndBalls.Models;
using ColorAndBalls.Repository;

namespace ColorAndBalls.Controllers{
    public class ColorController{
        ColorRepository colorRepository = new ColorRepository();
        private void AddColor(){
            Color color = new Color();
            Console.WriteLine("Enter color Id:");
            color.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter color's red value (0-255):");
            color.red = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter color's green value (0-255):");
            color.green = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter color's blue value (0-255):");
            color.blue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter color's alpha value (0-255):");
            color.alpha = Convert.ToInt32(Console.ReadLine());
            if (colorRepository.Insert(color) > 0)
            {
                Console.WriteLine("color has been added");
            }
            else
            {
                Console.WriteLine("Error has occurred");
            }
        }

        private void printAllColor()
        {
            List<Color> allColors = colorRepository.GetAll();
            Console.WriteLine("Id" + "\t" + "red" + "\t" + "green" + "\t" + "blue"+ "\t"+"alpha");
            foreach (var color in allColors)
            {
                Console.WriteLine(color.Id + "\t" + color.red + "\t" + color.green + "\t" + color.blue+"\t" + color.alpha);
            }
        }

        private void DeleteColor()
        {
            Console.WriteLine("Enter Id of the Color you want to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (colorRepository.Delete(id) > 0)
            {
                Console.WriteLine("This Color is deleted successfully.");
            }
            else
            {
                Console.WriteLine("Errors happened.");
            }
        }


        public void run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to add a new Color");
            Console.WriteLine("Press 2 to print all Colors");
            Console.WriteLine("Press 3 to delete a Color");
            Console.WriteLine("Press 9 to exit Color Controller");

            Console.Write ("Enter to select the function you want to implement =>");
            int selection = Convert.ToInt32(Console.ReadLine());

            while(selection != 9)
            {
                switch (selection)
                {
                    case 1:
                        AddColor();
                        break;
                    case 2:
                        printAllColor();
                        break;
                    case 3:
                        DeleteColor();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                Console.Write("Enter to continue =>");
                selection = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}