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
        double v = 0.13;

        List<Image> bananas = new List<Image>();

        public Form1()
        {
            InitializeComponent();

            pBoxBanana.Location = coord(0, 0);
            bananas.Add(Properties.Resources.banana1);
            bananas.Add(Properties.Resources.banana2);
            bananas.Add(Properties.Resources.banana3);
            bananas.Add(Properties.Resources.banana4);
            bananas.Add(Properties.Resources.banana5);
            bananas.Add(Properties.Resources.banana6);
            bananas.Add(Properties.Resources.banana7);
            bananas.Add(Properties.Resources.banana8);
            bananas.Add(Properties.Resources.banana9);
            bananas.Add(Properties.Resources.banana10);
            bananas.Add(Properties.Resources.banana11);
            bananas.Add(Properties.Resources.banana12);
            bananas.Add(Properties.Resources.banana13);
            bananas.Add(Properties.Resources.banana14);
            bananas.Add(Properties.Resources.banana15);
            bananas.Add(Properties.Resources.banana16);
            bananas.Add(Properties.Resources.banana17);
            bananas.Add(Properties.Resources.banana18);
            bananas.Add(Properties.Resources.banana19);
            bananas.Add(Properties.Resources.banana20);

            pboxBackground.Controls.Add(pBoxBanana);
            pboxBackground.Controls.Add(pBoxDK);
        }

        private Point coord(double x, double y)
        {
            int X = (int)(x * (pboxBackground.Width - pBoxBanana.Width));
            int Y = (int)((1 - y) * (pboxBackground.Height - pBoxBanana.Height));
            return new Point(X, Y);
        }

        private Point coordMonkey(double x, double y)
        {
            int X = (int)(x * (pboxBackground.Width - pBoxDK.Width));
            int Y = (int)((1 - y) * (pboxBackground.Height - pBoxDK.Height));
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
            double t = 0.2;
            int pause = (int)(50 * t);

            int frame = 0;

            try
            {
                double θ = double.Parse(textBox1.Text);
                vx = v * cos(θ);
                vy = v * sin(θ);
            }
            catch
            {
                vx = 0.04;
                vy = 0.12;
            }

            pBoxBanana.Location = coord(x, y);
            //while (y >= 0 && !collide(pBoxBanana, pboxMonkey))
            while (pboxBackground.Bounds.IntersectsWith(pBoxBanana.Bounds) && !collide(pBoxBanana, pBoxDK))
            {
                await Task.Delay(pause);
                x = x + vx * t;
                y = y + vy * t + 0.5 * a * t * t;
                vy = vy + a * t;
                pBoxBanana.Location = coord(x, y);
                frame = (frame + 1) % bananas.Count;
                pBoxBanana.Image = bananas[frame];
            }
            if (collide(pBoxBanana,pBoxDK))
            {
                hit();
                pBoxDK.Image = Properties.Resources.splat;
                boom.Play();
                pBoxBanana.Visible = false;
                await Task.Delay(1500);
                pBoxDK.Location = coordMonkey(random.NextDouble(), random.NextDouble());
                pBoxDK.Image = Properties.Resources.DonkeyKong;
                pBoxBanana.Visible = true;
            }
            else
            {
                //pBoxBanana.Location = coord(x - vx * t, 0);
                miss();
            }

            attempts++;
            if (attempts == 10)
            {
                MessageBox.Show("Game Over\nScore " + score);
                Close();
            }

            pBoxBanana.Location = coord(0, 0);
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

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            v = (100.0 - vScrollBar1.Value) / 100.0 * 0.26;
            label2.Text = "velocity = " + v.ToString("0.00");
        }
    }
}
