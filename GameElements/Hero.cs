using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppx2
{
    class Hero : Unit
    {

        public Hero(int x, int y, string name) : base(x, y, name)
        {
        }

       public Hero myHero { get; set; }

        public void MoveRight()
        {
            x++;
        }

        public void RemoveHero() {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');

        }

        public void MoveLeft()
        {
            x--;
        }
        public void RenderHero() {

            Console.SetCursorPosition(x, y);
            Console.Write('T');
        }

        public int HeroX() {
            return x;
        }

        public int HeroY() {
            return y;
        }
    }
}
