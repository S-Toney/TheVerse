﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters;

namespace Actions
{
    public class Combat
    {
        static int nbr1and20;
        public static int DiceRoll()
        {
            Random rand = new Random();
            //Dice Roll 
            Random randomNbrGen = new Random();
            nbr1and20 = randomNbrGen.Next(1, 21);

            if (nbr1and20 == 1)
            {
                Console.WriteLine("\t" + nbr1and20 +
                    "\nOH DEAR GOD...you botched...\n");
            }
            else if (nbr1and20 == 20)
            {
                Console.WriteLine("WOOOOOOHOOOOOOOOOOO" + nbr1and20 + "! That's a critical hit!");
            }
            else
            {
                Console.WriteLine("\nA You rolled:\n{0}\n", nbr1and20);
            }
            return nbr1and20;
        }//end Dice Roll

        public static void Attack(Character attacking, Character defending)
        {
            if (attacking.IsPlayer)
            {

            } 
            else if (defending.IsPlayer)
            {

            }



        }
    }
}
