using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioForCircleChoose.Checked = true;
        }

        private void Form1_SizeChanged(object sender, EventArgs e) => pictureBox1.Refresh();

        private void Button1_Click(object sender, EventArgs e) => pictureBox1.Refresh();

        private void TrackBar1_ValueChanged(object sender, EventArgs e) => pictureBox1.Refresh();

        private void TrackBarPSize_Scroll(object sender, EventArgs e) => pictureBox1.Refresh();

        private void TrackLSize_Scroll(object sender, EventArgs e) => pictureBox1.Refresh();

        private void TrackASize_Scroll(object sender, EventArgs e) => pictureBox1.Refresh();

        private double Parabolic(double x, double a, double b, double c) => (a * (Math.Pow(x, 2)) + (b * x) + c);

        private double FindDelta(double x1, double x2) => (x2 - x1) / 1000;
   
        private double findMaximumOfY(double x1, double x2, double a, double b, double c, double maxy, double dt)
        {
            for (double x = x1; x < x2; x += dt)
            {
                double y = Parabolic(x, a, b, c);
                if (y > maxy)
                {
                    maxy = y;
                }
            }
            return maxy;
        }

        private double findMinimumOfY(double x1, double x2, double a, double b, double c, double miny, double dt)
        {
            for (double x = x1; x < x2; x += dt)
            {
                double y = Parabolic(x, a, b, c);
                if (y < miny)
                {
                    miny = y;
                }
            }
            return miny;
        }

        private void drawParabolicFunction(double x1, double x2, double a, double b, double c, double miny, double dt, double maxy, double minx, double maxx, PaintEventArgs e, Pen penForLine)
        {
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            for (double x = x1; x < x2; x += dt)
            {

                double y1 = Parabolic(x, a, b, c);
                double y2 = Parabolic(x + dt, a, b, c);

                double xu1 = Parabolic(x, a, b, c);
                double xu2 = Parabolic(x + dt, a, b, c);

                int x_1 = (int)(w * (x - x1) / (x2 - x1));
                int x_2 = (int)(w * (x + dt - x1) / (x2 - x1));

                int y_1 = (int)(h * (maxy - y1) / (maxy - miny));
                int y_2 = (int)(h * (maxy - y2) / (maxy - miny));

                e.Graphics.DrawLine(penForLine, x_1, y_1, x_2, y_2);
            }
        }

        private void yAxis(PaintEventArgs e, int height, double miny, double maxy, int n, SolidBrush brPoints, SolidBrush brAxisValues, Pen penForAxis)
        {

            e.Graphics.DrawLine(penForAxis, 10, 1, 10, height);
            for (int i = 0; i < n; i++)
            {
                double y = miny + (maxy - miny) * (n - i) / n;
                if (radioForCircleChoose.Checked)
                {
                    e.Graphics.FillEllipse(brPoints, (int)(height / n * (i + 0.97)), height - 7, trackBarPSize.Value, trackBarPSize.Value);
                }
                else { e.Graphics.FillRectangle(brPoints, 0, height / n * i, trackBarPSize.Value, trackBarPSize.Value); }

                e.Graphics.DrawString(y.ToString("F"), SystemFonts.DefaultFont, brAxisValues, 11, height / n * i);
            }
        }

        private void xAxis(PaintEventArgs e, int width, int height, double minX, double maxX, int K, SolidBrush brPoints, SolidBrush brAxisValues, Pen penForAxis)
        {
            e.Graphics.DrawLine(penForAxis, 10, height - 1, width, height - 1);

            for (int i = 0; i < K; i++)
            {
                double x = minX +(maxX - minX) * i / K; //minX + 

                if (radioForCircleChoose.Checked)
                {
                    e.Graphics.FillEllipse(brPoints, 0, height / K * i, trackBarPSize.Value, trackBarPSize.Value);
                }
                else
                {
                    e.Graphics.FillRectangle(brPoints, (int)(width / K * (i + 0.95)), height - 7, trackBarPSize.Value, trackBarPSize.Value);
                }
                e.Graphics.DrawString(x.ToString("F"), SystemFonts.DefaultFont, brAxisValues, (int)(width / K * (i + 0.72)), height - 18);
            }

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            double x1 = double.Parse(textBoxX1.Text);
            double x2 = double.Parse(textBoxX2.Text);
            double a = double.Parse(textBox3.Text);
            double b = double.Parse(textBox1.Text);
            double c = double.Parse(textBox2.Text);

            double dt = FindDelta(x1, x2);

            double miny = Parabolic(x1, a, b, c);
            double maxy = miny;

            double minx = Parabolic(x1, a, b, c);
            double maxx = minx;

            maxy = findMaximumOfY(x1, x2, a, b, c, maxy, dt);
            miny = findMinimumOfY(x1, x2, a, b, c, miny, dt);

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            Pen penForLine = new Pen(colorDialog3.Color, trackLSize.Value);
            Pen penForAxis = new Pen(colorDialog2.Color, trackASize.Value);

            SolidBrush brPoints = new SolidBrush(colorDialog1.Color);
            SolidBrush brAxisValues = new SolidBrush(colorDialog2.Color);

            int N = 10;
            yAxis(e, h, miny, maxy, N, brPoints, brAxisValues, penForAxis);
            xAxis(e, w, h, x1, x2, N, brPoints, brAxisValues, penForAxis);
            drawParabolicFunction(x1, x2, a, b, c, miny, dt, maxy, minx, maxx, e, penForLine);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.Refresh();
        }

        private void buttonForAxisChanger_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            pictureBox1.Refresh();
        }

        private void buttonForLineChanger_Click(object sender, EventArgs e)
        {
            colorDialog3.ShowDialog();
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioForCircleChoose_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
