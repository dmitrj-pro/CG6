using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Render;

namespace Interface
{
    public partial class Form1 : Form
    {
        private Figure f;

        private Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearScreen()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.Silver);
        }

        private Figure Tetrahedron()
        {
            Figure figure = new Figure();
            double h = 50 * Math.Sqrt(3);
            Point3d p1 = new Point3d(0, h / 2, 0);
            Point3d p2 = new Point3d(-50, -h / 2, 0);
            Point3d p3 = new Point3d(50, -h / 2, 0);
            Point3d p4 = new Point3d(0, -h / 2, -h);

            figure.Add(new Line(p1, p2));
            figure.Add(new Line(p2, p3));
            figure.Add(new Line(p3, p1));
            figure.Add(new Line(p1, p4));
            figure.Add(new Line(p2, p4));
            figure.Add(new Line(p3, p4));
            return figure;
        }

        private Figure Hexahedron()
        {
            Figure figure = new Figure();
            Point3d p1 = new Point3d(100 / 2, -100 / 2, 100 / 2);
            Point3d p2 = new Point3d(100 / 2, -100 / 2, -100 / 2);
            Point3d p3 = new Point3d(-100 / 2, -100 / 2, -100 / 2);
            Point3d p4 = new Point3d(-100 / 2, -100 / 2, 100 / 2);

            Point3d p5 = new Point3d(100 / 2, 100 / 2, 100 / 2);
            Point3d p6 = new Point3d(100 / 2, 100 / 2, -100 / 2);
            Point3d p7 = new Point3d(-100 / 2, 100 / 2, -100 / 2);
            Point3d p8 = new Point3d(-100 / 2, 100 / 2, 100 / 2);

            figure.Add(new Line(p1, p2));
            figure.Add(new Line(p2, p3));
            figure.Add(new Line(p3, p4));
            figure.Add(new Line(p4, p1));

            figure.Add(new Line(p5, p6));
            figure.Add(new Line(p6, p7));
            figure.Add(new Line(p7, p8));
            figure.Add(new Line(p8, p5));

            figure.Add(new Line(p1, p5));
            figure.Add(new Line(p2, p6));
            figure.Add(new Line(p3, p7));
            figure.Add(new Line(p4, p8));


            return figure;

        }

        private void Displacement(double x, double y, double z)
        {
            f.Smestchenie(x, y, z);
        }

        private void Rotate(int axis, double deg)
        {
            if(axis == 0)
            {
                f.RotateX(deg);
            }
            else if(axis == 1)
            {
                f.RotateY(deg);
            }
            else if(axis == 2)
            {
                f.RotateZ(deg);
            }
        }

        private void Scale(double x, double y, double z)
        {
            f.Scale(x, y, z);
        }

        private Point ToPBPoint(Point3d p)
        {

            return new Point((int)(p.x + pictureBox1.Width / 2), (int)((-1) * p.y + pictureBox1.Height / 2));
        }

        void DrawFigure()
        {
            ClearScreen();
            Pen pen = new Pen(Color.DarkRed);
            foreach (var edge in f.GetLines())
            {
                g.DrawLine(pen, ToPBPoint(edge.start), ToPBPoint(edge.end));
            }
            pictureBox1.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                f = Tetrahedron();
                DrawFigure();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                f = Hexahedron();
                DrawFigure();
            }
        }
    }
  
}
