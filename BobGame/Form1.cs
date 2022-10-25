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
            pictureBox3.Top = pictureBox3.Top + 10;
            pictureBox4.Top = pictureBox4.Top + 40;
            pictureBox5.Top = pictureBox5.Top + 20;
            pictureBox6.Top = pictureBox6.Top + 30;

            if (pictureBox3.Top == 400) pictureBox3.Top = 0;
            if (pictureBox4.Top == 400) pictureBox4.Top = 0;
            if (pictureBox5.Top == 400) pictureBox5.Top = 0;
            if (pictureBox6.Top == 330) pictureBox6.Top = 0;
        }
    }
}
