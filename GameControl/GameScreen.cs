using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainAppx2
{
    class GameScreen
    {
        private int width; 
        private int height;  
        private Hero hero;    

        private List<Enemy> enemies = new List<Enemy>();
        private List<Bullet> bullets = new List<Bullet>();

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

//Deal with Whiteboard

        public void UpdateBulletCount(WhiteBoard bordas) {

            ConsoleKeyInfo pressedChar = Console.ReadKey(true);
            if (pressedChar.Key == ConsoleKey.Spacebar)
            {
                bordas.UpdateBuletsFired();
            }
        }

        public void ReRenderWhiteboard(WhiteBoard bordas)
        {
            var Start = TimeSpan.Zero;
            var Interaval = TimeSpan.FromMilliseconds(500);

            var timer = new System.Threading.Timer((e) =>
            {
                bordas.WhiteBoardREnder();
            }, null, Start, Interaval);

        }

 //Deal with Killing Enemies || neveikia

        internal void KillEnemy(WhiteBoard bordas)
        {
            foreach (Bullet bullet in bullets)
            {
                foreach (Enemy enemy in enemies)
                {
                    if (bullet.y == enemy.y && bullet.x == enemy.x)
                    {
                        enemies.Remove(enemy);
                        bordas.UpdateDeadEnemies();
                        bordas.UpdateScore();
                       // bullets.Remove(bullets[0]);
                        break;
                    }
                }
            }
        }


 //Dealing with bullets

        internal void AddBullet(Bullet bulleta)
        {
            bullets.Add(bulleta);
        }

        public void RenderBullet() {
            foreach (Bullet bullet in bullets)
            {
                bullet.RenderBullet();
            }
        }

        public void ReRenderbullet() {
            foreach (Bullet bullet in bullets)
            {
                bullet.ReRenderBullet();
            }

        }
 
        public void MoveBullets() {
          
              foreach (Bullet bullet in bullets.ToList())
            {
                    bullet.ReRenderBullet();
                    bullet.BulletMoveUp();
                    bullet.RenderBullet();            
            }
        }

        public void RemoveBullet() {

            if (bullets.Count > 0)
            {
                for (int i = 0; i < bullets.Count; i++)
                {
                    if (bullets[0].GetY() == 0)
                    {
                        bullets.Remove(bullets[0]);
                    }
                }
            }
        }

//Dealing with Hero

        public Hero GetHero()
        {
            return hero;
        }

        public void SetHero(Hero hero)
        {
            this.hero=hero;
        }

//Deal with Enemy

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public Enemy getEnemyById(int id)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null;
        }
 
        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemies)
            {
                
                enemy.MoveDown();
            }
        }

        public void Render()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.RenderEnemy();
            }
        }


        public void ReRenderEnemy()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.ReRenderEnemy();
            }
        }
    }
}
