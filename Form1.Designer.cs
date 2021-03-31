
namespace In_class_Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRollADice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // buttonRollADice
            // 
            this.buttonRollADice.Location = new System.Drawing.Point(92, 167);
            this.buttonRollADice.Name = "buttonRollADice";
            this.buttonRollADice.Size = new System.Drawing.Size(166, 63);
            this.buttonRollADice.TabIndex = 1;
            this.buttonRollADice.Text = "Roll-A-Dice";
            this.buttonRollADice.UseVisualStyleBackColor = true;
            this.buttonRollADice.Click += new System.EventHandler(this.buttonRollADice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 280);
            this.Controls.Add(this.buttonRollADice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DiceRoll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRollADice;
    }
}

