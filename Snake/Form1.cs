using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Snake._2D;

namespace Snake
{
    public partial class Form1 : Form
    {
        private ISnake<Point, Direction2D> _snake;  
        public Form1()
        {                                      
            InitializeComponent();
            _snake = new Snake<Point, Direction2D>(new Coordinate2D(Direction2D.Up, new Point(25, 25)), 4, new SnakePartFactory<Point, Direction2D>());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var canvas = e.Graphics;
            canvas.Clear(pictureBox1.BackColor);

            foreach (var snakePart in _snake.Body())
            {
                canvas.FillEllipse(Brushes.Yellow, new Rectangle(snakePart.Coordinate().CurrentCoordinate().X * 10, snakePart.Coordinate().CurrentCoordinate().Y * 10, 10, 10));

            }
        }
    }
}
