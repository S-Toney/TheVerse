using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Characters;
using Actions;

namespace TheVerse
{
    class Program
    {
        public static int score = 0;
        private static Boss boss;
        private static Croanie croanie;
        static void Main(string[] args)
        {
            bool keepGoing = true;
            bool repeat = true;
            bool choose = true;
            bool again = true;
            PlayerCharacter player = new PlayerCharacter();
            Fighter mal = new Fighter("Captain Reynolds- Big Bad Veterin - A man of honor in a din of thieves", 12, true, 12, "Capt. Malcom Reynolds", 3, 1, 3, 1, 6);
            Fighter zoe = new Fighter("First Mate", 12, true, 12, "Zo\u00eb", 3, 2, 4, 2, 6);

            Console.Title = "The 'Verse";
            Console.WriteLine("Press escape to exit.\n\n\n\n" +
                "You're peacefully floating through the 'verse when...\n\n");
            Thread.Sleep(2500);
            //TODONE Keep score
            do
            {
                //Choose Character Loop
                do
                {
                    Console.WriteLine("\tChoose your character: \n" +
                        "\t\tM)al\n" +
                        "\t\tZ)o\u00eb\n" +
                        "\t\tE)xit");
                    //"\t\tW)ash\n" +
                    //"\t\tI)nara\n" +
                    //"\t\tJ)ayne\n" +
                    //"\t\tK)aylee\n" +
                    //"\t\tS)imon\n" +
                    //"\t\tR)iver\n" +
                    //"\t\tB)ook\n");
                    ConsoleKey chooseCharacter = Console.ReadKey(true).Key;
                    switch (chooseCharacter)
                    {
                        case ConsoleKey.Escape:
                        case ConsoleKey.E:
                        case ConsoleKey.X:
                            Console.WriteLine("As I understand it, it's a bit cold outside. Better put on a suit.");
                            //Console.WriteLine("\n\n\t\t\t\t\tPress enter to exit...");
                            //Console.ReadLine();//TODONE Remove and replace with Sleep()                           
                            repeat = false;
                            choose = true;
                            repeat = false;
                            keepGoing = false;
                            //Thread.Sleep(2500);
                            break;
                        case ConsoleKey.M:
                            player = mal;
                            Console.WriteLine("\n\n\tHello Captain.\n\n\t\t\t\t\tPress enter to continue...");
                            //Console.ReadLine();
                            Thread.Sleep(2500);
                            choose = true;
                            break;
                        case ConsoleKey.Z:
                            player = zoe;
                            Console.WriteLine("\n\n\tHello Zo\u00eb\n\n\t\t\t\t\tPress enter to continue...");
                            //Console.ReadLine();
                            Thread.Sleep(2500);
                            choose = true;
                            break;
                        //case ConsoleKey.W:
                        //    player = Wash;
                        //    Console.WriteLine("Hello Wash");
                        //    break;
                        //case ConsoleKey.I:
                        //    player = Inara;
                        //    Console.WriteLine("Welcome Inara");
                        //    break;
                        //case ConsoleKey.J:
                        //    player = Jayne;
                        //    Console.WriteLine("Hello Jayne");
                        //    break;
                        //case ConsoleKey.K:
                        //    player = Kaylee;
                        //    Console.WriteLine("Hi Kaylee");
                        //    break;
                        //case ConsoleKey.S:
                        //    player = Simon;
                        //    Console.WriteLine("Welcome Dr.Tam");
                        //    break;
                        //case ConsoleKey.R:
                        //    player = River;
                        //    Console.WriteLine("Hello River");
                        //    break;
                        //case ConsoleKey.B:
                        //    player = Sheppard Book;
                        //    Console.WriteLine("Welcome Sheppard");
                        //    break;
                        default:
                            Console.WriteLine("I'm thinkin you're not burdoned with an overabundance of schooling...choose from the menu."); choose = false;
                            player = mal;
                            break;
                    }//end Character switch
                } while (!choose);
                //if (repeat)//choose && 
                //{
                //Load Scenario and Combat
                do
                {
                    //TODO Seperate loop based on land vs space scenario

                    Console.Clear();//TODONE Fix the clearing issue so you can read the output - Add a "Press Ent to continue"
                    Console.WriteLine(GetScenario());
                    Console.WriteLine($"{player.Name} Hit Points: {player.HitPoints}\t{croanie.Name} Hit Points: {croanie.HitPoints}\t{boss.Name} Hit Points: {boss.HitPoints}");
                    Console.WriteLine($"Score: {score}");
                    //Combat or Run
                    do
                    {
                        Console.WriteLine($"\n\n\tWhat do you do, {player.Name}?\n" +//TODONE Display chosen character name in place of Player name.
                         // $"\t\t R)elease the Cry Baby\n" +
                            $"\n\t\t I)t's time to fight!\n" +
                            $"\t\t G)o for burn\n");
                        ConsoleKey playerChoice = Console.ReadKey(true).Key;
                        switch (playerChoice)
                        {
                            case ConsoleKey.X:
                            case ConsoleKey.E:
                            case ConsoleKey.Escape:
                                Console.WriteLine("As I understand it, it's a bit cold outside. Better put on a suit.");
                                repeat = false;
                                choose = true;
                                keepGoing = false;
                                again = false;
                                break;
                            //case ConsoleKey.R:
                            //This is a distraction tactic to buy time
                            //Console.WriteLine("Cry Baby Cry - Make your mother sigh");
                            //break;
                            case ConsoleKey.I:
                                //TODONE Combat Functionality

                                Combat.Battle(player, croanie);
                                if (croanie.HitPoints <= 0)
                                {
                                    Console.WriteLine($"You killed {croanie.Name}");
                                    score++;
                                }
                                Combat.Battle(player, boss);
                                if (boss.HitPoints <= 0)
                                {
                                    Console.WriteLine($"You killed {boss.Name}");
                                    score++;
                                }
                                if (boss.HitPoints <= 0 && croanie.HitPoints <= 0)
                                {
                                    Console.WriteLine("\n\n\tYou're able to keep flying...\n");
                                    again = false;
                                }
                                Console.WriteLine("\n\n\t\t\t\t\tPress enter to continue...");
                                Console.ReadLine();
                                break;
                            case ConsoleKey.G:
                                //TODO Run away Functionality
                                break;
                            default:
                                Console.WriteLine("I'm thinkin you're not burdoned with an overabundance of schooling...choose from the menu.");
                                break;
                        }//end Action switch

                    } while (again);

                } while (keepGoing && repeat && choose);
                //}
            } while (keepGoing && repeat && choose);
        }//end Main

