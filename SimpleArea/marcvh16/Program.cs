using System;

namespace marcvh16
{
    abstract class Shape
    {
        public abstract int Area();
    }
    class Rectangle: Shape
    {
        private int length;
        private int width;

        public Rectangle(int x = 0, int y = 0)
        {
            width = y;
            length = x;
        }
        public override int Area()
        {
            Console.WriteLine("The area of the rectangle is: ");
            return (length * width);
        }
    }
    class ShapeArea
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            
            Console.WriteLine(rectangle.Area());
        }
    }
}
