using System;
public class AreaOfTriangle
{
    public static void Main()
    {
        Console.Write("Enter the length of side 1:");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 2:");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 3:");
        double side3 = Convert.ToDouble(Console.ReadLine());
        double semiperimeter = (side1 + side2 + side3) / 2;
        double Area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        Console.Write("Area of a Triangle = " + Area);
        Console.ReadKey();
    }
}