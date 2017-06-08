using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication22
{
    class Paddle
    {
        int x;
        int y;
        int width;
        int speed;
        int height;
        Brush color;

        public object ClientSize { get; private set; }

        public Paddle(int x, int y, int width, int height, int speed, Brush color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.speed = speed;
            this.color = color;
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(color, x, y, width, height);
        }
        public void MoveLeft()
        {
            x -= speed;            
        }
        public void MoveRight()
        {
            x += speed;
        }

        public void Move(int direction)
        {
            //left
            if (direction == 0)
            {
                x -= speed;
            }
            //right
            else if (direction == 1)
            {
                x += speed;
            }
        }
    }
}
