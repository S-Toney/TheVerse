using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Boss : Character
    {
        //fields  TODO Add cronies instead of creating TooFry seperately?

        //props

        //ctors
        public Boss(bool isPlayer, string description, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative, int hitPoints)
        {
            IsPlayer = isPlayer;
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
        public Boss()
        {
            IsPlayer = false;
            Description = "She's not involved in land wars anymore. She's basically Mayor of this little moon.";            
            MaxHitPoints = 10;
            Name = "Patience";
            Attack = 2;
            ArmorClass = 1;
            Dodge = 4;
            Block = 2;
            Initiative = 5;
            HitPoints = 10;
        }
        //methods


    }//end Boss

    public class Croanie : Character
    {
        //fields  TODO Add cronies instead of creating TooFry seperately?

        //props

        //ctors
        public Croanie(bool isPlayer, string description, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative, int hitPoints)
        {
            IsPlayer = IsPlayer;
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
            IsPlayer = false;
            Description = "The boy must be your best shot to carry a rifle like that.";
            MaxHitPoints = 10;
            Name = "TooFry";
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
