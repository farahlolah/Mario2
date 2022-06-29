using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario2
{
    public partial class Form1 : Form
    {  
        int cloudSpeed = 1;
        int mushroomSpeed = 4;
        int gravity = 0;
        int score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void gameTimerEvent(object sender, EventArgs e)
            
        { scoreLabel.Text= "score: " + score.
                ToString();
            mario.Top += gravity;
            cloud1.Left -= cloudSpeed;
            cloud2.Left -= cloudSpeed;
            cloud3.Left -= cloudSpeed;
            mushroom.Left -= mushroomSpeed;


            if (cloud1.Left < -200 &&
                cloud2.Left < -150 &&
                cloud3.Left < -100)
            {
                cloud1.Left = 550;
                cloud2.Left = 650;
                cloud3.Left = 800;
            }
            if (mushroom.Left < -200)
            {
                mushroom.Left = 550;
                score++;
            }
            if (mario.Bounds.IntersectsWith(ground.Bounds))
            {
                mario.Top = 224;
            }

            scoreMushroom();
            /*if (mario.Right.Equals(mushroom.Left))
            {
                score++;
            }*/

        }

        private void gameDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }


        }

        private void gameUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 9;
                
            }
            
        }
       private void scoreMushroom()
        {

            
          
                if(mario.Bounds.IntersectsWith(mushroom.Bounds))
            { 
                    score++;
                    
                    if (score > 1) { score--; }

                }
            
        }
    }
}
