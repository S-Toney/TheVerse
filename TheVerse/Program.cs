using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVerse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            Console.Title = "The 'Verse";
            string playerCharacter = "";
            do
            {
                Console.WriteLine("You're peacefully floating through the 'verse when...\n\n");             
                Console.WriteLine("\tChoose your character: \n" +
                    "\t\tM)al\n" +
                    "\t\tZ)o\u00eb\n" +
                    "\t\tW)ash\n" +
                    "\t\tI)nara\n" +
                    "\t\tJ)ayne\n" +
                    "\t\tK)aylee\n" +
                    "\t\tS)imon\n" +
                    "\t\tR)iver\n" +
                    "\t\tB)ook\n");
                ConsoleKey chooseCharacter = Console.ReadKey(true).Key;
                switch (chooseCharacter)
                {
                    case ConsoleKey.M:
                        //playerCharacter = Mal;
                        break;
                    case ConsoleKey.Z:
                        //playerCharacter = Zo\u00eb;
                        break;
                    case ConsoleKey.W:
                        //playerCharacter = Wash;
                        break;
                    case ConsoleKey.I:
                        //playerCharacter = Inara;
                        break;
                    case ConsoleKey.J:
                        //playerCharacter = Jayne;
                        break;
                    case ConsoleKey.K:
                        //playerCharacter = Kaylee;
                        break;
                    case ConsoleKey.S:
                        //playerCharacter = Simon;
                        break;
                    case ConsoleKey.R:
                        //playerCharacter = River;
                        break;
                    case ConsoleKey.B:
                        //playerCharacter = Sheppard Book;
                        break;
                    default:
                        Console.WriteLine("I'm thinkin you're not burdoned with an overabundance of schooling...choose from the menu.");
                        break;
                }
                Console.Clear();
                //TODO Load character situation based on chooseCharacter
                Console.WriteLine("...situation based on chooseCharacter shows here...");
                Console.WriteLine($"\tPlayer name, what do you do?\n" +
                    $"\t\t R)elease the Cry Baby\n" +
                    $"\t\t I)t's time to fight!\n" +
                    $"\t\t G)o for burn\n");
                ConsoleKey playerChoice = Console.ReadKey(true).Key;
                switch (playerChoice)
                {
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
                }

            } while (keepGoing);

        }
    }
}
