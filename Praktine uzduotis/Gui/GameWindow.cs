using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis.Gui
{
    class GameWindow : Window
    {
        private Button[] buttons;
        private int activeButton;

        private TextBlock titleTextBlock;


        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Praktika zaidimas", "Marius Arminas kuryba!", "Made in Vilnius Coding School!" });

            buttons = new Button[3];
            buttons[0] = new Button(20, 13, 18, 5, "Start");
            buttons[1] = new Button(50, 13, 18, 5, "Credits");
            buttons[2] = new Button(80, 13, 18, 5, "Quit");
        }

        public void GoLeft()
        {
            activeButton = activeButton - 1;
            if (activeButton < 0)
                activeButton = 0;
        }

        public void GoRight()
        {
            activeButton = activeButton + 1;
            if (activeButton > 2)
                activeButton = 2;
        }

        public int GetActiveButton()
        {
            return activeButton;
        }

        private void SetActiveButton()
        {
            for(int i = 0; i < buttons.Length; i++)
            {
                if (i == activeButton)
                {
                    buttons[i].SetActive(true);
                }
                else
                {
                    buttons[i].SetActive(false);
                }
            }
        }

        public void Render()
        {
            base.Render();

            titleTextBlock.Render();

            SetActiveButton();

            foreach (Button button in buttons)
                button.Render();            

            Console.SetCursorPosition(0, 0);
        }

    }
}

