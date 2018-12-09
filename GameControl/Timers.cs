using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppx2
{
    class Timers
    {


        public void EnemyMoveTimer(GameScreen gamescreenas) {

            var EnemyStart = TimeSpan.Zero;
            var EnemyInteraval = TimeSpan.FromSeconds(5);

            var timer = new System.Threading.Timer((e) =>
            {
             
             gamescreenas.ReRenderEnemy();
             gamescreenas.MoveAllEnemiesDown();
             gamescreenas.Render();
            }, null, EnemyStart, EnemyInteraval);
        }
    
        public void AddNewEnemies(GameScreen gam) {

            var Start = TimeSpan.Zero;
            var Interaval = TimeSpan.FromSeconds(25);

            var timer = new System.Threading.Timer((e) =>
            {
                Random rnd = new Random();
                int enemyCount = 0;
                for (int i = 0; i < 10; i++)
                {
                    gam.AddEnemy(new Enemy(10, rnd.Next(1, 49), rnd.Next(1, 10), "striker" + enemyCount));
                    enemyCount++;
                }
                gam.ReRenderEnemy();
                gam.Render();
            }, null, Start, Interaval);
        }


        public void BulletTimer(GameScreen bulletscreen) {

            var Start = TimeSpan.Zero;
            var Interaval = TimeSpan.FromMilliseconds(50);
            var timer = new System.Threading.Timer((e) =>
            {
             bulletscreen.MoveBullets();
            }, null, Start, Interaval);
        }


        public void EnemyTimer(GameScreen Enemies)
        {
            var Start = TimeSpan.Zero;
            var Interaval = TimeSpan.FromSeconds(2);

            var timer = new System.Threading.Timer((e) =>
            {
                Enemies.MoveAllEnemiesDown();
            }, null, Start, Interaval);
        }


        //public void Whiteboard(GameScreen board)
        //{
        //    var Start = TimeSpan.Zero;
        //    var Interaval = TimeSpan.FromSeconds(2);

        //    var timer = new System.Threading.Timer((e) =>
        //    {
        //        board.ReRenderWhiteboard();
        //    }, null, Start, Interaval);
        //}

    }
}
