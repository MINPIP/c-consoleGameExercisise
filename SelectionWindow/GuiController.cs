using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAppx2
{
    class GuiController
    {
        private GameWindow game;
        //private CreditWindow credits;
        private Game main;

        public GuiController() {
           
            game = new GameWindow();
            main = new Game();
        }

        public void ShowMenu()
        {
            game.Render();
            bool Continue = true;
            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Enter:
                        game.RunnActiveButton();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        Continue = false;
                        break;
                    case ConsoleKey.RightArrow:
                        game.ChangeButtonRight(); 
                        break;
                    case ConsoleKey.LeftArrow:
                        game.ChangeButtonLeft();
                        break;
                }
            } while (Continue);
        }
    }
}
