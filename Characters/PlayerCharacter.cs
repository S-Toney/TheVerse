using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class PlayerCharacter : Character
    {
        //fields


        //props
       

        public PlayerCharacter( string description, int hitPoints, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)
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
        public PlayerCharacter()
        {

        }
    }   
   
}
