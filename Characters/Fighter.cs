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
        private readonly bool _isFighter = true;

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
        public Fighter(string description, int hitPoints, bool isFighter, int maxHitPoints, string name, int attack, int armorClass, int dodge, int block, int initiative) : base(description, hitPoints, maxHitPoints, name, attack, armorClass, dodge, block, initiative)
        {
            IsFighter = isFighter;
        }

        //methods


    }//end Fighter
}
