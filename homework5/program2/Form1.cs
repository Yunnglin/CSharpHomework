using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    //Cayley树，添加一些控件，以方便用户修改角度、长度，添加两子树的位置系数，颜色、粗细、是否随机......
    public partial class Form1 : Form
    {

      public Form1()
        {
            InitializeComponent();
        }


        private Graphics graphics;
        private Pen pen = new Pen(Color.Blue, (float)1);
        double angle1 = 30;
        double angle2 = 20;
        double per1 = 0.6;
        double per2 = 0.7;
        double k = 1;
        int n = 10;
        double leng = 150;
        double thick = 1;
      
        private void Draw_Click(object sender, EventArgs e)
        {
            Refresh();

            k = Convert.ToDouble(IndexK.Text);
            n = Convert.ToInt32(IndexN.Text);
            per1 = Convert.ToDouble(TreePer1.Text);
            per2 = Convert.ToDouble(TreePer2.Text);
            angle1 = Convert.ToDouble(TreeAngle1.Text);
            angle2 = Convert.ToDouble(TreeAngle2.Text);
            leng = Convert.ToDouble(LengBox.Text);
           pen.Width= (float)Convert.ToDouble(LineThick.Text);

            if (graphics == null) graphics = this.CreateGraphics();
            DrawCayleyTree(n, 300, 500, leng, -Math.PI / 2);
        }

        private void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = leng * Math.Cos(th) * k + x0;
            double y2 = leng * Math.Sin(th) * k + y0;

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + angle1*Math.PI/180);
            DrawCayleyTree(n - 1, x2, y2, per2 * leng, th - angle2 * Math.PI /180);
        }

        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ColorDialog ColorForm = new ColorDialog();
            if (ColorForm.ShowDialog() == DialogResult.OK)
            {
                Color GetColor = ColorForm.Color;
                pen.Color = GetColor;
                LineColor.BackColor = GetColor;
            }
        }

        private void IndexK_TextChanged(object sender, EventArgs e)
        {
           // k = Convert.ToDouble(IndexK.Text);
        }

        private void IndexN_TextChanged(object sender, EventArgs e)
        {
           // n = Convert.ToInt32(IndexN.Text);
        }

        private void TreePer1_TextChanged(object sender, EventArgs e)
        {
           // per1 = Convert.ToDouble(TreePer1.Text);
        }

        private void TreePer2_TextChanged(object sender, EventArgs e)
        {
           // per2 = Convert.ToDouble(TreePer2.Text);
        }

        private void TreeAngle1_TextChanged(object sender, EventArgs e)
        {
          // th1 = Convert.ToDouble(TreeAngle1.Text);
        }

        private void TreeAngle2_TextChanged(object sender, EventArgs e)
        {
           // th2 = Convert.ToDouble(TreeAngle2.Text);
        }

        private void LengBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LineThick_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
