using System;

namespace Numbers.cs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int FirstNum;
            int SecondNum = new int();
            Console.WriteLine("Please write the first number down");
            FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write the second number down");
            SecondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of these numbers is: " + (FirstNum + SecondNum));
            Console.WriteLine("The difference of these numbers is: " + (FirstNum - SecondNum));
        }
    }
}
