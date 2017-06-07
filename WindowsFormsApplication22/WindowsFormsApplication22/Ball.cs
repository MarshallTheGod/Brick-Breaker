using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication22
{
    class Ball
    {
        int x;
        int y;
        int diameter;
        int speedX;
        int speedY;

        // Constructor
        public Ball(int x, int y, int diameter, int speed)
        {
            this.x = x;
            this.y = y;
            this.diameter = diameter;
            speedX = speed;
            speedY = speed;
        }

        // Draw function
        public void Draw (Graphics gfx)
        {
            gfx.FillEllipse(Brushes.Green, new Rectangle(x, y, diameter, diameter));
        }

        public void move(int Width, int Height)
        {
            x = x + speedX;
            y = y + speedY;
            if (x < 0)
            {
                speedX = Math.Abs(speedX);
            }
            else if(x + diameter > Width)
            {
                speedX = -Math.Abs(speedX);
            }
            if (y < 0)
            {
                speedY = Math.Abs(speedY);
            }
            if(y + diameter >Height)
            {
                speedY = -Math.Abs(speedY);
            }
        }
        
    }
}
