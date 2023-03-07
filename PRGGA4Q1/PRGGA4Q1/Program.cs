using System;


namespace Questions
{
    class Program
    {
        static bool IsExamPassed(double computerScience, double math, double english)
        {
            return (computerScience + math + english) >= 75;
        }
        static void Main()
        {
            Console.WriteLine("Each subject is out of 50");
            Console.WriteLine("Please enter your:");

            Console.Write("Computer science mark: ");
            double computerScience = double.Parse(Console.ReadLine());


            Console.Write("Math mark: ");
            double math = double.Parse(Console.ReadLine());


            Console.Write("English mark: ");
            double english = double.Parse(Console.ReadLine());


            Console.WriteLine();


            if (IsExamPassed(computerScience, math, english))
                Console.WriteLine("You Passed!");
            else
                Console.WriteLine("Your grade is: F");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}