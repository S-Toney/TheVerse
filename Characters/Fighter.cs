using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Fighter : PlayerCharacter
    {
        //fields
       // private bool _isFighter = true;

        //props
        //public bool IsFighter
        //{
        //    get { return _isFighter; }
        //    set
        //    {
        //        if (true)
        //        {
        //            Attack += 3;
        //        }
        //    }
        //}
        public bool IsFighter { get; set; }

        //ctors
        public Fighter(string description, int maxHitPoints, bool isFighter, int hitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative)/* : base(description, maxHitPoints, hitPoints, name, attack, armorClass, dodge, block, initiative)*/
        {
            Description = description;
            MaxHitPoints = maxHitPoints;
            IsFighter = isFighter;
            HitPoints = hitPoints;
            Name = name;
            Attack = attack;
            ArmorClass = armorClass;
            Dodge = dodge;
            Block = block;
            Initiative = initiative;
        }

        //methods
        public override int CalcAttack()
        {
            Attack += 3;
            return Attack;
        }

    }//end Fighter
}
