using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis.Gui
{
    class GameController
    {
        public void StartGame()
        {
            int width = 20;
            int height = 20;
            // init game
            GameScreen myGame = new GameScreen(width, height);

            // fill game with game data.
            myGame.SetHero(new Hero(width / 2, height - 2, "HERO", width));

            Random rnd = new Random();           
           

            // render loop
            bool needToRender = true;
            Console.CursorVisible = false;

            int frameCount = 0;

            do
            {
                // isvalom ekrana
                Console.Clear();
                frameCount++;

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            myGame.GetHero().MoveRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.GetHero().MoveLeft();
                            break;
                    }
                }

                if (frameCount % 7 == 0)
                {
                    myGame.MoveAllEnemiesDown();
                    
                }
                if (frameCount % 15 == 0)
                {
                    myGame.AddEnemy();
                }
                myGame.Render();


                System.Threading.Thread.Sleep(100);
            } while (needToRender);
        }
    }
}
