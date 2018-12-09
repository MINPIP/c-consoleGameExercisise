using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppx2
{
    class Button : GuiObject
    {
        

        public bool isActive { get; set; }

        private Frame notActiveFrame;
        private Frame activeFrame;
        private TextLine textLine;
        
 

        public Button(int x, int y, int height, int width, string buttonText): base(x,y,height,width)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x, y, width, height, '#');
          

            //textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);

            textLine = new TextLine(x + 6, y + 2, width - 2, buttonText);
        }

        public void Render()
        {
            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }
            
            textLine.Render();
        }

        public bool GetActive() {
            return isActive;
        }
        public void SetActive() {
            isActive = true;
        }

        public void SetNotActive() {
            isActive = false;
        }

    }
}
