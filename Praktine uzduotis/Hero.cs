using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis
{
    class Hero : Unit
    {
        int width;    

        public Hero(int x, int y, string name, int width): base (x, y, name, '@')
        {
            this.width = width;          
        }
    
        public void MoveRight()
        {
            x++;

            if (x > width - 2)
                x = width - 2;
        }

        public void MoveLeft()
        {
            x--;
            if (x < 1)
                x = 1;            
        }

       
    }

}
