using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Mal : Character
    {
        //fields
        //props

        //ctors
        public Mal(string description, int hitPoints, bool isFighter, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)
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
        public Mal()
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


    }//end Mal
    public class Zoe : Character
    {
        //fields
        //props

        //ctors
        public Zoe(string description, int hitPoints, bool isFighter, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)
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
        public Zoe()
        {
            Description = "First Mate";
            HitPoints = 12;
            IsFighter = true;
            MaxHitPoints = 12;
            Name = "Zo\u00eb";
            Attack = 3;
            ArmorClass = 1;
            Dodge = 3;
            Block = 1;
            Initiative = 6;
        }
        //methods


    }
}
