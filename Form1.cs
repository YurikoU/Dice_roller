/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due Date: April 9, 2021
In-class Assignment 2
*/


using In_class_Assignment2.Properties;
using System;
using System.Windows.Forms;


namespace In_class_Assignment2
{
    public partial class Form1 : Form
    {
        public bool diceIsRolling = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRollADice_Click(object sender, EventArgs e)
        {
            if (!diceIsRolling)
            {  
                //If the dice paused when a user clicked the button
                diceIsRolling = true;
                timer1.Enabled = true;
                timer1.Start();
                buttonRollADice.Text = "Rolling it !!";
            }
            else 
            {
                //If the dice was rolling
                diceIsRolling = false;
                timer1.Enabled = false;
                timer1.Stop();
                buttonRollADice.Text = "Roll-A-Dice";
            }
        }


        //Wile the timer is enabled
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Display a random number by 0.3 second
            label1.Text = Convert.ToString(random.Next(1, 7));

            //Display a proper dice face based on the random number
            switch (label1.Text)
            {
                case "1":
                    pictureBox1.Image = Resources.dice1;
                    break;
                case "2":
                    pictureBox1.Image = Resources.dice2;
                    break;
                case "3":
                    pictureBox1.Image = Resources.dice3;
                    break;
                case "4":
                    pictureBox1.Image = Resources.dice4;
                    break;
                case "5":
                    pictureBox1.Image = Resources.dice5;
                    break;
                case "6":
                    pictureBox1.Image = Resources.dice6;
                    break;
            }
        }
    }
}
