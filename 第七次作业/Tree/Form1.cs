using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                graphics = this.CreateGraphics();
            }
            drawCayleyTree((int)depth.Value, 200, 310, 100, -Math.PI / 2);
            
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                new Pen(drawColor.Color),
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void depth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void leftAngle_ValueChanged(object sender, EventArgs e)
        {
            th2 = (int)leftAngle.Value * Math.PI / 180;
        }

        private void rightAngle_ValueChanged(object sender, EventArgs e)
        {
            th1 = (int)rightAngle.Value * Math.PI / 180;
        }

        private void leftLength_ValueChanged(object sender, EventArgs e)
        {
            per2 = (double)leftLength.Value / 100;
        }

        private void rightLength_ValueChanged(object sender, EventArgs e)
        {
            per1 = (double)rightLength.Value / 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            g.Dispose();//释放资源
        }

        private void colorB_Click(object sender, EventArgs e)
        {
            drawColor.ShowDialog();
        }
    }
}
