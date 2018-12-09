﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis.Gui
{
    class TextLine : GuiObject
    {
        protected string _data;

        public TextLine(int x, int y, int width, string data) : base(x, y, width, 1)
        {
            _data = data;


        }

        public override void Render()
        {
            Console.SetCursorPosition(_x, _y);
            if (_width > _data.Length)
            {
                int offset = (_width - _data.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }

            Console.Write(_data);
        }
    }
}
