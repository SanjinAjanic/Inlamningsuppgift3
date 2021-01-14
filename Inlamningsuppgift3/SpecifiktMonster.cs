using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift3
{
    class SpecifiktMonster: Monster
    {
        private int hp;
        private int exp;

    

        public SpecifiktMonster(int hp, int exp, string name) : base(name)
        {
            this.hp = hp;
            this.exp = exp;
        }

        public int Hp
        {
            get
            {
                return hp;       
                
            }
            set
            {
                hp = value;
            }
        }
        public int Exp
        {
            get
            {
                return exp;
            }
            set
            {
                exp = value;
            }
        }


        

    }
}
