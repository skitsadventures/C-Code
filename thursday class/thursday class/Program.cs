using System;

namespace thursday_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            double firstNumber;
            double secondNumber;
            double Total;
            double Quotient;


            Console.WriteLine("Enter your name");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your first number");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Total = firstNumber + secondNumber;
            Quotient = firstNumber / secondNumber;
            Console.WriteLine("The total of your 2 numbers is: " + Total);
            Console.WriteLine("The quotient of your total is: " + Total + "\n and the Quotien is : " + Quotient);
        }
    }
}
