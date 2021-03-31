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

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRollADice_Click(object sender, EventArgs e)
        {
            if (!diceIsRolling)
            {
                diceIsRolling = true;
                buttonRollADice.Text = "Rolling it !!";
                Random random = new Random();
                label1.Text = Convert.ToString(random.Next(1,7));
            }
            else {
                diceIsRolling = false;
                buttonRollADice.Text = "Roll-A-Dice";
            }
        }
    }
}
