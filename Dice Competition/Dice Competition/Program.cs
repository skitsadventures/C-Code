using System;

namespace Dice_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandNum;
            int EnemyRandNum;

            int playerpoints = 0;
            int enemypoints = 0;

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerRandNum = rand.Next(1, 7);
                Console.WriteLine("\n" + "You rolled a " + playerRandNum);

                Console.WriteLine(".");
                System.Threading.Thread.Sleep(300);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(300);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(300);


                EnemyRandNum = rand.Next(1, 7);
                Console.WriteLine("Enemy rolled a " + EnemyRandNum);
                System.Threading.Thread.Sleep(300);

                if (playerRandNum > EnemyRandNum)
                {
                    playerpoints++;
                    Console.WriteLine("player ins this round!");
                }
                else if (playerRandNum < EnemyRandNum)
                {
                    enemypoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine("score : Player: " + playerpoints + "| Enemy : " + enemypoints);
                Console.WriteLine();

            }

            if (playerpoints > enemypoints)
            {
                Console.WriteLine("You win!!!");
            }
            else if (playerpoints < enemypoints)
            {
                Console.WriteLine("You Lose Sucker!!!");
            }
            else
            {
                Console.WriteLine("Its a draw!");
            }

            Console.ReadKey();

        }
    }
}
