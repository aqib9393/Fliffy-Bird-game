using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            Top.Left -= pipeSpeed;
            Down.Left -= pipeSpeed;
            label1.Text = "Score : "+ score.ToString();
            if(Down.Left <-150)
            {
                Down.Left = 800;
                score++;
            }
            if(Top.Left <-180)
            {
                Top.Left = 950;
                score++;
            }
            if(Bird.Bounds.IntersectsWith(Down.Bounds) ||
                Bird.Bounds.IntersectsWith(Top.Bounds) ||
                Bird.Bounds.IntersectsWith(Ground.Bounds) || Bird.Top < -8)
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }
            else if (score > 10)
            {
                pipeSpeed = 30;
            }
            //pipeSpeed++;
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -5;

            }
        }

        private void gamekeyispress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;

            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            label1.Text += " Game over!!!";
        }
    }
}
