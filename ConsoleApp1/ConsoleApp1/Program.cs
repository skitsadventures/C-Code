using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey whats your name?");
            string Name = Console.ReadLine();
            Console.WriteLine(Name + " thats cool, what do you study?");
            string Work = Console.ReadLine();
            Console.WriteLine("so your name is" + Name + "and you study" + Work + "awesome!");


        }
    }
}
