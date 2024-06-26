﻿using System;
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

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pictureBox4.Top = pictureBox4.Top - 10;
            if (e.KeyCode == Keys.Down) pictureBox4.Top = pictureBox4.Top + 10;
            if (e.KeyCode == Keys.Left) pictureBox4.Left = pictureBox4.Left - 10;
            if (e.KeyCode == Keys.Right) pictureBox4.Left = pictureBox4.Left + 10;

            if (pictureBox4.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox4.Left = 0;
                pictureBox4.Top = 0;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox4.Left = 0;
                pictureBox4.Top = 0;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox4.Left = 0;
                pictureBox4.Top = 0;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pictureBox4.Left = 0;
                pictureBox4.Top = 0;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox4.Left = 0;
                pictureBox4.Top = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Top >= 400 &&
                pictureBox6.Top >= 400)
            {
                timer2.Stop();
                timer1.Start();
            }

            pictureBox5.Top = pictureBox5.Top - 5;
            pictureBox6.Top = pictureBox6.Top - 5;

            if (pictureBox5.Top <= 0 &&
                pictureBox6.Top <= 0)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Top <= 0 &&
                pictureBox6.Top <= 0)
            {
                timer1.Stop();
                timer2.Start();
            }

            pictureBox5.Top = pictureBox5.Top + 5;
            pictureBox6.Top = pictureBox6.Top + 5;

            if (pictureBox5.Top >= 400 &&
                pictureBox6.Top >= 400)
            {
                timer2.Stop();
                timer1.Start();
            }
        }
    }
}
