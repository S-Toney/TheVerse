using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters;
using Actions;

namespace TheVerse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            bool repeat = true;
            bool choose = true;
            Fighter mal = new Fighter("Captain Reynolds- Big Bad Veterin - A man of honor in a din of thieves", 12, true, 12, "Capt. Malcom Reynolds", 3, 1, 3, 1, 6);
            Fighter zoe = new Fighter("First Mate", 12, true, 12, "Zo\u00eb", 3, 2, 4, 2, 6);
           // Patience patience = new Patience();
           // Patience tooFry = new Patience("That boy must be your best shot to carry a rifle like that. Nice hat.", 7, 7, "Too-Fry", 3, 1, 1, 1, 4);
            Console.Title = "The 'Verse";
            Console.WriteLine("Press escape to exit.\n\n\n" +
                "You're peacefully floating through the 'verse when...\n\n");
            //string playerCharacter = "";
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
                            Console.WriteLine("As I understand it, it's a bit cold outside. Better put on a suit.");
                            repeat = false;
                            choose = true;
                            repeat = false;
                            keepGoing = false;
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Hello Captain.");
                            Console.ReadLine();
                            choose = true;
                            break;
                        case ConsoleKey.Z:
                            //playerCharacter = Zo\u00eb;
                            Console.WriteLine("Hello Zo\u00eb");
                            Console.ReadLine();
                            choose = true;
                            break;
                        //case ConsoleKey.W:
                        //playerCharacter = Wash;
                        // Console.WriteLine("Hello Wash");
                        //break;
                        // case ConsoleKey.I:
                        //playerCharacter = Inara;
                        // Console.WriteLine("Welcome Inara");
                        // break;
                        // case ConsoleKey.J:
                        //playerCharacter = Jayne;
                        // Console.WriteLine("Hello Jayne");
                        //  break;
                        // case ConsoleKey.K:
                        //playerCharacter = Kaylee;
                        //   Console.WriteLine("Hi Kaylee");
                        //   break;
                        // case ConsoleKey.S:
                        //playerCharacter = Simon;
                        //   Console.WriteLine("Welcome Dr.Tam");
                        //   break;
                        //  case ConsoleKey.R:
                        //playerCharacter = River;
                        //    Console.WriteLine("Hello River");
                        //    break;
                        //   case ConsoleKey.B:
                        //playerCharacter = Sheppard Book;
                        //   Console.WriteLine("Welcome Sheppard");
                        //   break;
                        default:
                            Console.WriteLine("I'm thinkin you're not burdoned with an overabundance of schooling...choose from the menu."); choose = false;
                            break;
                    }//end Character switch
                } while (!choose);
                if (choose && repeat)
                {
                    do
                    {
                        //TODO Seperate loop based on land vs space scenario


                        Console.Clear();
                        //TODO Load character situation based on chooseCharacter
                        Console.WriteLine(GetScenario());
                        Console.WriteLine($"\tWhat do you do, Player name?\n" +//TODO Display chosen character name in place of Player name.
                                                                               // $"\t\t R)elease the Cry Baby\n" +
                            $"\t\t I)t's time to fight!\n" +
                            $"\t\t G)o for burn\n");
                        ConsoleKey playerChoice = Console.ReadKey(true).Key;
                        switch (playerChoice)
                        {
                            case ConsoleKey.E:
                            case ConsoleKey.Escape:
                                Console.WriteLine("As I understand it, it's a bit cold outside. Better put on a suit.");
                                repeat = false;
                                choose = true;
                                repeat = false;
                                keepGoing = false;
                                break;
                            //case ConsoleKey.R:
                            //This is a distraction tactic to buy time
                            //break;
                            case ConsoleKey.I:
                                //TODO Combat Functionality
                                break;
                            case ConsoleKey.G:
                                //TODO Run away Functionality
                                break;
                            default:
                                Console.WriteLine("I'm thinkin you're not burdoned with an overabundance of schooling...choose from the menu.");
                                break;
                        }//end Action switch

                    } while (keepGoing && repeat && choose);
                }
            } while (keepGoing && repeat && choose);
        }//end Main

        //Game Scenarios
        private static string GetScenario()
        {
            List<string> scenario = new List<string>()
            {
                "You're landing on Whitefall. It's time to visit an old \"friend\". Let's try to make a deal with Patience...\n\nThe last time you were on Whitefall there was a conflict between you tow but now you're desperate to sell your cargo. You land early and bury the cargo to ensure you get paid before you meet up with Patience and her loyal sidekick Two-Fry. At the rendezvous Patience gives you the money for your cargo and wants to know where it is. Patience smiles broadly as she confirms she knows the location of the buried cargo. Two-Fry who raises his rifle and you realize Patience has no reason to let you live if you tell her where the cargo is. When she looks at Two-Fry you know she's going to tell him to kill you."
            };
            Random rand = new Random();
            int indexNbr = rand.Next(scenario.Count);
            string scenarios = "You're able to keep flying...\n" + scenario[indexNbr] + "\n";//TODO shows up in the first scenario
            return scenarios;
        }//end Game Scenarios
    }
}


