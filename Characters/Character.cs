using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public abstract class Character
    {
        //fields
        private int _hitPoints;
        //props
        public string Description { get; set; }
        public int MaxHitPoints { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int ArmorClass { get; set; }
        public int Dodge { get; set; }
        public int Block { get; set; }
        public int Initiative { get; set; }
        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                if (value <= MaxHitPoints)
                {
                    _hitPoints = value;
                }
                else
                {
                    _hitPoints = MaxHitPoints;
                }
            }
        }

        //ctors - N/A

        //methods

        public virtual int CalcAttack()
        {
            return Attack;
        }
        public virtual int CalcArmorClass()
        {
            return ArmorClass;
        }
        public virtual int CalcDodge()
        {
            return Dodge;
        }
        public virtual int CalcBlock()
        {
            return Block;
        }
        public virtual int CalcInitiative()
        {
            return Initiative;
        }

    }
}
