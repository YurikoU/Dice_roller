/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due Date: April 9, 2021
In-class Assignment 2
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Timer timer = new Timer();
            timer.Interval = 1000;

            if (!diceIsRolling)
            {
                diceIsRolling = true;
                timer.Enabled = true;

                while (timer.Enabled == true)
                { 
                    buttonRollADice.Text = "Rolling it !!";
                    label1.Text = Convert.ToString(random.Next(1, 7));
                }
            }
                else
            {
                diceIsRolling = false;
                timer.Enabled = false;
                buttonRollADice.Text = "Roll-A-Dice";
            }
        }
    }
}
