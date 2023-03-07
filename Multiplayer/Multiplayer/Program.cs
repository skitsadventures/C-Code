using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;


namespace Multiplayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GameServer";

            Server.Start(2, 17360);

            Console.ReadKey();
        }
    }
}
