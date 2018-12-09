using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis.Gui
{
    class GuiController
    {
        GameWindow gameWindow;
        CreditWindow creditWindow;

        GameController gameController;

        public GuiController()
        {
            gameWindow = new GameWindow();
            creditWindow = new CreditWindow();
            gameController = new GameController();
        }

        public void ShowCredit()
        {
            Console.Clear();
            creditWindow.Render();

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

               if (key == ConsoleKey.Enter || key == ConsoleKey.Escape)
               {
                    return;
               }                
            }

        }

        public void ShowMenu()
        {
            Console.Clear();
            gameWindow.Render();

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.LeftArrow)
                {
                    gameWindow.GoLeft();

                }
                else if (key == ConsoleKey.RightArrow)
                {
                    gameWindow.GoRight();
                }
                else if (key == ConsoleKey.Enter)
                {
                    int activeButton = gameWindow.GetActiveButton();
                    if (activeButton == 0) // start game
                    {
                        gameController.StartGame();
                    }
                    else if (activeButton == 1) // credits
                    {
                        ShowCredit();
                    }
                    else if (activeButton == 2) // exit
                    {
                        return;
                    }
                }

                Console.Clear();
                gameWindow.Render();
            }
        }        
    }
}
