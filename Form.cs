using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugJump
{

    public partial class Form : System.Windows.Forms.Form
    {
        int speed = 8;
        int gravity = 15;
        int score = 0;

        public Form()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            debugBug.Top += gravity;
            lowerColumn.Left -= speed;
            upperColumn.Left -= speed;
            scoreText.Text = "Clean Code Streak: " + score;

            if(lowerColumn.Left < -150)
            {
                lowerColumn.Left = 800;
                score++;
            }
            
            if(upperColumn.Left < -180)
            {
                upperColumn.Left = 950;
                score++;  
            }

            if (debugBug.Bounds.IntersectsWith(lowerColumn.Bounds) || 
                debugBug.Bounds.IntersectsWith(upperColumn.Bounds) ||
                debugBug.Bounds.IntersectsWith(debugConsole.Bounds) ||
                debugBug.Top < -25)
            {
                endGame();
            }

            speed = (score > 5) ? 16 :
                    (score > 10) ? 24 :
                    (score > 20) ? 32 :
                    (score > 30) ? 40 :
                    speed; 
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            } 
            else if (e.KeyCode == Keys.F5) 
            {
                RestartGame();
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = $"EXCEPTION ON LINE:  {score + 1} 'Clean code failed'"; 
        }

        private void RestartGame()
        {
            gameTimer.Stop();

            speed = 8;
            gravity = 15;
            score = 0;

            debugBug.Top = 150; 
            lowerColumn.Left = 800;
            upperColumn.Left = 950;

            scoreText.Text = "Clean Code Streak: 0";

            gameTimer.Start();
        }
    }
}
