using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageLearningGame
{
    public partial class QuizGame : Form
    {
        int TotalAnswers;
        int Questions = 1;
        int Answer;
        int Total;
        public QuizGame()
        {
            InitializeComponent();

            Questioning(Questions);

            Total = 10;
        }
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);
        private void Questioning(int QuestionNUmber)
        {
            switch (QuestionNUmber)
            {
                case 1:

                    lblQuestion.Text = "It is used for long distance";

                    button1.BackgroundImage = Properties.Resources.car1;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Kar";

                    button2.BackgroundImage = Properties.Resources.human;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Mens";

                    button3.BackgroundImage = Properties.Resources.buikding;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Gebou";

                    button4.BackgroundImage = Properties.Resources.tree;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Boom";

                    Answer = 1;

                    break;
                case 2:

                    lblQuestion.Text = "Used to drink coffee out of";

                    button1.BackgroundImage = Properties.Resources.Glass;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Glas";

                    button2.BackgroundImage = Properties.Resources.cup;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Beker";

                    button3.BackgroundImage = Properties.Resources.dish;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Skottel";

                    button4.BackgroundImage = Properties.Resources.spoon;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Lepel";

                    Answer = 2;

                    break;
                case 3:

                    lblQuestion.Text = "Used to sleep on";


                    button1.BackgroundImage = Properties.Resources.fridge;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Yskas";

                    button2.BackgroundImage = Properties.Resources.closet;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Kas";

                    button3.BackgroundImage = Properties.Resources.table;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Tafel";

                    button4.BackgroundImage = Properties.Resources.bed;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Bed";

                    Answer = 4;

                    break;
                case 4:

                    lblQuestion.Text = "Device used to watch movies or shows";

                    button1.BackgroundImage = Properties.Resources.remote;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Afstandbeheer";

                    button2.BackgroundImage = Properties.Resources.radio;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Radio";

                    button3.BackgroundImage = Properties.Resources.controller;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Beheerder";

                    button4.BackgroundImage = Properties.Resources.TV;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Televisie";

                    Answer = 3;

                    break;

                case 5:

                    lblQuestion.Text = "Used for communcation between people";


                    button1.BackgroundImage = Properties.Resources.phone;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Foon";

                    button2.BackgroundImage = Properties.Resources.charger;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Laaier";

                    button3.BackgroundImage = Properties.Resources.car1;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Kar";

                    button4.BackgroundImage = Properties.Resources.fridge;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Yskas";

                    Answer = 1;

                    break;

                case 6:

                    lblQuestion.Text = "Used to put clothes in";

                    button1.BackgroundImage = Properties.Resources.bed;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Bed";

                    button2.BackgroundImage = Properties.Resources.Glass;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Glas";

                    button3.BackgroundImage = Properties.Resources.closet;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Kas";

                    button4.BackgroundImage = Properties.Resources.TV;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Televisie";

                    Answer = 3;

                    break;

                case 7:

                    lblQuestion.Text = "Can be used to store food";

                    button1.BackgroundImage = Properties.Resources.dish;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Dish";

                    button2.BackgroundImage = Properties.Resources.couch;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Rusbank";

                    button3.BackgroundImage = Properties.Resources.fridge;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Lepel";

                    button4.BackgroundImage = Properties.Resources.spoon;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Yskas";

                    Answer = 3;

                    break;


                case 8:

                    lblQuestion.Text = "Used to sit on";

                    button1.BackgroundImage = Properties.Resources.car1;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Kar";

                    button2.BackgroundImage = Properties.Resources.couch;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Rusbank";

                    button3.BackgroundImage = Properties.Resources.TV;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Televisie";

                    button4.BackgroundImage = Properties.Resources.spoon;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Yskas";

                    Answer = 3;

                    break;

                case 9:

                    lblQuestion.Text = "Used to recharge a phones battery";

                    button1.BackgroundImage = Properties.Resources.Glass;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Glas";

                    button2.BackgroundImage = Properties.Resources.charger;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Laaier";

                    button3.BackgroundImage = Properties.Resources.buikding;

                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Gebou";

                    button4.BackgroundImage = Properties.Resources.phone;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Foon";

                    Answer = 2;

                    break;

                case 10:

                    lblQuestion.Text = "Used to change channels on televison";

                    button1.BackgroundImage = Properties.Resources.radio;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Radio";

                    button2.BackgroundImage = Properties.Resources.bed;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Bed";

                    button3.BackgroundImage = Properties.Resources.TV;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Televisie";

                    button4.BackgroundImage = Properties.Resources.remote;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Afstandbeheer";

                    Answer = 4;

                    break;

            }

        }

        int Percentage;
        private void AnswerCheck(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            //converting a button tag from a string to integer
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == Answer) { TotalAnswers++; }
            if (Questions == Total)
            {
                //changing a percentage from double into integer
                Percentage = (int)Math.Round((double)(TotalAnswers * 100) / Total);

                MessageBox.Show

                 ("You Completed the Quiz!\n" + "Your got\t " + TotalAnswers + " questions correctly.\n"
                 + "You got \t" + Percentage + "%\n");

                TotalAnswers = 0;

                Questions = 0;

                Questioning(Questions);

            }
            Questions++;

            Questioning(Questions);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            frmMainMenu mainMenu = new frmMainMenu();

            mainMenu.Show();
            this.Hide();
        }
    }
}
