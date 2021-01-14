using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift3
{
    class Monster
    {
        private string name;
      

        public Monster(string name)
        {
            this.name = name;
      
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
       
        

    }
}
