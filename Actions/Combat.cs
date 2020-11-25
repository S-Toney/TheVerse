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
            int nbr1and20;
            //DICE ROLL 
            Random randomNbrGen = new Random();
            nbr1and20 = randomNbrGen.Next(1, 21);

            if (nbr1and20 == 1)
            {
                Console.WriteLine($"\t{ nbr1and20}" +
                    $"\nOH DEAR GOD...{attacking.Name} botched...\n");
            }
            else if (nbr1and20 == 20)
            {
                Console.WriteLine($"WOOOOOOHOOOOOOOOOOO {nbr1and20}! That's a critical hit!");
            }
            else
            {
                Console.WriteLine($"\n{attacking.Name} rolled:\n{nbr1and20}\n");
            }
            if ((nbr1and20 + attacking.Attack) >= (nbr1and20 + defending.ArmorClass))
            {//TODO Utilize num1and20 for damage on crits and botches
                int Damage = attacking.Attack - defending.Block;
                defending.HitPoints -= Damage;
                Console.WriteLine($"{attacking.Name} hit {defending.Name}! {defending.Name} took {Damage} damage.");
            }
            else
            {
                Console.WriteLine($"{attacking.Name} missed.");
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
                else
                {
                    Console.WriteLine($"You killed {croanie}");
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
                    Console.WriteLine($"Looks like you were right about his being a bad idea. You're dead...");
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
            }
        }
    }
}
