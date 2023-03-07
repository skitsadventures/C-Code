using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("please select an option \n A = + \n B = - \n C = * \n D= /");
        char choice = Console.ReadLine()[0];

        Console.WriteLine("First Number");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second Number");
        float num2 = float.Parse(Console.ReadLine());

        float result;
            switch (choice)
            {
                case 'A':
                    result = num1 + num2;
                    break;

                case 'B':
                    result = num1 - num2;
                    break;

                case 'C':
                    result = num1 * num2;
                    break;

                case 'D':
                    result = num1 / num2;
                    break;

                default: 
                    result = 0;
                    break;

            }
            Console.Write(result);
       }
  }
}   