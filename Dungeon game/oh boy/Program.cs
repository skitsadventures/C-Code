using System;

namespace oh_boy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int healAmount = 10;

            int PlayerHP = 100;
            int HordeHP = 60;
            int BossHP = 100;
            int BeastHP = 40;

            Random random = new Random();
            int BChoice1 = random.Next(3);


            Console.WriteLine("Welcome to a real challange" + "\n" + "you find yourself in a dungeon. find the Key to escape." + "\n" + "as you are walking you come up to two tunels which do you choose?" + "\n" + "1: Left." + "\n" + "2: Right.");
            string tunnel_choice = Console.ReadLine();


            if (tunnel_choice == "1")
            {
                Console.Clear();
                Console.WriteLine("You come across a bridge with 2 ghouls guarding it how do you get through it?" + "\n" + "1: attack both at once" + "\n" + "2: attack one at a time");
                string bridge_choice = Console.ReadLine();
                int BChoice = Int32.Parse(bridge_choice);

                if (BChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You charge head first into battle!");
                    Console.WriteLine("You bravely defeated the ghouls but not before they each gave you a cut. -12HP");
                    PlayerHP -= 12;
                    Console.WriteLine(PlayerHP);

                }
                else if (BChoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("You manage to cut both of the ghouls down but not before one of them cuts you. -6HP ");
                    PlayerHP -= 6;
                    Console.WriteLine(PlayerHP);
                }

                Console.WriteLine("As you continue down the tunnel you enter a cave and ontop of a large boulder lies and even bigger beast, what do you do?" + "\n" + "1: drop your armour and sneak past" + "\n" + "2: challenge the beast!");
                string beast_choice = Console.ReadLine();
                int BeastChoice = Int32.Parse(beast_choice);

                if (BeastChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You take off your armour and sneak past the beast you step on a bone that cracks");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("the beasts breathing pauses for one moment but continues as normal. You made it safe and sound.");

                    if (PlayerHP > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("after you sneak out of the cave into what obviously looks like a boss arena, standing in the middle of the room is a warden with a set of keys at his side. what do you do?" + "\n" + "1: try to disarm his shield." + "\n" + "2: go to attack");
                        string choice1 = Console.ReadLine();

                        if (choice1 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("The Warden is slow but his strength is insane! with one bash of his shield you go flying back. -10HP. Theres no way im taking the shield off of him");
                            PlayerHP -= 15;
                            Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a Spear");
                            string choice7 = Console.ReadLine();

                            if (choice7 == "1")
                            {
                                Console.WriteLine("with 2 swords by your side you now deal X2 damage");
                                while ((PlayerHP > 0) && (BossHP > 0))
                                {
                                    Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                    string choice = Console.ReadLine();

                                    if (choice == "a")
                                    {
                                        int PlayerAtkChance = random.Next(1, 3);
                                        if (PlayerAtkChance == 1)
                                        {
                                            Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                            BossHP -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You missed!");
                                        }
                                    }
                                    else
                                    {
                                        PlayerHP += healAmount;
                                        Console.WriteLine("player restores 5 health");
                                    }

                                    if (BossHP > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enemy turn" + "\n");

                                        int BeastAtkChance = random.Next(1, 11);

                                        if (BeastAtkChance >= 7)
                                        {
                                            Console.WriteLine("direct Hit! 25 dmg");
                                            PlayerHP -= 25;
                                        }
                                        else
                                        {
                                            Console.WriteLine("it missed!" + "\n");
                                        }
                                        
                                        Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                        if (PlayerHP > 0)
                                        {
                                            Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                        }
                                    }
                                }
                            }
                            else if (choice7 == "2")
                            {

                                Console.WriteLine("With this spear you are less likely to get hit");
                                while ((PlayerHP > 0) && (BossHP > 0))
                                {
                                    Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                    string choice = Console.ReadLine();

                                    if (choice == "a")
                                    {
                                        int PlayerAtkChance = random.Next(1, 3);
                                        if (PlayerAtkChance == 1)
                                        {
                                            Console.WriteLine(" Player attacks the Boss and deals 10 dmg");
                                            BossHP -= 10;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You missed!");
                                        }
                                    }
                                    else
                                    {
                                        PlayerHP += healAmount;
                                        Console.WriteLine("player restores 5 health");
                                    }

                                    if (BossHP > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enemy turn" + "\n");

                                        int BeastAtkChance4 = random.Next(1, 11);

                                        if (BeastAtkChance4 >= 8)
                                        {
                                            Console.WriteLine("direct Hit! dmg");
                                            PlayerHP -= 25;
                                        }
                                        else
                                        {
                                            Console.WriteLine("it missed!" + "\n");
                                        }
                                        
                                        Console.WriteLine("\n" + "Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                    }
                                    if (PlayerHP > 0)
                                    {
                                        Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                    }
                                }
                            }
                        }
                        else if (choice1 == "2")
                        {

                            Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a Spear");
                            string choice2 = Console.ReadLine();

                            if (choice2 == "1")
                            {
                                Console.WriteLine("with 2 swords by your side you now deal X2 damage");
                                while ((PlayerHP > 0) && (BossHP > 0))
                                {
                                    Console.WriteLine("Press 'a' to attack or 'h' to heal");
                                    string choice9 = Console.ReadLine();

                                    if (choice9 == "a")
                                    {
                                        int PlayerAtkChance = random.Next(1, 3);
                                        if (PlayerAtkChance == 1)
                                        {
                                            Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                            BossHP -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You missed!");
                                        }
                                    }
                                    else
                                    {
                                        PlayerHP += healAmount;
                                        Console.WriteLine("player restores 5 health");
                                    }
                                    if (BossHP > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enemy turn" + "\n");
                                        int BeastAtkChance2 = random.Next(1, 11);
                                        if (BeastAtkChance2 >= 7)
                                        {
                                            Console.WriteLine("direct Hit! 20 dmg");
                                            PlayerHP -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("it missed!" + "\n");
                                        }
                                        
                                        Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Beasts health is " + BossHP);
                                    }
                                    if (PlayerHP > 0)
                                    {
                                        Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                    }
                                }
                            }
                            else if (choice2 == "2")
                            {
                                Console.WriteLine("With this spear you are less likely to get hit");
                                while ((PlayerHP > 0) && (BossHP > 0))
                                {
                                    Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                    string choice11 = Console.ReadLine();
                                    if (choice11 == "a")
                                    {
                                        int PlayerAtkChance = random.Next(1, 3);
                                        if (PlayerAtkChance == 1)
                                        {
                                            Console.WriteLine(" Player attacks the Boss and deals 10 dmg");
                                            BeastHP -= 10;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You missed!");
                                        }
                                    }
                                    else
                                    {
                                        PlayerHP += healAmount;
                                        Console.WriteLine("player restores 5 health");
                                    }

                                    if (BossHP > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enemy turn" + "\n");
                                        int BeastAtkChance4 = random.Next(1, 11);

                                        if (BeastAtkChance4 >= 8)
                                        {
                                            Console.WriteLine("direct Hit! dmg");
                                            PlayerHP -= 25;
                                        }
                                        else
                                        {
                                            Console.WriteLine("it missed!" + "\n");
                                        }
                                        
                                        Console.WriteLine("\n" + "Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                    }
                                    if (PlayerHP > 0)
                                    {
                                        Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (BeastChoice == 2)
                {
                    Console.WriteLine("you creep up to the beast and land the first strike. 10 Dmg");
                    while ((PlayerHP > 0) && (BeastHP > 0))
                    {
                        Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                        string choice55 = Console.ReadLine();
                        if (choice55 == "a")
                        {
                            int PlayerAtkChance = random.Next(1, 3);
                            if (PlayerAtkChance == 1)
                            {
                                Console.WriteLine(" Player attacks the beast and deals 10 dmg");
                                BeastHP -= 10;
                            }
                            else
                            {
                                Console.WriteLine("You missed!");
                            }
                        }
                        else
                        {
                            PlayerHP += healAmount;
                            Console.WriteLine("player restores 5 health");
                        }

                        if (BeastHP > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Enemy turn" + "\n");
                            int BeastAtkChance4 = random.Next(1, 11);

                            if (BeastAtkChance4 >= 5)
                            {
                                Console.WriteLine("direct Hit! 7dmg");
                                PlayerHP -= 7;
                            }
                            else
                            {
                                Console.WriteLine("it missed!" + "\n");
                            }
                            
                            Console.WriteLine("\n" + "Your Health is " + PlayerHP + "\n" + "The Beasts health is " + BeastHP);
                        }

                    }
                    if (PlayerHP > 0)
                    {
                        Console.WriteLine("after a glorious battle you walk out of the cave into what obviously looks like a boss arena, standing in the middle of the room is a warden with a set of keys at his side. what do you do?" + "\n" + "1: try to disarm his shield." + "\n" + "2: go to attack");
                        string choice10 = Console.ReadLine();

                        if (choice10 == "1")
                        {
                            Console.WriteLine("The Warden is slow but his strength is insane! with one bash of his shield you go flying back. -10HP. Theres no way im taking the shield off of him");
                            PlayerHP -= 10;
                            Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                            string choice77 = Console.ReadLine();

                            if (choice77 == "1")
                            {
                                Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                while ((PlayerHP > 0) && (BossHP > 0))
                                {
                                    Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                    string choice66 = Console.ReadLine();

                                    if (choice66 == "a")
                                    {
                                        int PlayerAtkChance = random.Next(1, 3);
                                        if (PlayerAtkChance == 1)
                                        {
                                            Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                            BossHP -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You missed!");
                                        }
                                    }
                                    else
                                    {
                                        PlayerHP += healAmount;
                                        Console.WriteLine("player restores 5 health");
                                    }

                                    if (BossHP > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enemy turn" + "\n");
                                        int BeastAtkChance = random.Next(1, 11);
                                        if (BeastAtkChance >= 7)
                                        {
                                            Console.WriteLine("direct Hit! 20 dmg");
                                            PlayerHP -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("it missed!" + "\n");
                                        }
                                        
                                        Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                        if (PlayerHP > 0)
                                        {
                                            Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                        }
                                    }
                                }
                            }
                            else if (choice77 == "2")
                            {

                                Console.WriteLine("You are more likely to dodge attacks with this spear");
                                while ((PlayerHP > 0) && (BossHP > 0))
                                {
                                    Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                    string choice88 = Console.ReadLine();

                                    if (choice88 == "a")
                                    {
                                        int PlayerAtkChance = random.Next(3);
                                        if (PlayerAtkChance == 1)
                                        {
                                            Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                            BossHP -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You missed!");
                                        }
                                    }
                                    else
                                    {
                                        PlayerHP += healAmount;
                                        Console.WriteLine("player restores 5 health");
                                    }

                                    if (BossHP > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enemy turn" + "\n");

                                        int BeastAtkChance = random.Next(1, 11);

                                        if (BeastAtkChance >= 8)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("direct Hit! 20 dmg");
                                            PlayerHP -= 20;
                                        }
                                        else if (BeastAtkChance <= 8)
                                        {
                                            Console.WriteLine("it missed!" + "\n");
                                        }
                                        
                                        Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                    }
                                    if (PlayerHP > 0)
                                    {
                                        Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                    }
                                }
                            }
                        }
                        else if (choice10 == "2")
                        {
                            Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                            string choice777 = Console.ReadLine();

                            if (choice777 == "1")
                            {
                                Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                while ((PlayerHP > 0) && (BossHP > 0))
                                {
                                    Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                    string choice66 = Console.ReadLine();

                                    if (choice66 == "a")
                                    {
                                        int PlayerAtkChance = random.Next(1, 3);
                                        if (PlayerAtkChance == 1)
                                        {
                                            Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                            BossHP -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You missed!");
                                        }
                                    }
                                    else
                                    {
                                        PlayerHP += healAmount;
                                        Console.WriteLine("player restores 5 health");
                                    }

                                    if (BossHP > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enemy turn" + "\n");
                                        int BeastAtkChance = random.Next(1, 11);
                                        if (BeastAtkChance >= 7)
                                        {
                                            Console.WriteLine("direct Hit! 20 dmg");
                                            PlayerHP -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("it missed!" + "\n");
                                        }
                                        
                                        Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                    }
                                }
                                if (PlayerHP > 0)
                                {
                                    Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                }
                                else
                                {
                                    Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                }
                            }
                            else if (choice777 == "2")
                            {

                                Console.WriteLine("You are more likely to dodge attacks with this spear");
                                while ((PlayerHP > 0) && (BossHP > 0))
                                {
                                    Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                    string choice88 = Console.ReadLine();

                                    if (choice88 == "a")
                                    {
                                        int PlayerAtkChance = random.Next(3);
                                        if (PlayerAtkChance == 1)
                                        {
                                            Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                            BossHP -= 10;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You missed!");
                                        }
                                    }
                                    else
                                    {
                                        PlayerHP += healAmount;
                                        Console.WriteLine("player restores 5 health");
                                    }

                                    if (BossHP > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enemy turn" + "\n");

                                        int BeastAtkChance = random.Next(1, 11);
                                        if (BeastAtkChance >= 8)
                                        {
                                            Console.WriteLine("direct Hit! 20 dmg");
                                            PlayerHP -= 20;
                                        }
                                        else if (BeastAtkChance >= 8)
                                        {
                                            Console.WriteLine("it missed!" + "\n");
                                        }
                                        
                                        Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                    }
                                }
                                if (PlayerHP > 0)
                                {
                                    Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                }
                                else
                                {
                                    Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                }
                            }
                        }
                    }
                }
            }
            else if (tunnel_choice == "2")
            {
                Console.Clear();
                Console.WriteLine("You walk into an eerie sound of metal slice through the air, it's swinging blade traps you see to your side are 2 buttons. One of them has to stap the blades right?" + "\n" + "1: button 1." + "\n" + "2: button 2");
                string choice3 = Console.ReadLine();

                if (choice3 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Oh no thats set off a poison dart trap! -15HP");
                    PlayerHP -= 15;
                    Console.WriteLine("choose again" + "\n" + "1: button 1" + "\n" + "2: button 2");
                    string choice555 = Console.ReadLine();

                    if (choice555 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Game over. Everything explodes. -100000000HP");
                        PlayerHP -= -100000000;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Success! the blades have stopped an you can continue to the next room!");
                        System.Threading.Thread.Sleep(1000);

                        Console.WriteLine("as you enter a dark area and your eyes adjust you see a horde of ghouls who all look really hungry! how do you handle this?" + "\n" + "1: Defensive." + "\n" + "2: Agressive.");
                        string choice123 = Console.ReadLine();

                        if (choice123 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You are cautious of their numbers");
                            while ((PlayerHP > 0) && (HordeHP > 0))
                            {
                                Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                string choice55 = Console.ReadLine();
                                if (choice55 == "a")
                                {
                                    int PlayerAtkChance = random.Next(1, 3);
                                    if (PlayerAtkChance == 1)
                                    {
                                        Console.WriteLine(" Player attacks the Horde and deals 10 dmg");
                                        HordeHP -= 10;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You missed!");
                                    }
                                }
                                else
                                {
                                    PlayerHP += healAmount;
                                    Console.WriteLine("player restores 5 health");
                                }

                                if (HordeHP > 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enemy turn" + "\n");
                                    int BeastAtkChance4 = random.Next(1, 11);

                                    if (BeastAtkChance4 >= 3)
                                    {
                                        Console.WriteLine("You've been bit! 6 dmg");
                                        PlayerHP -= 6;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You dodged them!" + "\n");
                                    }
                                    
                                    Console.WriteLine("\n" + "Your Health is " + PlayerHP + "\n" + "The Horde health is " + HordeHP);
                                }
                            }
                            if (PlayerHP > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("As you crawl out of the pit with pieces of flesh still hanging on all around you you see the room which obviously looks like a boss arena, standing in the middle of the room is a warden with a set of keys at his side. what do you do?" + "\n" + "1: try to disarm his shield." + "\n" + "2: go to attack");
                                string choice10 = Console.ReadLine();

                                if (choice10 == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("The Warden is slow but his strength is insane! with one bash of his shield you go flying back. -10HP. Theres no way im taking the shield off of him");
                                    PlayerHP -= 10;
                                    Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                                    string choice77 = Console.ReadLine();

                                    if (choice77 == "1")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                        while ((PlayerHP > 0) && (BossHP > 0))
                                        {
                                            Console.Clear();
                                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                            string choice66 = Console.ReadLine();

                                            if (choice66 == "a")
                                            {
                                                int PlayerAtkChance = random.Next(1, 3);
                                                if (PlayerAtkChance == 1)
                                                {
                                                    Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                    BossHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You missed!");
                                                }
                                            }
                                            else
                                            {
                                                PlayerHP += healAmount;
                                                Console.WriteLine("player restores 5 health");
                                            }

                                            if (BossHP > 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Enemy turn" + "\n");
                                                int BeastAtkChance = random.Next(1, 11);
                                                if (BeastAtkChance >= 7)
                                                {
                                                    Console.WriteLine("direct Hit! 20 dmg");
                                                    PlayerHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("it missed!" + "\n");
                                                }
                                                
                                                Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                                if (PlayerHP > 0)
                                                {
                                                    Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                                }
                                            }
                                        }
                                    }
                                    else if (choice77 == "2")
                                    {

                                        Console.WriteLine("You are more likely to dodge attacks with this spear");
                                        while ((PlayerHP > 0) && (BossHP > 0))
                                        {
                                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                            string choice828 = Console.ReadLine();

                                            if (choice828 == "a")
                                            {
                                                int PlayerAtkChance = random.Next(3);
                                                if (PlayerAtkChance == 1)
                                                {
                                                    Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                    BossHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You missed!");
                                                }
                                            }
                                            else
                                            {
                                                PlayerHP += healAmount;
                                                Console.WriteLine("player restores 5 health");
                                            }

                                            if (BossHP > 0)
                                            {
                                                Console.WriteLine("Enemy turn" + "\n");

                                                int BeastAtkChance = random.Next(1, 11);

                                                if (BeastAtkChance >= 8)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("direct Hit! 20 dmg");
                                                    PlayerHP -= 20;
                                                }
                                                else if (BeastAtkChance <= 8)
                                                {
                                                    Console.WriteLine("it missed!" + "\n");
                                                }
                                                
                                                Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                            }
                                            if (PlayerHP > 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                            }
                                        }
                                    }
                                }
                                else if (choice10 == "2")
                                {
                                    Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                                    string choice777 = Console.ReadLine();

                                    if (choice777 == "1")
                                    {
                                        Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                        while ((PlayerHP > 0) && (BossHP > 0))
                                        {
                                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                            string choice66 = Console.ReadLine();

                                            if (choice66 == "a")
                                            {
                                                int PlayerAtkChance = random.Next(1, 3);
                                                if (PlayerAtkChance == 1)
                                                {
                                                    Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                    BossHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You missed!");
                                                }
                                            }
                                            else
                                            {
                                                PlayerHP += healAmount;
                                                Console.WriteLine("player restores 5 health");
                                            }

                                            if (BossHP > 0)
                                            {
                                                Console.WriteLine("Enemy turn" + "\n");
                                                int BeastAtkChance = random.Next(1, 11);
                                                if (BeastAtkChance >= 7)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("direct Hit! 20 dmg");
                                                    PlayerHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("it missed!" + "\n");
                                                }
                                                
                                                Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                                if (PlayerHP > 0)
                                                {
                                                    Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                                }
                                            }
                                        }
                                    }
                                    else if (choice777 == "2")
                                    {

                                        Console.WriteLine("You are more likely to dodge attacks with this spear");
                                        while ((PlayerHP > 0) && (BossHP > 0))
                                        {
                                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                            string choice828 = Console.ReadLine();

                                            if (choice828 == "a")
                                            {
                                                int PlayerAtkChance = random.Next(3);
                                                if (PlayerAtkChance == 1)
                                                {
                                                    Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                    BossHP -= 10;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You missed!");
                                                }
                                            }
                                            else
                                            {
                                                PlayerHP += healAmount;
                                                Console.WriteLine("player restores 5 health");
                                            }

                                            if (BossHP > 0)
                                            {
                                                Console.WriteLine("Enemy turn" + "\n");

                                                int BeastAtkChance = random.Next(1, 11);
                                                if (BeastAtkChance >= 8)
                                                {
                                                    Console.WriteLine("direct Hit! 20 dmg");
                                                    PlayerHP -= 20;
                                                }
                                                else if (BeastAtkChance >= 8)
                                                {
                                                    Console.WriteLine("it missed!" + "\n");
                                                }
                                                Console.Clear();
                                                Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                            }
                                            if (PlayerHP > 0)
                                            {
                                                Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (choice123 == "2")
                        {

                            Console.WriteLine("you focus on cutting them down as quickly as possible.");
                            while ((PlayerHP > 0) && (HordeHP > 0))
                            {
                                Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                string choice55 = Console.ReadLine();
                                if (choice55 == "a")
                                {
                                    int PlayerAtkChance = random.Next(1, 3);
                                    if (PlayerAtkChance == 1)
                                    {
                                        Console.WriteLine(" Player attacks the Horde and deals 10 dmg");
                                        HordeHP -= 10;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You missed!");
                                    }
                                }
                                else
                                {
                                    PlayerHP += healAmount;
                                    Console.WriteLine("player restores 5 health");
                                }

                                if (HordeHP > 0)
                                {
                                    Console.WriteLine("Enemy turn" + "\n");
                                    int BeastAtkChance4 = random.Next(1, 11);

                                    if (BeastAtkChance4 >= 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("direct Hit! 6 dmg");
                                        PlayerHP -= 6;
                                    }
                                    else
                                    {
                                        Console.WriteLine("it missed!" + "\n");
                                    }
                                    
                                    Console.WriteLine("\n" + "Your Health is " + PlayerHP + "\n" + "The Horde health is " + HordeHP);
                                }
                            }
                            if (PlayerHP > 0)
                            {
                                Console.WriteLine("As you crawl out of the pit with pieces of flesh still hanging on all around you you see the room which obviously looks like a boss arena, standing in the middle of the room is a warden with a set of keys at his side. what do you do?" + "\n" + "1: try to disarm his shield." + "\n" + "2: go to attack");
                                string choice109 = Console.ReadLine();

                                if (choice109 == "1")
                                {
                                    Console.WriteLine("The Warden is slow but his strength is insane! with one bash of his shield you go flying back. -10HP. Theres no way im taking the shield off of him");
                                    PlayerHP -= 10;
                                    Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                                    string choice77 = Console.ReadLine();

                                    if (choice77 == "1")
                                    {
                                        Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                        while ((PlayerHP > 0) && (BossHP > 0))
                                        {
                                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                            string choice66 = Console.ReadLine();

                                            if (choice66 == "a")
                                            {
                                                int PlayerAtkChance = random.Next(1, 3);
                                                if (PlayerAtkChance == 1)
                                                {
                                                    Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                    BossHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You missed!");
                                                }
                                            }
                                            else
                                            {
                                                PlayerHP += healAmount;
                                                Console.WriteLine("player restores 5 health");
                                            }

                                            if (BossHP > 0)
                                            {
                                                Console.WriteLine("Enemy turn" + "\n");
                                                int BeastAtkChance = random.Next(1, 11);
                                                if (BeastAtkChance >= 7)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("direct Hit! 20 dmg");
                                                    PlayerHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("it missed!" + "\n");
                                                }
                                                
                                                Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                                if (PlayerHP > 0)
                                                {
                                                    Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                                }
                                            }
                                        }
                                    }
                                    else if (choice77 == "2")
                                    {

                                        Console.WriteLine("You are more likely to dodge attacks with this spear");
                                        while ((PlayerHP > 0) && (BossHP > 0))
                                        {
                                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                            string choice828 = Console.ReadLine();

                                            if (choice828 == "a")
                                            {
                                                int PlayerAtkChance = random.Next(3);
                                                if (PlayerAtkChance == 1)
                                                {
                                                    Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                    BossHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You missed!");
                                                }
                                            }
                                            else
                                            {
                                                PlayerHP += healAmount;
                                                Console.WriteLine("player restores 5 health");
                                            }

                                            if (BossHP > 0)
                                            {
                                                Console.WriteLine("Enemy turn" + "\n");

                                                int BeastAtkChance = random.Next(1, 11);

                                                if (BeastAtkChance >= 8)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("direct Hit! 20 dmg");
                                                    PlayerHP -= 20;
                                                }
                                                else if (BeastAtkChance <= 8)
                                                {
                                                    Console.WriteLine("it missed!" + "\n");
                                                }
                                                
                                                Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                            }
                                            if (PlayerHP > 0)
                                            {
                                                Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                            }
                                        }
                                    }
                                }
                                else if (choice109 == "2")
                                {
                                    Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                                    string choice7779 = Console.ReadLine();

                                    if (choice7779 == "1")
                                    {
                                        Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                        while ((PlayerHP > 0) && (BossHP > 0))
                                        {
                                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                            string choice66 = Console.ReadLine();

                                            if (choice66 == "a")
                                            {
                                                int PlayerAtkChance = random.Next(1, 3);
                                                if (PlayerAtkChance == 1)
                                                {
                                                    Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                    BossHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You missed!");
                                                }
                                            }
                                            else
                                            {
                                                PlayerHP += healAmount;
                                                Console.WriteLine("player restores 5 health");
                                            }

                                            if (BossHP > 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Enemy turn" + "\n");
                                                int BeastAtkChance = random.Next(1, 11);
                                                if (BeastAtkChance >= 7)
                                                {
                                                    Console.WriteLine("direct Hit! 20 dmg");
                                                    PlayerHP -= 20;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("it missed!" + "\n");
                                                }
                                                
                                                Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                                if (PlayerHP > 0)
                                                {
                                                    Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                                }
                                            }
                                        }
                                    }
                                    else if (choice7779 == "2")
                                    {

                                        Console.WriteLine("You are more likely to dodge attacks with this spear");
                                        while ((PlayerHP > 0) && (BossHP > 0))
                                        {
                                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                            string choice828 = Console.ReadLine();

                                            if (choice828 == "a")
                                            {
                                                int PlayerAtkChance = random.Next(3);
                                                if (PlayerAtkChance == 1)
                                                {
                                                    Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                    BossHP -= 10;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You missed!");
                                                }
                                            }
                                            else
                                            {
                                                PlayerHP += healAmount;
                                                Console.WriteLine("player restores 5 health");
                                            }

                                            if (BossHP > 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Enemy turn" + "\n");

                                                int BeastAtkChance = random.Next(1, 11);
                                                if (BeastAtkChance >= 8)
                                                {
                                                    Console.WriteLine("direct Hit! 20 dmg");
                                                    PlayerHP -= 20;
                                                }
                                                else if (BeastAtkChance >= 8)
                                                {
                                                    Console.WriteLine("it missed!" + "\n");
                                                }
                                                
                                                Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                            }
                                            if (PlayerHP > 0)
                                            {
                                                Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Success! the blades have stopped an you can continue to the next room!");
                    System.Threading.Thread.Sleep(1000);

                    Console.WriteLine("as you enter a dark area and your eyes adjust you see a horde of ghouls who all look really hungry! how do you handle this?" + "\n" + "1: Defensive." + "\n" + "2: Agressive.");
                    string choice1223 = Console.ReadLine();

                    if (choice1223 == "1")
                    {
                        Console.WriteLine("You are cautious of their numbers");
                        while ((PlayerHP > 0) && (HordeHP > 0))
                        {
                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                            string choice55 = Console.ReadLine();
                            if (choice55 == "a")
                            {
                                int PlayerAtkChance = random.Next(1, 3);
                                if (PlayerAtkChance == 1)
                                {
                                    Console.WriteLine(" Player attacks the Horde and deals 10 dmg");
                                    HordeHP -= 10;
                                }
                                else
                                {
                                    Console.WriteLine("You missed!");
                                }
                            }
                            else
                            {
                                PlayerHP += healAmount;
                                Console.WriteLine("player restores 5 health");
                            }

                            if (HordeHP > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Enemy turn" + "\n");
                                int BeastAtkChance4 = random.Next(1, 11);

                                if (BeastAtkChance4 >= 2)
                                {
                                    Console.WriteLine("direct Hit! 6 dmg");
                                    PlayerHP -= 6;
                                }
                                else
                                {
                                    Console.WriteLine("it missed!" + "\n");
                                }
                                
                                Console.WriteLine("\n" + "Your Health is " + PlayerHP + "\n" + "The Horde health is " + HordeHP);
                            }
                        }
                        if (PlayerHP > 0)
                        {
                            Console.WriteLine("As you crawl out of the pit with pieces of flesh still hanging on all around you you see the room which obviously looks like a boss arena, standing in the middle of the room is a warden with a set of keys at his side. what do you do?" + "\n" + "1: try to disarm his shield." + "\n" + "2: go to attack");
                            string choice10 = Console.ReadLine();

                            if (choice10 == "1")
                            {
                                Console.WriteLine("The Warden is slow but his strength is insane! with one bash of his shield you go flying back. -10HP. Theres no way im taking the shield off of him");
                                PlayerHP -= 10;
                                Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                                string choice77 = Console.ReadLine();

                                if (choice77 == "1")
                                {
                                    Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                    while ((PlayerHP > 0) && (BossHP > 0))
                                    {
                                        Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                        string choice66 = Console.ReadLine();

                                        if (choice66 == "a")
                                        {
                                            int PlayerAtkChance = random.Next(1, 3);
                                            if (PlayerAtkChance == 1)
                                            {
                                                Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                BossHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("You missed!");
                                            }
                                        }
                                        else
                                        {
                                            PlayerHP += healAmount;
                                            Console.WriteLine("player restores 5 health");
                                        }

                                        if (BossHP > 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enemy turn" + "\n");
                                            int BeastAtkChance = random.Next(1, 11);
                                            if (BeastAtkChance >= 7)
                                            {
                                                Console.WriteLine("direct Hit! 20 dmg");
                                                PlayerHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("it missed!" + "\n");
                                            }
                                            
                                            Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                            if (PlayerHP > 0)
                                            {
                                                Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                            }
                                        }
                                    }
                                }
                                else if (choice77 == "2")
                                {

                                    Console.WriteLine("You are more likely to dodge attacks with this spear");
                                    while ((PlayerHP > 0) && (BossHP > 0))
                                    {
                                        Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                        string choice828 = Console.ReadLine();

                                        if (choice828 == "a")
                                        {
                                            int PlayerAtkChance = random.Next(3);
                                            if (PlayerAtkChance == 1)
                                            {
                                                Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                BossHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("You missed!");
                                            }
                                        }
                                        else
                                        {
                                            PlayerHP += healAmount;
                                            Console.WriteLine("player restores 5 health");
                                        }

                                        if (BossHP > 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enemy turn" + "\n");

                                            int BeastAtkChance = random.Next(1, 11);

                                            if (BeastAtkChance >= 8)
                                            {
                                                Console.WriteLine("direct Hit! 20 dmg");
                                                PlayerHP -= 20;
                                            }
                                            else if (BeastAtkChance <= 8)
                                            {
                                                Console.WriteLine("it missed!" + "\n");
                                            }
                                            
                                            Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                        }
                                        if (PlayerHP > 0)
                                        {
                                            Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                        }
                                    }
                                }
                            }
                            else if (choice10 == "2")
                            {
                                Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                                string choice777 = Console.ReadLine();

                                if (choice777 == "1")
                                {
                                    Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                    while ((PlayerHP > 0) && (BossHP > 0))
                                    {
                                        Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                        string choice66 = Console.ReadLine();

                                        if (choice66 == "a")
                                        {
                                            int PlayerAtkChance = random.Next(1, 3);
                                            if (PlayerAtkChance == 1)
                                            {
                                                Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                BossHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("You missed!");
                                            }
                                        }
                                        else
                                        {
                                            PlayerHP += healAmount;
                                            Console.WriteLine("player restores 5 health");
                                        }

                                        if (BossHP > 0)
                                        {
                                            Console.WriteLine("Enemy turn" + "\n");
                                            int BeastAtkChance = random.Next(1, 11);
                                            if (BeastAtkChance >= 7)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("direct Hit! 20 dmg");
                                                PlayerHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("it missed!" + "\n");
                                            }
                                            
                                            Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                            if (PlayerHP > 0)
                                            {
                                                Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                            }
                                        }
                                    }
                                }
                                else if (choice777 == "2")
                                {

                                    Console.WriteLine("You are more likely to dodge attacks with this spear");
                                    while ((PlayerHP > 0) && (BossHP > 0))
                                    {
                                        Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                        string choice828 = Console.ReadLine();

                                        if (choice828 == "a")
                                        {
                                            int PlayerAtkChance = random.Next(3);
                                            if (PlayerAtkChance == 1)
                                            {
                                                Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                BossHP -= 10;
                                            }
                                            else
                                            {
                                                Console.WriteLine("You missed!");
                                            }
                                        }
                                        else
                                        {
                                            PlayerHP += healAmount;
                                            Console.WriteLine("player restores 5 health");
                                        }

                                        if (BossHP > 0)
                                        {
                                            Console.WriteLine("Enemy turn" + "\n");

                                            int BeastAtkChance = random.Next(1, 11);
                                            if (BeastAtkChance >= 8)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("direct Hit! 20 dmg");
                                                PlayerHP -= 20;
                                            }
                                            else if (BeastAtkChance >= 8)
                                            {
                                                Console.WriteLine("it missed!" + "\n");
                                            }
                                            
                                            Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                        }
                                        if (PlayerHP > 0)
                                        {
                                            Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (choice1223 == "2")
                    {

                        Console.WriteLine("you focus on cutting them down as quickly as possible.");
                        while ((PlayerHP > 0) && (HordeHP > 0))
                        {
                            Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                            string choice55 = Console.ReadLine();
                            if (choice55 == "a")
                            {
                                int PlayerAtkChance = random.Next(1, 3);
                                if (PlayerAtkChance == 1)
                                {
                                    Console.WriteLine(" Player attacks the Horde and deals 10 dmg");
                                    HordeHP -= 10;
                                }
                                else
                                {
                                    Console.WriteLine("You missed!");
                                }
                            }
                            else
                            {
                                PlayerHP += healAmount;
                                Console.WriteLine("player restores 5 health");
                            }

                            if (HordeHP > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Enemy turn" + "\n");
                                int BeastAtkChance4 = random.Next(1, 11);

                                if (BeastAtkChance4 >= 2)
                                {
                                    Console.WriteLine("direct Hit! 6 dmg");
                                    PlayerHP -= 6;
                                }
                                else
                                {
                                    Console.WriteLine("it missed!" + "\n");
                                }
                                
                                Console.WriteLine("\n" + "Your Health is " + PlayerHP + "\n" + "The Horde health is " + HordeHP);
                            }
                        }
                        if (PlayerHP > 0)
                        {
                            Console.WriteLine("As you crawl out of the pit with pieces of flesh still hanging on all around you you see the room which obviously looks like a boss arena, standing in the middle of the room is a warden with a set of keys at his side. what do you do?" + "\n" + "1: try to disarm his shield." + "\n" + "2: go to attack");
                            string choice1209 = Console.ReadLine();

                            if (choice1209 == "1")
                            {
                                Console.WriteLine("The Warden is slow but his strength is insane! with one bash of his shield you go flying back. -10HP. Theres no way im taking the shield off of him");
                                PlayerHP -= 10;
                                Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                                string choice77 = Console.ReadLine();

                                if (choice77 == "1")
                                {
                                    Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                    while ((PlayerHP > 0) && (BossHP > 0))
                                    {
                                        Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                        string choice66 = Console.ReadLine();

                                        if (choice66 == "a")
                                        {
                                            int PlayerAtkChance = random.Next(1, 3);
                                            if (PlayerAtkChance == 1)
                                            {
                                                Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                BossHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("You missed!");
                                            }
                                        }
                                        else
                                        {
                                            PlayerHP += healAmount;
                                            Console.WriteLine("player restores 5 health");
                                        }

                                        if (BossHP > 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enemy turn" + "\n");
                                            int BeastAtkChance = random.Next(1, 11);
                                            if (BeastAtkChance >= 7)
                                            {
                                                Console.WriteLine("direct Hit! 20 dmg");
                                                PlayerHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("it missed!" + "\n");
                                            }
                                            
                                            Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                            if (PlayerHP > 0)
                                            {
                                                Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                            }
                                        }
                                    }
                                }
                                else if (choice77 == "2")
                                {

                                    Console.WriteLine("You are more likely to dodge attacks with this spear");
                                    while ((PlayerHP > 0) && (BossHP > 0))
                                    {
                                        Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                        string choice828 = Console.ReadLine();

                                        if (choice828 == "a")
                                        {
                                            int PlayerAtkChance = random.Next(3);
                                            if (PlayerAtkChance == 1)
                                            {
                                                Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                BossHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("You missed!");
                                            }
                                        }
                                        else
                                        {
                                            PlayerHP += healAmount;
                                            Console.WriteLine("player restores 5 health");
                                        }

                                        if (BossHP > 0)
                                        {
                                            Console.WriteLine("Enemy turn" + "\n");

                                            int BeastAtkChance = random.Next(1, 11);

                                            if (BeastAtkChance >= 8)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("direct Hit! 20 dmg");
                                                PlayerHP -= 20;
                                            }
                                            else if (BeastAtkChance <= 8)
                                            {
                                                Console.WriteLine("it missed!" + "\n");
                                            }
                                            
                                            Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                        }
                                        if (PlayerHP > 0)
                                        {
                                            Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                        }
                                    }
                                }
                            }
                            else if (choice1209 == "2")
                            {
                                Console.WriteLine("How do you choose to fight him?" + "\n" + "1: with 2 swords" + "\n" + "2: with a spear");
                                string choice7777 = Console.ReadLine();

                                if (choice7777 == "1")
                                {
                                    Console.WriteLine("-----------------------------------------------------" + "\n" + "with 2 swords by your side you now deal X2 damage" + "\n" + "-----------------------------------------------------" + "\n");
                                    while ((PlayerHP > 0) && (BossHP > 0))
                                    {
                                        Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");
                                        string choice66 = Console.ReadLine();

                                        if (choice66 == "a")
                                        {
                                            int PlayerAtkChance = random.Next(1, 3);
                                            if (PlayerAtkChance == 1)
                                            {
                                                Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                BossHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("You missed!");
                                            }
                                        }
                                        else
                                        {
                                            PlayerHP += healAmount;
                                            Console.WriteLine("player restores 5 health");
                                        }

                                        if (BossHP > 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enemy turn" + "\n");
                                            int BeastAtkChance = random.Next(1, 11);
                                            if (BeastAtkChance >= 7)
                                            {
                                                Console.WriteLine("direct Hit! 20 dmg");
                                                PlayerHP -= 20;
                                            }
                                            else
                                            {
                                                Console.WriteLine("it missed!" + "\n");
                                            }
                                            
                                            Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                            if (PlayerHP > 0)
                                            {
                                                Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- "); ;
                                            }
                                        }
                                    }
                                }
                                else if (choice7777 == "2")
                                {

                                    Console.WriteLine("You are more likely to dodge attacks with this spear");
                                    while ((PlayerHP > 0) && (BossHP > 0))
                                    {
                                        Console.WriteLine("-----------------------------------------------" + "\n" + "Press 'a' to attack or 'h' to heal" + "\n" + "-----------------------------------------------");

                                        string choice828 = Console.ReadLine();

                                        if (choice828 == "a")
                                        {
                                            int PlayerAtkChance = random.Next(3);
                                            if (PlayerAtkChance == 1)
                                            {
                                                Console.WriteLine(" Player attacks the beast and deals 20 dmg");
                                                BossHP -= 10;
                                            }
                                            else
                                            {
                                                Console.WriteLine("You missed!");
                                            }
                                        }
                                        else
                                        {
                                            PlayerHP += healAmount;
                                            Console.WriteLine("player restores 5 health");
                                        }

                                        if (BossHP > 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enemy turn" + "\n");

                                            int BeastAtkChance = random.Next(1, 11);
                                            if (BeastAtkChance >= 8)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("direct Hit! 20 dmg");
                                                PlayerHP -= 20;
                                            }
                                            else if (BeastAtkChance >= 8)
                                            {
                                                Console.WriteLine("it missed!" + "\n");
                                            }
                                            
                                            Console.WriteLine("Your Health is " + PlayerHP + "\n" + "The Boss health is " + BossHP);
                                        }
                                        if (PlayerHP > 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("With the Warden defeated and keys in hand you leave the dungeon to fight another day!");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("-----------------------------" + "\n" + "You Lose" + "\n" + "----------------------------- ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}