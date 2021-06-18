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
    public partial class LearnGreetingsRound2 : Form
    {
       
        public LearnGreetingsRound2()
        {
            InitializeComponent();
           
        }

        bool btnSound2IsClicked;
        bool btnSound1IsClicked;
        bool btnSound3IsClicked;
        public int scoreG = 0;
        LearnGreetingsRound3 Round3 = new LearnGreetingsRound3();

        System.Media.SoundPlayer btnCorrect = new System.Media.SoundPlayer(Properties.Resources.Correct);
        System.Media.SoundPlayer btnWrong = new System.Media.SoundPlayer(Properties.Resources.Wrong);

        System.Media.SoundPlayer sndTot = new System.Media.SoundPlayer(Properties.Resources.Totsiens);
        System.Media.SoundPlayer sndHallo = new System.Media.SoundPlayer(Properties.Resources.Hallo);
        System.Media.SoundPlayer sndWelkom = new System.Media.SoundPlayer(Properties.Resources.Welkom);
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);

        public void Verify()
        {


            if (btnSound3IsClicked)
            {
                btnCorrect.Play();
                scoreG += 1;
                lblScore.Text = scoreG.ToString();

                MessageBox.Show("That was correct! ");

                Round3.scoreG += scoreG;

                btnCheck.Visible = false;
                btnContinue.Visible = true;
                

            }
            else
            {
                btnWrong.Play();
                scoreG += 0;
                lblScore.Text = scoreG.ToString();
                MessageBox.Show("That was inncorrect the correct answer was: " + "Welkom");
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
            sndTot.Play();
            btnCheck.Enabled = true;
            btnSound1IsClicked = true;
        }

        private void btnSound2_Click(object sender, EventArgs e)
        {
            sndHallo.Play();
            btnCheck.Enabled = true;
            btnSound2IsClicked = true;
        }

        private void btnSound3_Click(object sender, EventArgs e)
        {
            sndWelkom.Play();
            btnSound3IsClicked = true;
        
            btnCheck.Enabled = true;
        }

        private void LearnGreetingsRound2_Load(object sender, EventArgs e)
        {
            lblScore.Text = scoreG.ToString();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Round3.Show();
            this.Hide();
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            sndWelkom.Play();
            
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }
    }
}
