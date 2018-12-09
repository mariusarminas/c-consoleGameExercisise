using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis.Gui
{
    abstract class GuiObject
    {
        protected int _x;
        protected int _y;
        protected int _height;
        protected int _width;

        public GuiObject(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }
        public abstract void Render();        
    }
}
