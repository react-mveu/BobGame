using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left + 40;

            if (pictureBox3.Left > 600) pictureBox3.Left = 0;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pictureBox2.Top = pictureBox2.Top - 10;
            if (e.KeyCode == Keys.Down) pictureBox2.Top = pictureBox2.Top + 10;
            if (e.KeyCode == Keys.Left) pictureBox2.Left = pictureBox2.Left - 10;
            if (e.KeyCode == Keys.Right) pictureBox2.Left = pictureBox2.Left + 10;

            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds)) pictureBox2.Top = 0;

            if (pictureBox2.Top < 0) pictureBox2.Top = 0;
            if (pictureBox2.Left < 0) pictureBox2.Left = 0;
            if (pictureBox2.Left > 600) pictureBox2.Left = 600;
        }
    }
}
