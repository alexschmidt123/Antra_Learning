
namespace ConsoleApp7{

    public class Rectangle
    {
        private int width;
        private int height;

        public void setWidth(int width)
        {
            this.width = width;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
        public int area() { return height * width; }
    }

    public class Square: Rectangle
    {
        public void setWidth(int width)
        {
            base.setWidth(width);
            base.setHeight(width);
        }
        public void setHeight(int height)
        {
            base.setWidth(height);
            base.setHeight(height);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.setWidth(4);
            rect.setHeight(5);
            Console.WriteLine("Rectangle Area: "+rect.area());
            Square squa = new Square();
            squa.setWidth(4);
            squa.setHeight(5);
            Console.WriteLine("Square Area: " + squa.area());
        }
    }    
}

