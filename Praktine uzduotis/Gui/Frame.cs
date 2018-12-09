﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis.Gui
{
    class Frame : GuiObject
    {
        protected char _renderChar;

        public Frame(int x, int y, int width, int height, char renderChar): base(x, y, width, height)
        {
            _renderChar = renderChar;
        }
        public override void Render()
        {
            for (int i = 0; i < _height; i++)
            {
                Console.SetCursorPosition(_x, _y + i);
                if (i == 0 || i == _height - 1)
                {
                    for (int j = 0; j < _width; j++)
                    {
                        Console.Write(_renderChar);
                    }
                }
                else
                {
                    Console.Write(_renderChar);
                    for (int j = 0; j < _width - 2; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(_renderChar);
                }
            }
        }
    }
}
