using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication22
{
    class Bricks
    {
        int x;
        int y;
        int width;
        int height;
        
        //Constructor
        public Bricks(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        
        //Draw Function
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(Brushes.AliceBlue, new Rectangle(x, y, width, height));
        }
    }
}
