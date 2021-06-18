﻿using System;
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
    public partial class PhrasesRound1 : Form
    {
        public PhrasesRound1()
        {
            InitializeComponent();
           
        }

        bool btnOptionOneIsClicked;
        bool btnOptionTwoIsClicked;
        bool btnOptionThreeIsClicked;
        bool btnOptionFourIsClicked;


        int clicks = 0;
        int attempts = 4;

        public int scoreG = 0;
        PhrasesRound2 Round2 = new PhrasesRound2();
        System.Media.SoundPlayer btnCorrect = new System.Media.SoundPlayer(Properties.Resources.Correct);
        System.Media.SoundPlayer btnWrong = new System.Media.SoundPlayer(Properties.Resources.Wrong);
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);
        public void Verify()
        {

            if (btnOptionOneIsClicked)
            {
                btnCorrect.Play();
                scoreG += 1;
                Round2.scoreG = scoreG;

                lblScore.Text = scoreG.ToString();
                MessageBox.Show("That is correct!");

                btnContinue.Visible = true;
                btnCheck.Visible = false;
             
            }
            else 
            {
                btnWrong.Play();
                MessageBox.Show("That is not correct\nAttempts left: " + (attempts - clicks).ToString());
            }
            

        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            clicks++;
            btnClick.Play();
            Verify();
            
            if (clicks == 4)
            {
                MessageBox.Show("Attempts maxed out\nCorrect answer was 'I'm driving the car'");
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
            btnOptionOneIsClicked = true;

            
        }

        private void btnSound2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
            btnOptionTwoIsClicked = true ;
           
        }

        private void btnSound3_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
           btnOptionThreeIsClicked = true;
            
        }

        private void LearnGreetingsRound2_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("If your struggling to figure out the answer , hit the translate button to help.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            btnOptionFourIsClicked = true;
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Round2.Show();
           this.Hide();
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnOptionOneIsClicked = true;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
           
                lblPhrase.Text = "Ek ry die car";
                btnRET.Visible = false;
                btnTranslate.Visible = true;
            
           
        }

        private void btnTranslate_Click_1(object sender, EventArgs e)
        {
            btnClick.Play();
            lblPhrase.Text = "I'm driving the car";
            btnTranslate.Visible = false;
            btnRET.Visible = true;
           
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }
    }
}
