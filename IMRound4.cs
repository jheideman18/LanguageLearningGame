using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Jody Heideman
 * 219307725
 * 18 June 2021
 * 
 */
namespace LanguageLearningGame
{
    public partial class IMRound4 : Form
    {
        public IMRound4()
        {
            InitializeComponent();
           
        }
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);
        System.Media.SoundPlayer btnCorrect = new System.Media.SoundPlayer(Properties.Resources.Correct);
        System.Media.SoundPlayer btnWrong = new System.Media.SoundPlayer(Properties.Resources.Wrong);
        System.Media.SoundPlayer btnWon = new System.Media.SoundPlayer(Properties.Resources.Won);
        System.Media.SoundPlayer btnLost = new System.Media.SoundPlayer(Properties.Resources.Lost);

        bool btnOption3IsClicked;
        int clicked = 1;


        public int scoreG = 0;
        int attempts = 3;
        frmMainMenu menu = new frmMainMenu();

        public void Verify()
        {
            if (btnOption3IsClicked)
            {
                btnCorrect.Play();
                scoreG += 1;
                lblScore.Text = scoreG.ToString();
                btnOption1.Enabled = false;
                btnOption2.Enabled = false;
                btnOption4.Enabled = false;

                if (scoreG == 4)
                {
                    MessageBox.Show("That was correct! ");
                    btnWon.PlayLooping();
                }
                else
                {
                    MessageBox.Show("You didn't do so well ");
                    btnLost.PlayLooping();
                }
                menu.scoreG = scoreG;

                btnContinue.Visible = false;
                btnCheck.Enabled = false;

                menu.Show();
                this.Hide();

            }
            else
            {
                btnWrong.Play();
                MessageBox.Show("That is not correct");

            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Verify();
            clicked++;
            if (clicked == 3)
            {
                MessageBox.Show("Attempts maxed out");
                scoreG += 0;

                btnOption1.Enabled = false;
                btnOption2.Enabled = false;
                btnOption3.Enabled = false;
                btnOption4.Enabled = false;

                menu.scoreG = scoreG;


                btnContinue.Visible = true;
                btnCheck.Enabled = false;
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Verify();
            menu.Show();
            this.Hide();
        }

        private void btnSound1_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
          

            
        }

        private void btnSound2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
            
           
        }

        private void btnSound3_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
       
            
        }

        private void LearnGreetingsRound2_Load(object sender, EventArgs e)
        {
            lblScore.Text = scoreG.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
          
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            menu.Show();
            this.Hide();
        }

        private void lblHello_Click(object sender, EventArgs e)
        {
           
        }

        private void lblHowrU_Click(object sender, EventArgs e)
        {

          
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
         

        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            btnClick.Play(); 
            btnOption3IsClicked = true;
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnWon.Stop();
            btnLost.Stop();
        }
    }
}
