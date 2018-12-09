using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppx2
{
    class WhiteBoard
    {
        public int Score { get; set; } = 0;
        public int BulletsFired { get; set; } = 0;
        public int EnemysDead { get; set; } = 0;
        public int Lives { get; set; } = 3;
        public string GameOver { get; set; } = "GAME OVER";
        public List<String> WhiteboardText = new List<string>();


        //public Frame fr = new Frame(55, 1, 11, 25, '0');
        //public List<String> temp = new List<string>();
        //private TextBlock creditTextBlock;
        //private TextBlock creditTextBlockTemp;


        public WhiteBoard()
        {
            this.Score = Score;
            this.BulletsFired = BulletsFired;
            this.EnemysDead = EnemysDead;
            this.Lives = Lives;
            this.GameOver = GameOver;
            WhiteboardText.Add("Score: " + Score + " " + "Bullets Fired: " + BulletsFired + " " + "Enemys Dead: " + EnemysDead + " Lives " + Lives);


            //WhiteboardText.Add("");
            //WhiteboardText.Add(" Score:  " + Score);
            //WhiteboardText.Add("");
            //WhiteboardText.Add(" Bullets Fired:  " + BulletsFired);
            //WhiteboardText.Add("");
            //WhiteboardText.Add(" Enemys Dead:  " + EnemysDead);
            //WhiteboardText.Add("");
            //WhiteboardText.Add(" Lives:  " + Lives);
            //WhiteboardText.Add("");
            //creditTextBlock = new TextBlock(1, 25, 15, WhiteboardText);
            //creditTextBlockTemp = new TextBlock(1, 25, 15, temp);
            //temp.Add(" ");
        }


        public void UpdateScore() {
            Score += 100;
            WhiteboardText.Clear();
            WhiteboardText.Add("Score: " + Score + " " + "Bullets Fired: " + BulletsFired + " " + "Enemys Dead: " + EnemysDead + " Lives " + Lives);
        }

        public void UpdateBuletsFired() {
            BulletsFired++;
            WhiteboardText.Clear();
            WhiteboardText.Add("Score: " + Score + " " + "Bullets Fired: " + BulletsFired + " " + "Enemys Dead: " + EnemysDead + " Lives " + Lives);
        }

        public void UpdateDeadEnemies() {
            EnemysDead++;
            WhiteboardText.Clear();
            WhiteboardText.Add("Score: " + Score + " " + "Bullets Fired: " + BulletsFired + " " + "Enemys Dead: " + EnemysDead + " Lives " + Lives);

        }

        //public void RenderText() {
        //    creditTextBlock.Render();
        //
        //public void Rerendertext()
        //{
        //    creditTextBlockTemp.Render();
        //}

        public void WhiteBoardREnder() {
      
            foreach (var item in WhiteboardText.ToList())
            {
                Console.SetCursorPosition(1, 25);                
                Console.SetCursorPosition(1, 25);                
                Console.SetCursorPosition(1, 25);                
                Console.SetCursorPosition(1, 25);                
                Console.Write(item);
            }
        }
    }
}
