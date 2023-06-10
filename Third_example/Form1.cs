using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Third_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool b = false; 
        private void Drawing(Graphics g,int N, int x, int y,int width,int height)
        {
            if(N!=0)
            {
                g.DrawRectangle(new Pen(Color.Blue,2),x,y,width,height);
                N--;
                height += 50;
                width += 50;
                x+= width+10;
                Drawing(g, N, x, y, width, height);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Drawing(g,7,20,20,10,10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b = false;
        }
    }
}
