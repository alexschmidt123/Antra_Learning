using ColorAndBalls.Models;
using ColorAndBalls.Repository;

namespace ColorAndBalls.Controllers{
    public class BallController{
        BallRepository ballRepository = new BallRepository();
        private void AddBall(){
            Ball ball = new Ball();
            ball.color = new Color();
            Console.WriteLine("Enter Ball Id:");
            ball.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ball Size (size >0):");
            ball.size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ball's red value (0-255):");
            ball.color.red = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ball's green value (0-255):");
            ball.color.green = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ball's blue value (0-255):");
            ball.color.blue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ball's alpha value (0-255):");
            ball.color.alpha = Convert.ToInt32(Console.ReadLine());
            ball.throws = 0;
            if (ballRepository.Insert(ball) > 0)
            {
                Console.WriteLine("Ball has been added");
            }
            else
            {
                Console.WriteLine("Error has occurred");
            }
        }

        private void printAllBall()
        {
            List<Ball> allBalls = ballRepository.GetAll();
            Console.WriteLine("Id" + "\t" + "color (rgba)" + "\t" + "size" + "\t" + "throws");
            foreach (var ball in allBalls)
            {
                Console.WriteLine(ball.Id + "\t" + ball.color.red + "," + ball.color.green + "," + ball.color.blue+"," + ball.color.alpha+"\t"+ball.size+ "\t" + ball.throws);
            }
        }

        private void DeleteBall()
        {
            Console.WriteLine("Enter Id of the Ball you want to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (ballRepository.Delete(id) > 0)
            {
                Console.WriteLine("This Ball is deleted successfully.");
            }
            else
            {
                Console.WriteLine("Errors happened.");
            }
        }


        public void run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to add a new Ball");
            Console.WriteLine("Press 2 to print all Balls");
            Console.WriteLine("Press 3 to delete a Ball");
            Console.WriteLine("Press 9 to exit Ball Controller");

            Console.Write ("Enter to select the function you want to implement =>");
            int selection = Convert.ToInt32(Console.ReadLine());

            while(selection != 9)
            {
                switch (selection)
                {
                    case 1:
                        AddBall();
                        break;
                    case 2:
                        printAllBall();
                        break;
                    case 3:
                        DeleteBall();
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