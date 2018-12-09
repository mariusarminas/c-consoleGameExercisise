using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis
{
    class Enemy: Unit 
    {
        private int id;
        private bool isDead;
        


        public Enemy(int id, int x, int y, string name): base (x, y, name, 'x') 
        {
            this.id = id;
            
        }

        public void MoveDown()
        {
            y++;
        }

        public int GetY()
        {
            return y;
        }

        public bool IsDead()
        {
            return isDead;
        }

        public void SetIsDead(bool dead)
        {
            this.isDead = dead;
        }

        public int GetId()
        {
            return id;
        }
    }
}