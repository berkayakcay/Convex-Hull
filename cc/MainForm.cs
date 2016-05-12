using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cc
{
    public partial class MainForm : Form
    {
        List<Point> points = new List<Point>(100);
        Bitmap bitmap = new Bitmap(500, 500);

        public MainForm()
        {
            InitializeComponent();
            trackBar1.Value = 50;
            label1.Text = "50";
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GeneratePoints();
            DrawPoints();
        }

        private void ch2Button_Click(object sender, EventArgs e)
        {
            List<Point> ch = ConvexHull.CH2(points);
            DrawConvexHull(bitmap, ch);
        }

        private void ch2NoFirstButton_Click(object sender, EventArgs e)
        {
            List<Point> ch = ConvexHull.CH2(points, true);
            DrawConvexHull(bitmap, ch);
        }

        private void GeneratePoints()
        {
            points.Clear();
            Random rand = new Random();
            for (int i = 0; i < trackBar1.Value; i++)
            {
                Point p = new Point(rand.Next(25, 475), rand.Next(25, 475));
                if (points.Contains(p))
                    continue;
                points.Add(p);
            }
        }

        private void DrawPoints()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.Dispose();

            foreach (Point p in points)
            {
                DrawPixel(bitmap, p, Color.Black);
            }

            drawAreaPictureBox.Image = bitmap;
            drawAreaPictureBox.Update();
        }

        private void DrawConvexHull(Bitmap bitmap, List<Point> ch)
        {
            if (ch == null)
            {
                MessageBox.Show("No points generated yet");
                return;
            }

            textBox1.Text = "";
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                if (ch.Count == 1)
                {
                    DrawPixel(bitmap, ch[0], Color.Red);
                    textBox1.Text += ch[0] + Environment.NewLine;
                }
                else
                {
                    for (int i = 0; i < ch.Count - 1; i++)
                    {
                        DrawPixel(bitmap, ch[i], Color.Red);
                        textBox1.Text += ch[i] + Environment.NewLine;
                        g.DrawLine(new Pen(Color.Red), ch[i], ch[i + 1]);
                    }

                    DrawPixel(bitmap, ch[ch.Count - 1], Color.Red);
                }
            }

            drawAreaPictureBox.Image = bitmap;
            drawAreaPictureBox.Update();
        }

        private void DrawPixel(Bitmap b, Point p, Color c)
        {
            for (int i = -2; i <= 2; i++)
            {
                for (int j = -2; j <= 2; j++)
                {
                    b.SetPixel(p.X + i, p.Y + j, c);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void drawAreaPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            pboxToolTip.SetToolTip(drawAreaPictureBox, String.Format("({0}, {1})", e.X, e.Y));
        }
    }
}
