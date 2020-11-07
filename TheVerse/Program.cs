using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters;

namespace TheVerse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            bool repeat = true;
            bool choose = true;
            Mal mal = new Mal("Captain Reynolds- Big Bad Veterin - A man of honor in a din of thieves", 12, true, 12, "Capt. Malcom Reynolds", 3, 1, 3, 1, 6);
            Zoe zoe = new Zoe("First Mate", 12, true, 12, "Zo\u00eb", 3, 2, 4, 2, 6);
            Patience patience = new Patience();
            Console.Title = "The 'Verse";
            Console.WriteLine("Press escape to exit.\n\n\n" +
                "You're peacefully floating through the 'verse when...\n\n");
            //string playerCharacter = "";
            do
            {
                do
                {
                    Console.WriteLine("\tChoose your character: \n" +
                        "\t\tM)al\n" +
                        "\t\tZ)o\u00eb\n");
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
                        //  case ConsoleKey.E:
                        //  Console.WriteLine("As I understand it, it's a bit cold outside. Better put on a suit.");
                        //  repeat = false;
                        // break;
                        default:
                            Console.WriteLine("I'm thinkin you're not burdoned with an overabundance of schooling...choose from the menu."); choose = false;
                            break;
                    }//end Character switch
                } while (!choose);
                do
                {
                    Console.Clear();
                    //TODO Load character situation based on chooseCharacter
                    Console.WriteLine("...situation based on chooseCharacter shows here...");
                    Console.WriteLine($"\tPlayer name, what do you do?\n" +
                        // $"\t\t R)elease the Cry Baby\n" +
                        $"\t\t I)t's time to fight!\n" +
                        $"\t\t G)o for burn\n");
                    ConsoleKey playerChoice = Console.ReadKey(true).Key;
                    switch (playerChoice)
                    {
                        case ConsoleKey.Escape:
                            choose = true;
                            repeat = false;
                            keepGoing = false;
                            break;
                        case ConsoleKey.R:
                            //This is a distraction tactic to buy time
                            break;
                        case ConsoleKey.I:
                            //Combat
                            break;
                        case ConsoleKey.G:
                            //Run away
                            break;
                        default:
                            Console.WriteLine("I'm thinkin you're not burdoned with an overabundance of schooling...choose from the menu.");
                            break;
                    }//end Action switch
                } while (keepGoing && repeat && choose);
            } while (keepGoing);

        }
    }
}
