using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propcopter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool goLeft;
        bool goRight;
        int move = 10;
        int goUp = 4;
        int time;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            else if(e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            else if(e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(10, 100);

            Random rndTwo = new Random();
            int numTwo = rndTwo.Next(10, 100);

            Random rndThree = new Random();
            int numThree = rndThree.Next(2);

            Random rndFour = new Random();
            int numFour = rndFour.Next(2);

            if (goLeft == true && Kloud.Left > 0)
            {
                Kloud.Left -= move;
            }

            if (goRight == true && Kloud.Left < 569)
            {
                Kloud.Left += move;
            }

            pictureBox1.Top += goUp;
            pictureBox2.Top += goUp;
            pictureBox4.Top += goUp;
            pictureBox5.Top += goUp;

            if (pictureBox1.Top > 600)
            {
                time++;
                Label1.Text = time.ToString();

                pictureBox1.Top = 50;
                pictureBox2.Top = 50;

                if(pictureBox1.Width > (num+10) && numThree == 0)
                {
                    pictureBox2.Width += num;
                    pictureBox1.Width -= num;
                    pictureBox1.Left += num;
                }
                else if(pictureBox2.Width > (num+10) && numThree == 1)
                {
                    pictureBox2.Width -= num;
                    pictureBox1.Width += num;
                    pictureBox1.Left -= num;
                }
                
            }

            if(pictureBox4.Top > 600)
            {
                time++;
                Label1.Text = time.ToString();
                pictureBox4.Top = 50;
                pictureBox5.Top = 50;

                if(pictureBox4.Width > (num+10) && numFour == 0)
                {
                    pictureBox5.Width += numTwo;
                    pictureBox4.Width -= numTwo;
                    pictureBox4.Left += numTwo;
                }
                else if(pictureBox5.Width > (num+10) && numFour == 1)
                {
                    pictureBox5.Width -= numTwo;
                    pictureBox4.Width += numTwo;
                    pictureBox4.Left -= numTwo;
                }
                
            }

            

            if(Kloud.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox6.Visible = true;
                timer1.Stop();
            }
            else if(Kloud.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox6.Visible = true;
                timer1.Stop();
            }
            else if(Kloud.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pictureBox6.Visible = true;
                timer1.Stop();
            }
            else if(Kloud.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pictureBox6.Visible = true;
                timer1.Stop();
            }
        }
    }
}
