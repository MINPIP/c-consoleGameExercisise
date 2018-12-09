using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace MainAppx2
{
    class Enemy : Unit
    {
        private int id;

        public Enemy(int id, int x, int y, string name) : base(x, y, name)
        {
            this.id = id;
        }
       
        public void MoveDown()
        { 
            y++;        
        }

        public int GetId()
        {
            return id;
        }

        public void RenderEnemy() {
            Console.SetCursorPosition(x, y);
            Console.Write ('W');

        }

        public void ReRenderEnemy()
        {

            if (y > 1)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
            }

        }


    }
}
