using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift3
{
    class Player
    {
        static int[] expLimits = new int[] { 0, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
        private string name;
        private int level = 1;
        private int exp = 0;
        private int hp = 100;

        public Player(string name)
        {
            this.name = name;
            MaxExp = expLimits[Level];
           
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

        public int MaxExp { get; set; }

        public void LevelUp()
        {
            Exp -= MaxExp;
            Level++;
            MaxExp = expLimits[Level];
        }

        










    }
   



}



