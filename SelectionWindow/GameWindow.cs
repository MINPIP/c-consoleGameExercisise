using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppx2
{
    class GameWindow : Window
    {
        private Button startButton;
        private Button creditsButton;
        private Button quitButton;
        private TextBlock titleTextBlock;
        private List<Button> buttons = new List<Button>();

        public GameWindow() : base(0, 0, 29, 120, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });
            startButton = new Button(20, 13, 18, 5, "Start");
            startButton.SetActive();
            creditsButton = new Button(50, 13, 18, 5, "Credits");
            quitButton = new Button(80, 13, 18, 5, "Quit");

            buttons.Add(startButton);
            buttons.Add(creditsButton);
            buttons.Add(quitButton);
        }


        public void Render()
        {
            base.Render();
            titleTextBlock.Render();
            startButton.Render();
            creditsButton.Render();
            quitButton.Render();
            Console.SetCursorPosition(0, 0);
        }
       

        public void ChangeButtonRight() {
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].isActive == true)
                {
                    buttons[i].SetNotActive();
                    if (i==2)
                    {
                        buttons[i].SetActive();
                        break;
                    }
                    i++;
                    buttons[i].SetActive();
                    break;
                }
                if (buttons[i].isActive == false)
                {
                    continue;
                }
            }
           Render();
        }

        public void ChangeButtonLeft()
        {
            for (int i = 2; i < buttons.Count; i--)
            {
                if (buttons[i].isActive == true)
                {
                    buttons[i].SetNotActive();
                    if (i == 0)
                    {
                        buttons[i].SetActive();
                        break;
                    }
                    i--;
                    buttons[i].SetActive();
                    break;
                }
                if (buttons[i].isActive == false)
                {
                    continue;
                }
            }
            Render();
        }


        public void RunnActiveButton()

        {
            if (buttons[0].isActive == true)
            {
             Game newGame = new Game();
             newGame.StartGame();   
            }
            else if (buttons[1].isActive == true)
            {
                CreditWindow creds = new CreditWindow();
            }
            else if (buttons[2].isActive == true)
            {
                Environment.Exit(0);
            }
        }
    }
}
