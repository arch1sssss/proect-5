using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }
        int meth = 1;
        int xx = 0;
        int yy = 0;
        bool click = false;


    
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height); 
            Graphics graph = Graphics.FromImage(pictureBox1.Image);
            Pen pen = new Pen(Brushes.Black);
            if (radioButton1.Checked == true)
            {
                meth = 1;
            }
            if (radioButton2.Checked == true)
            {
                meth = 2;
            }
            if (radioButton3.Checked == true)
            {
                meth = 3;
            }
            if (radioButton4.Checked == true)
            {
                pen.Color = Color.Black;
            }
            if (radioButton5.Checked == true)
            {
                pen.Color = Color.Red;
            }
            if (radioButton6.Checked == true)
            {
                pen.Color = Color.Green;
            }
            if (radioButton7.Checked == true)
            {
                pen.Color = Color.Blue;
            }
            pen.Width = 4;
            if (click == false)
            {
                xx = e.X;
                yy = e.Y;
                click = true;

            }
            else
            {
                click = false;
                switch (meth)
                {
                    case 1:
                        graph.DrawLine(pen, xx, yy, e.X, e.Y);
                        break;
                    case 2:
                        graph.DrawEllipse(pen, xx - 15, yy - 15, 30, 30);
                        break;
                    case 3:
                        graph.DrawRectangle(pen, e.X - 15, e.Y - 15, 30, 30);
                        break;
                }

            }
        }
    }
}
