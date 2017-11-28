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

        private bool is_selected = false;

        private int tab_ind;
		private Render.Point3d _prev_scale = new Point3d (1, 1, 1);

        public Form1()
        {
            InitializeComponent();
            ClearScreen();
        }

        private void ClearScreen()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.Silver);
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

        private Figure Tetrahedron()
        {
            Figure figure = new Figure();
            double coef = 50 * Math.Sqrt(3);
            Point3d p1 = new Point3d(0, coef / 2, 0);
            Point3d p2 = new Point3d(-50, -coef / 2, 0);
            Point3d p3 = new Point3d(50, -coef / 2, 0);
            Point3d p4 = new Point3d(0, -coef / 2, -coef);

            figure.Add(new Line(p1, p2));
            figure.Add(new Line(p2, p3));
            figure.Add(new Line(p3, p1));
            figure.Add(new Line(p1, p4));
            figure.Add(new Line(p2, p4));
            figure.Add(new Line(p3, p4));
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
            int c = 200;
            return new Point((int)((c * p.x / (p.z + c)) + pictureBox1.Width / 2),
                (int)((-1) * (c * p.y / (p.z + c)) + pictureBox1.Height / 2));
        }

        private Point ToPBPoint1(Point3d p)
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
            is_selected = true;
        }



        private void textBox_displX_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            int num;
            if (int.TryParse(tb.Text, out num) && is_selected)
                button_move.Enabled = true;
            else
                button_move.Enabled = false;
        }

        private void button_move_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            if (!int.TryParse(textBox_displX.Text, out x))
                x = 0;
            if (!int.TryParse(textBox_displY.Text, out y))
                y = 0;
            if (!int.TryParse(textBox_displZ.Text, out z))
                z = 0;
            Displacement(x, y, z);
            DrawFigure();
        }

        private void radioButton_rotateX_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            button_rotate.Enabled = true;
            tab_ind = rb.TabIndex;
            if (rb.TabIndex == 3)
            {
                textBox_customX1.Enabled = true;
                textBox_customY1.Enabled = true;
                textBox_customZ1.Enabled = true;
                textBox_customX2.Enabled = true;
                textBox_customY2.Enabled = true;
                textBox_customZ2.Enabled = true;
            }
            else
            {
                textBox_customX1.Enabled = false;
                textBox_customY1.Enabled = false;
                textBox_customZ1.Enabled = false;
                textBox_customX2.Enabled = false;
                textBox_customY2.Enabled = false;
                textBox_customZ2.Enabled = false;
            }
        }

        private void button_rotate_Click(object sender, EventArgs e)
        {
            double angle;
            if (!double.TryParse(textBox_rotateAngle.Text, out angle))
                angle = 0;
            angle = angle * Math.PI / 180;
            Rotate(tab_ind, angle);
            DrawFigure();
        }

        private void Reset()
        {
            comboBox1.SelectedIndex = -1;
            is_selected = false;
			_prev_scale = new Point3d (1, 1, 1);
            foreach (var child in panel.Controls)
            {
                if (child is Panel)
                {
                    foreach (var chld in ((Panel)child).Controls)
                    {
                        if (chld is TextBox)
                        {
                            (chld as TextBox).Text = "";

                        }
                        if (chld is RadioButton)
                        {
                            (chld as RadioButton).Checked = false;
                        }
                        if (chld is TrackBar)
                        {
                            (chld as TrackBar).Value = 10;
                        }
                        if (chld is Button)
                        {
                            (chld as Button).Enabled = false;
                        }
                    }
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Reset();
            Reset();
        }

        private void PrintFigure()
        {
            foreach (var edge in f.GetLines())
            {
                Console.WriteLine("line: ");
                Console.WriteLine("start: " + edge.start.x.ToString() + "; " + edge.start.y.ToString() + "; " + edge.start.z.ToString());
                Console.WriteLine("end: " + edge.end.x.ToString() + "; " + edge.end.y.ToString() + "; " + edge.end.z.ToString());
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void trackBar_scaleX_Scroll(object sender, EventArgs e)
        {
            double x = trackBar_scaleX.Value / 10.0;
            double y = trackBar_scaleY.Value / 10.0;
            double z = trackBar_scaleZ.Value / 10.0;
            
			// Перед тем, как повернуть нужно обязательно вернуться к предыдущему размеру
			// Иначе изменяем размер уже измененной фигуры
			f.Scale (1 / _prev_scale.x, 1 / _prev_scale.y, 1 / _prev_scale.z);
			f.Scale(x, y, z);
			_prev_scale.x = x;
			_prev_scale.y = y;
			_prev_scale.z = z;
            DrawFigure();
        }

        private void radioButton_reflectX_CheckedChanged(object sender, EventArgs e)
        {
            button_reflect.Enabled = true;
        }

        private void button_reflect_Click(object sender, EventArgs e)
        {
        }
    }
  
}
