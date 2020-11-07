using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Patience : Character
    {
        //fields
        //props

        //ctors
        public Patience(string description, int hitPoints, bool isFighter, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)
        {
            Description = description;
            HitPoints = hitPoints;
            IsFighter = isFighter;
            MaxHitPoints = maxHitPoints;
            Name = name;
            Attack = attack;
            ArmorClass = armorClass;
            Dodge = dodge;
            Block = block;
            Initiative = initiative;

        }
        public Patience()
        {
            Description = "She's not involved in land wars anymore. She's basically Mayor of this little moon.";
            HitPoints = 10;
            IsFighter = false;
            MaxHitPoints = 10;
            Name = "Patience";
            Attack = 2;
            ArmorClass = 1;
            Dodge = 4;
            Block = 2;
            Initiative = 5;
        }
        //methods


    }//end Patience
}
