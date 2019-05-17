using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorilla_Throw
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer boom = new System.Media.SoundPlayer(Properties.Resources.boom);
        Random random = new Random();
        public int score = 0;
        int hits = 0;
        int misses = 0;
        int attempts = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Location = coord(0, 0);
        }

        private Point coord(double x, double y)
        {
            int X = (int)(x * (ClientRectangle.Width - pictureBox1.Width));
            int Y = (int)((1 - y) * (ClientRectangle.Height - pictureBox1.Height));
            return new Point(X, Y);
        }

        private double cos (double θ)
        {
            return Math.Cos(θ * Math.PI / 180);
        }

        private double sin(double θ)
        {
            return Math.Sin(θ * Math.PI / 180);
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            double x = 0;
            double y = 0;
            double vx = 0.04;
            double vy = 0.12;
            double a = -0.01;
            double t = 1;
            try
            {
                double θ = double.Parse(textBox1.Text);
                vx = 0.13 * cos(θ);
                vy = 0.13 * sin(θ);
            }
            catch
            {
                vx = 0.04;
                vy = 0.12;
            }

            pictureBox1.Location = coord(x, y);
            while (y >= 0 && !collide(pictureBox1, pictureBox2))
            {
                await Task.Delay(50);
                x = x + vx * t;
                y = y + vy * t + 0.5 * a * t * t;
                vy = vy + a * t;
                pictureBox1.Location = coord(x, y);
            }
            if (y < 0)
            {
                pictureBox1.Location = coord(x - vx * t, 0);
                miss();
            }
            else
            {
                hit();
                pictureBox2.Image = Properties.Resources.explosion;
                boom.Play();
                await Task.Delay(1500);
                pictureBox2.Location = coord(random.NextDouble(), random.NextDouble());
                pictureBox2.Image = Properties.Resources.monkey_selfie;
            }

            attempts++;
            if (attempts == 10)
            {
                MessageBox.Show("Game Over\nScore " + score);
                Close();
            }

            button2.Enabled = true;

        }

        bool collide (PictureBox p1, PictureBox p2)
        {
            return p1.Bounds.IntersectsWith(p2.Bounds);
        }

        void hit()
        {
            hits++;
            updateScore();
        }

        void miss()
        {
            misses++;
            updateScore();
        }

        void updateScore()
        {
            score = hits * 10 - misses * 5;
            lblScore.Text = "Hits: " + hits +
                "\nMisses: " + misses +
                "\nScore: " + score;
        }
    }
}
