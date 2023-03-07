using System;

namespace money
{
    class Program
    {
        const float conversion = 17;
        static void Main(string[] args)
        {
            Console.WriteLine(" Please select amount of dollars: \n US$ 1 = R17");
            float dollars = float.Parse(Console.ReadLine());
            Console.WriteLine("R" + dollars * conversion);
        }
    }
}
