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
    public partial class IMRound1 : Form
    {
        public IMRound1()
        {
            InitializeComponent();
           
        }
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);

        System.Media.SoundPlayer btnCorrect = new System.Media.SoundPlayer(Properties.Resources.Correct);
        System.Media.SoundPlayer btnWrong = new System.Media.SoundPlayer(Properties.Resources.Wrong);
        bool btnOption4IsClicked;
        int clicked = 0;
        int attempts = 3;
        

        public int scoreG = 0;
        IMRound2 Round2 = new IMRound2();

        public void Verify()
        {
            if (btnOption4IsClicked)
            {
                btnCorrect.Play();
                scoreG += 1;
                lblScore.Text = scoreG.ToString();
                btnOption1.Enabled = false;
                btnOption2.Enabled = false;
                btnOption3.Enabled = false;

                Round2.scoreG = scoreG;
                btnContinue.Visible = true;

            }
            else
            {
                btnWrong.Play();
                MessageBox.Show("That is not correct\nAttempts left: " + (attempts - clicked).ToString());

            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            clicked++;
            btnClick.Play();
            Verify();
            

            if (clicked == 3)
            {
                MessageBox.Show("Attempts maxed out");
                scoreG += 0;

                btnOption1.Enabled = false;
                btnOption2.Enabled = false;
                btnOption3.Enabled = false;
                btnOption4.Enabled = false;

                Round2.scoreG = scoreG;


                btnContinue.Visible = true;
                btnCheck.Enabled = false;
            }
           
           
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
            Round2.Show();
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
            btnOption4IsClicked = true;
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }
    }
}
