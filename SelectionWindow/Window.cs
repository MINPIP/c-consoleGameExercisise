using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppx2
{
    class Window : GuiObject
    {
        private Frame border;

        public Window(int x, int y, int width, int height, char borderChar) : base (x,y,height,width)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            border = new Frame(x, y, width, height, borderChar);
        }

        public virtual void Render() {
            border.Render();
        }


    }
}
