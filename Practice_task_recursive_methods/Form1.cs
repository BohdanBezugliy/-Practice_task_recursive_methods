using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_task_recursive_methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public uint number = 0;
        class MyPoint
        {
            public MyPoint(int x, int y)
            {
                X = x;
                Y = y;     
            }
            public int X { get; set; }
            public int Y { get; set; }
        }
        private void DrawTask(Graphics g,uint N,MyPoint p ,int size)
        {
            if (N == 0)
            {
                N = 10;
                return;
            }
            else
            {
                g.DrawEllipse(new Pen(Color.Blue, 2), p.X, p.Y, size,size);
                p.X += size+10;
                p.Y += size + 10;
                N--;
                DrawTask(g, N, p, size);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            int size = 50;
            MyPoint p = new MyPoint(5,5);
            try
            {
                number = (uint)numericUpDown1.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Некоректно введена кількість!", "Помилка");
            }
            DrawTask(g,number, p,size);
        }
    }
}
