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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Top <= 0 &&
                pictureBox4.Top <= 0 &&
                pictureBox5.Top <= 0 &&
                pictureBox6.Top <= 0)
            {
                timer2.Stop();
                timer1.Start();
            }

            pictureBox3.Top = pictureBox3.Top + 10;
            pictureBox4.Top = pictureBox4.Top + 10;
            pictureBox5.Top = pictureBox5.Top + 10;
            pictureBox6.Top = pictureBox6.Top + 10;

            if (pictureBox3.Top >= 400 &&
                pictureBox4.Top >= 400 &&
                pictureBox5.Top >= 400 &&
                pictureBox6.Top >= 400)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pictureBox2.Top = pictureBox2.Top - 10;
            if (e.KeyCode == Keys.Down) pictureBox2.Top = pictureBox2.Top + 10;
            if (e.KeyCode == Keys.Left) pictureBox2.Left = pictureBox2.Left - 10;
            if (e.KeyCode == Keys.Right) pictureBox2.Left = pictureBox2.Left + 10;

            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds)) pictureBox2.Left = 0;
            if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds)) pictureBox2.Left = 0;
            if (pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds)) pictureBox2.Left = 0;
            if (pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds)) pictureBox2.Left = 0;

            if (pictureBox2.Top < 0) pictureBox2.Top = 0;
            if (pictureBox2.Left < 0) pictureBox2.Left = 0;
            if (pictureBox2.Top > 400) pictureBox2.Top = 400;

            if (pictureBox2.Left > 600)
            {
                Form2 newForm = new Form2();
                newForm.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Top >= 400 &&
                pictureBox4.Top >= 400 &&
                pictureBox5.Top >= 400 &&
                pictureBox6.Top >= 400)
            {
                timer1.Stop();
                timer2.Start();
            }

            pictureBox3.Top = pictureBox3.Top - 10;
            pictureBox4.Top = pictureBox4.Top - 10;
            pictureBox5.Top = pictureBox5.Top - 10;
            pictureBox6.Top = pictureBox6.Top - 10;

            if (pictureBox3.Top <= 0 &&
                pictureBox4.Top <= 0 &&
                pictureBox5.Top <= 0 &&
                pictureBox6.Top <= 0)
            {
                timer2.Stop();
                timer1.Start();
            }
        }
    }
}
