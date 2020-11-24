using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Pilot : Character
    {
        //fields
        private bool evasion;
        //TODO add evasion and cry baby
        //props
        public bool Evasion { get; set; }
        //ctors
        public Pilot(bool evasion, string description, int hitPoints, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)
        {
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

        //methods


    }
}
