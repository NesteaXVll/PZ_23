using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ_23
{
    public partial class Form1 : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);

        bool RectangleClicked = false;
        bool CircleClicked = false;
        bool SquareClicked = false;

        int RectangleX, RectangleY;
        int CircleX, CircleY;
        int SquareX, SquareY;

        int X, Y, dX, dY;
        int LastClicked = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void paintBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
        }
        private void paintBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    RectangleClicked = true;
                    LastClicked = 1;
                    RectangleX = e.X - Rectangle.X;
                    RectangleY = e.Y - Rectangle.Y;
                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleClicked = true;
                    LastClicked = 2;
                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;
                }
            }
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    SquareClicked = true;
                    LastClicked = 3;
                    SquareX = e.X - Square.X;
                    SquareY = e.Y - Square.Y;
                }
            }

        }
        private void paintBox1_MouseUp(object sender, MouseEventArgs e)
        {
            RectangleClicked = false;
            CircleClicked = false;
            SquareClicked = false;

            if (LastClicked == 1)
            {
                if ((label2.Location.X < Rectangle.X + Rectangle.Width) && (label2.Location.X > Rectangle.X))
                {
                    if ((label2.Location.Y < Rectangle.Y + Rectangle.Height) && (label2.Location.Y > Rectangle.Y))
                    {
                        X = Rectangle.X;
                        Y = Rectangle.Y;
                        dX = RectangleX;
                        dY = RectangleY;
                        Rectangle.X = Square.X;
                        Rectangle.Y = Square.Y;
                        RectangleX = SquareX;
                        RectangleY = SquareY;

                        Square.X = X;
                        Square.Y = Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }
            if (LastClicked == 2)
            {
                if ((label2.Location.X < Circle.X + Circle.Width) && (label2.Location.X > Circle.X))
                {
                    if ((label2.Location.Y < Circle.Y + Circle.Height) && (label2.Location.Y > Circle.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX;
                        dY = CircleY;
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        CircleX = SquareX;
                        CircleY = SquareY;

                        Square.X = X;
                        Square.Y = Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }
            if (LastClicked == 3)
            {
                if ((label2.Location.X < Square.X + Square.Width) && (label2.Location.X > Square.X))
                {
                    if ((label2.Location.Y < Square.Y + Square.Height) && (label2.Location.Y > Square.Y))
                    {
                        X = Square.X;
                        Y = Square.Y;
                        dX = SquareX;
                        dY = SquareY;
                        Square.X = Circle.X;
                        Square.Y = Circle.Y;
                        SquareX = CircleX;
                        SquareY = CircleY;

                        Circle.X = X;
                        Circle.Y = Y;
                        CircleX = dX;
                        CircleY = dY;
                    }
                }
            }

        }


        private void paintBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (RectangleClicked)
            {
                Rectangle.X = e.X - RectangleX;
                Rectangle.Y = e.Y - RectangleY;
            }

            if (CircleClicked)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
            }

            if (SquareClicked)
            {
                Square.X = e.X - SquareX;
                Square.Y = e.Y - SquareY;
            }
            pictureBox1.Invalidate();

            if ((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X))
            {
                if ((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    label3.Text = "Жёлтый прямоугольник";
                }
            }

            if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if ((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label3.Text = "Красный круг";
                }
            }

            if ((label1.Location.X < Square.X + Square.Width) && (label1.Location.X > Square.X))
            {
                if ((label1.Location.Y < Square.Y + Square.Height) && (label1.Location.Y > Square.Y))
                {
                    label3.Text = "Синий квадрат";
                }
            }
        }
    }
}
