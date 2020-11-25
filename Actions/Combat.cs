using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters;

namespace Actions
{
    public class Combat
    {
        //static 
        //public static int DiceRoll()
        //{

        //    return nbr1and20;
        //}//end Dice Roll

        //ATTACK
        public static void Attack(Character attacking, Character defending)
        {
            int damage = attacking.Attack - defending.Block;
            int nbr1and20;
            //DICE ROLL 
            Random randomNbrGen = new Random();
            nbr1and20 = randomNbrGen.Next(1, 21);

            if (nbr1and20 == 1)
            {
                Console.WriteLine($"OH DEAR GOD...{attacking.Name} botched...\n");
                attacking.HitPoints -= damage;
                Console.WriteLine($"You're a very graceful creature, {attacking.Name}. You hit yourself! \n\t{attacking.Name} took {damage} damage.");
            }
            else if (nbr1and20 == 20)
            {
                Console.WriteLine($"WOOOOOOHOOOOOOOOOOO {nbr1and20}! That's a critical hit!");
                defending.HitPoints -= (damage * 2);
                Console.WriteLine($"{attacking.Name} hit {defending.Name} for double damage! \n\t{defending.Name} took {damage} damage.");
            }
            else
            {
                Console.WriteLine($"\n{attacking.Name} rolled:\n{nbr1and20}\n");
                if ((nbr1and20 + attacking.Attack) >= (nbr1and20 + defending.ArmorClass))
                {//TODONE Utilize num1and20 for damage on crits and botches
                    defending.HitPoints -= damage;
                    Console.WriteLine($"{attacking.Name} hit {defending.Name}! \n\t{defending.Name} took {damage} damage.");
                }
                else
                {
                    Console.WriteLine($"{attacking.Name} missed.");
                }
            }
        }//end Attack

        //BATTLE
        public static void Battle(PlayerCharacter player, Croanie croanie)
        {

            if (player.Initiative >= croanie.Initiative)
            {
                Attack(player, croanie);
                if (croanie.HitPoints > 0)
                {
                    Attack(croanie, player);
                }
            }
            else
            {
                Attack(croanie, player);
                if (player.HitPoints > 0)
                {
                    Attack(player, croanie);
                }
                else
                {
                    Console.WriteLine($"Looks like you were right about his being a bad idea. {croanie.Name} killed you...");
                }
            }
        }
        public static void Battle(PlayerCharacter player, Boss boss)
        {
            if (player.Initiative >= boss.Initiative)
            {
                Attack(player, boss);
                if (boss.HitPoints > 0)
                {
                    Attack(boss, player);
                }
            }
            else
            {
                Attack(boss, player);
                if (player.HitPoints > 0)
                {
                    Attack(player, boss);
                }
                else
                {
                    Console.WriteLine($"Looks like you were right about his being a bad idea. {boss.Name} killed you...");
                }
            }
        }
    }
}