        //Game Enemies
        private static void GetCroanie(int indexNbr)
        {
            List<Croanie> ListCroanie = new List<Croanie>()
            {
                new Croanie("He's called Two-Fry. ALways makes it quick and clean.", 7, "Too-Fry", 3, 1, 1, 1, 4, 7)
            };

            croanie = ListCroanie[indexNbr];
        }//end Croanies

        private static void GetEnemy(int indexNbr)
        {
            List<Boss> ListBoss = new List<Boss>()
            {
                new Boss("She's just about mayor of this little moon", 5, "Patience", 3, 2, 1, 2, 1, 5)
            };
            boss = ListBoss[indexNbr];
        }//end Enemies

        //Game Scenarios
        private static string GetScenario()
        {
            List<string> scenario = new List<string>()
            {
                "You're landing on Whitefall. It's time to visit an old \"friend\". Let's try to make a deal with Patience...\n\nThe last time you were on Whitefall there was a conflict between you tow but now you're desperate to sell your cargo. You land early and bury the cargo to ensure you get paid before you meet up with Patience and her loyal sidekick Two-Fry. At the rendezvous Patience gives you the money for your cargo and wants to know where it is. Patience smiles broadly as she confirms she knows the location of the buried cargo. Two-Fry who raises his rifle and you realize Patience has no reason to let you live if you tell her where the cargo is. When she looks at Two-Fry you know she's going to tell him to kill you."
            };

            Random rand = new Random();
            int indexNbr = rand.Next(scenario.Count);
            string scenarios = scenario[indexNbr] + "\n";
            GetCroanie(indexNbr);
            GetEnemy(indexNbr);
            return scenarios;
        }//end Scenarios
    }
}


