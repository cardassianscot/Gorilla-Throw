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
    public partial class FormStart : Form
    {
        int highscore = 0;

        public FormStart()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Hide();
            f.ShowDialog();
            label2.Text = "Last Score " + f.score;
            if (f.score > highscore)
            {
                highscore = f.score;
                label1.Text = "High Score " + highscore;
            }
            Show();
        }
    }
}
