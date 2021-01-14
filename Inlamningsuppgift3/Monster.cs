using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift3
{
    class Monster
    {
        private string name;
        private int level;
        private int hp;

        public Monster(string name, int level, int hp)
        {
            this.name = name;
            this.level = level;
            this.hp = hp;
        }

            

        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
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

    }
}
