using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Croanie : Character
    {
        //fields  TODO Add cronies instead of creating TooFry seperately?

        //props

        //ctors
        public Croanie(string description, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative, int hitPoints)
        {
            Description = description;
            MaxHitPoints = maxHitPoints;
            Name = name;
            Attack = attack;
            ArmorClass = armorClass;
            Dodge = dodge;
            Block = block;
            Initiative = initiative;
            HitPoints = hitPoints;
        }
        public Croanie()
        {
            Description = "The boy must be your best shot to carry a rifle like that.";
            MaxHitPoints = 10;
            Name = "Croanie";
            Attack = 2;
            ArmorClass = 1;
            Dodge = 4;
            Block = 2;
            Initiative = 5;
            HitPoints = 10;
        }
        //methods


    }//end Croanie
}
