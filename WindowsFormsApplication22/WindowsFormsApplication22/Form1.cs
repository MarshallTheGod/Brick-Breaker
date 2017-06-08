using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        Graphics GFX;
        Bitmap bitmap;
        Ball b;
        Paddle p;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            bitmap = new Bitmap(canvas.Width, canvas.Height);
            GFX = Graphics.FromImage(bitmap);
            b = new Ball(10, 10, 10, 3);
            int x = (ClientSize.Width / 2) - (int)(0.5 * Width);
            p = new Paddle(x, (ClientSize.Height - 10), (ClientSize.Width / 10), 10, 5, Brushes.Green);
            canvas.Image = bitmap;
           
        }

        private void Ball()
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b.move(ClientSize.Width, ClientSize.Height);
            GFX.Clear(Color.Red);
            b.Draw(GFX);
            p.Draw(GFX);
            
            canvas.Image = bitmap;
        }

        private void canvas_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                p.Move(0);
            }
            if (e.KeyCode == Keys.D)
            {
                p.Move(1);
            }
        }
    }
}
