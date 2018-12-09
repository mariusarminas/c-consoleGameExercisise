using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis.Gui
{
    class MainApp
    {
        static void Main()
        {
            GuiController guiController = new GuiController();
            guiController.ShowMenu();

            /*
            Console.CursorVisible = false;
            GameWindow gameWindow = new GameWindow();
            CreditWindow creditWindow = new CreditWindow();
            */
            // Console.ReadKey();
        }

       
    }
}
