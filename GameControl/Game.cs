using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace MainAppx2
{
    class Game
    {

       

        public void StartGame()
        {
            
            GameScreen myGame = new GameScreen(50, 50);
            myGame.SetHero(new Hero(10, 20, "SOLO"));
            //Random rnd = new Random();
            Frame gameborder = new Frame(0, 0, 25, 50, '#');
            Frame WhiteBoard = new Frame(55, 1, 15, 25, '0');
            WhiteBoard WhiteBoardas = new WhiteBoard();
            Timers Timeriukas = new Timers();
           // Enemy secondEnemy = myGame.getEnemyById(1);
            bool needToRender = true;


            Console.Clear();
            gameborder.Render();
            myGame.Render();
            myGame.GetHero().RenderHero();
            myGame.RenderBullet();
            //WhiteBoardas.fr.Render();
            //WhiteBoardas.RenderText();
            //WhiteBoardas.WhiteBoardREnder();
            //myGame.MoveBullets();
            //myGame.KillEnemy(WhiteBoardas);


            myGame.ReRenderWhiteboard(WhiteBoardas);
          
            Timeriukas.AddNewEnemies(myGame);
            Timeriukas.BulletTimer(myGame);
            Timeriukas.EnemyMoveTimer(myGame);

            do
            {
                myGame.KillEnemy(WhiteBoardas);
                myGame.RemoveBullet();

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            if (myGame.GetHero().HeroX() != 48)
                            {
                                myGame.GetHero().RemoveHero();
                                myGame.GetHero().MoveRight();
                                myGame.GetHero().RenderHero();
                                break;
                            }
                            break;
                           
                        case ConsoleKey.LeftArrow:
                            if (myGame.GetHero().HeroX() != 1)
                            {
                                myGame.GetHero().RemoveHero();
                                myGame.GetHero().MoveLeft();
                                myGame.GetHero().RenderHero();
                                break;
                            }
                            break;
                               
                        case ConsoleKey.Spacebar:
                            myGame.AddBullet(new Bullet(myGame.GetHero().HeroX(), myGame.GetHero().HeroY()-1, ""));
                            myGame.MoveBullets();
                            WhiteBoardas.UpdateBuletsFired();
                            myGame.ReRenderbullet();
                            myGame.RenderBullet();
                            WhiteBoardas.UpdateBuletsFired();
                            break;
                    }
                }
            } while (needToRender);
        }

    }
}
