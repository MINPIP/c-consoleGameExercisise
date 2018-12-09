using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppx2
{
    class Bullet : Unit
    {
        public Bullet(int x, int y, string name) : base(x, y, name)
        {
        }

        public void RenderBullet()
        {
            if (y > 1)
            {
                Console.SetCursorPosition(x, y);
                Console.Write('.');
            }
        }

        public void BulletMoveUp() {
            y--;
        }

        public int GetY() {
            return y;
        }

        public void ReRenderBullet() {

            if (y > 1)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
            }

        }

        

    }
}
