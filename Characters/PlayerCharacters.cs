using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Fighter : Character
    {
        //fields
        private bool _isFighter;

        //props
        public bool IsFighter
        {
            get { return _isFighter; }
            set
            {
                if (true)
                {
                    Attack += 3;
                }
            }
        }

        //ctors
        public Fighter(string description, int hitPoints, bool isFighter, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)
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
        public Fighter()
        {
            Description = "Captain Reynolds - Big Bad Veterin - A man of honor in a din of thieves.";
            HitPoints = 12;
            IsFighter = true;
            MaxHitPoints = 12;
            Name = "Capt. Malcom Reynolds";
            Attack = 3;
            ArmorClass = 1;
            Dodge = 3;
            Block = 1;
            Initiative = 6;
        }
        //methods


    }//end Fighter
    public class Pilot : Character
    {
        //fields
        //TODO add evasion and cry baby
        //props

        //ctors
        public Pilot(string description, int hitPoints, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)
        {
            Description = description;
            HitPoints = hitPoints;

            MaxHitPoints = maxHitPoints;
            Name = name;
            Attack = attack;
            ArmorClass = armorClass;
            Dodge = dodge;
            Block = block;
            Initiative = initiative;
        }

        //methods


    }
}
