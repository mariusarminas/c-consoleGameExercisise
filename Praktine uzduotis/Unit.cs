using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis
{
    class Unit
    {
        protected int x;
        protected int y;
        protected string name;
        char character;

        public Unit(int x, int y, string name, char character)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.character = character;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" Hero {name} is at {x}x{y}");
        }

        public void Render()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(character);
        }
    }
}
