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
        public Fighter(bool isPlayer, string description, int hitPoints, bool isFighter, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)
        {
            IsPlayer = isPlayer;
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
            IsPlayer = true;
            Description = "Captain";
            HitPoints = 12;
            IsFighter = true;
            MaxHitPoints = 12;
            Name = "Captain";
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
        private bool evasion;
        //TODO add evasion and cry baby
        //props
        public bool Evasion { get; set; }
        //ctors
        public Pilot(bool isPlayer, bool evasion, string description, int hitPoints, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)
        {
            IsPlayer = isPlayer;
            Evasion = evasion;
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
        public Pilot()
        {
            IsPlayer = true;
            Evasion = true;
            Description = "Pilot";
            HitPoints = 12;
            MaxHitPoints = 12;
            Name = "Pilot";
            Attack = 2;
            ArmorClass = 1;
            Dodge = 3;
            Block = 1;
            Initiative = 6;
        }

        //methods


    }
}
