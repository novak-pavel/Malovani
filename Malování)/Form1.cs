using System.Drawing;

namespace Malování_
{
    public partial class Form1 : Form
    {
        bool isDrawing;
        Point last;
        Point act;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Form1_Paint(sender, e, last);
        }

        private void Form1_Paint(object sender, PaintEventArgs e, Point? last)
        {
            Form1_Paint(sender, e, last, act);
        }

        private void Form1_Paint(object sender, PaintEventArgs e, Point? last, Point? act)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Red, 2);

            if (isDrawing)
            {
                if (last != null && act != null)
                {
                    g.DrawLine(p, last.Value.X, last.Value.Y, act.Value.X, act.Value.Y);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}