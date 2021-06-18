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
    public partial class LearnGreetingsRound3 : Form
    {
        public LearnGreetingsRound3()
        {
            InitializeComponent();
           
        }

        bool btnSound3IsClicked;
        bool btnSound1IsClicked;
        bool btnSound2IsClicked;

        public int scoreG = 0;

        frmMainMenu mainMenu = new frmMainMenu();
        System.Media.SoundPlayer sndGood = new System.Media.SoundPlayer(Properties.Resources.Goeie_more);

        System.Media.SoundPlayer btnCorrect = new System.Media.SoundPlayer(Properties.Resources.Correct);
        System.Media.SoundPlayer btnWrong = new System.Media.SoundPlayer(Properties.Resources.Wrong);

        System.Media.SoundPlayer btnWon = new System.Media.SoundPlayer(Properties.Resources.Won);
        System.Media.SoundPlayer btnLost = new System.Media.SoundPlayer(Properties.Resources.Lost);

        System.Media.SoundPlayer sndWelkom = new System.Media.SoundPlayer(Properties.Resources.Welkom);

        System.Media.SoundPlayer btnHow = new System.Media.SoundPlayer(Properties.Resources.Hoe_gaan_Dit);
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);
        public void Verify()
        {
           

            if (btnSound2IsClicked)
            {
                btnCorrect.Play();
                scoreG += 1;

                lblScore.Text = scoreG.ToString();
                mainMenu.scoreG = scoreG;

                if (scoreG == 3)
                {
                    MessageBox.Show("That was correct! ");
                    btnWon.PlayLooping();
                }
                else
                {
                    MessageBox.Show("You didn't do so well ");
                    btnLost.PlayLooping();
                }
               

                btnCheck.Visible = false;
                btnContinue.Visible = true;

                
            }
            else
            {
                btnWrong.Play();
                MessageBox.Show("That was inncorrect the correct answer was: " + "Hoe gaan dit?");
                scoreG += 0;

                btnContinue.Visible = true;
                btnCheck.Visible = false;
              

            }


        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Verify();

          
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            frmMainMenu mainMenu = new frmMainMenu();

            mainMenu.Show();
            this.Hide();
        }

        private void btnSound1_Click(object sender, EventArgs e)
        {
            sndGood.Play();
            btnCheck.Enabled = true;
            btnSound1IsClicked = true;
        }

        private void btnSound2_Click(object sender, EventArgs e)
        {
            btnHow.Play();
            btnSound2IsClicked = true;
            btnCheck.Enabled = true;
            
        }

        private void btnSound3_Click(object sender, EventArgs e)
        {
            sndWelkom.Play();
            btnCheck.Enabled = true;
            btnSound3IsClicked = true;
        }

        private void LearnGreetingsRound2_Load(object sender, EventArgs e)
        {
            lblScore.Text = scoreG.ToString();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnClick.Play();
           mainMenu.Show();
            this.Hide();
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void lblHighscore_Click(object sender, EventArgs e)
        {

        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            btnHow.Play();
           
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnLost.Stop();
            btnWon.Stop();
        }
    }
}
