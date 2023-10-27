namespace Craps
{
    partial class Craps
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
            lblDice1 = new Label();
            lblDice2 = new Label();
            lblBank = new Label();
            txtBet = new TextBox();
            btnRoll = new Button();
            lblOutcome = new Label();
            SuspendLayout();
            // 
            // lblDice1
            // 
            lblDice1.AutoSize = true;
            lblDice1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDice1.ForeColor = Color.White;
            lblDice1.Location = new Point(142, 254);
            lblDice1.Name = "lblDice1";
            lblDice1.Size = new Size(161, 32);
            lblDice1.TabIndex = 0;
            lblDice1.Text = "Dice 1 Value:";
            // 
            // lblDice2
            // 
            lblDice2.AutoSize = true;
            lblDice2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDice2.ForeColor = Color.White;
            lblDice2.Location = new Point(364, 254);
            lblDice2.Name = "lblDice2";
            lblDice2.Size = new Size(161, 32);
            lblDice2.TabIndex = 1;
            lblDice2.Text = "Dice 2 Value:";
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.FlatStyle = FlatStyle.Flat;
            lblBank.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBank.ForeColor = Color.White;
            lblBank.Location = new Point(560, 9);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(78, 32);
            lblBank.TabIndex = 2;
            lblBank.Text = "Bank:";
            // 
            // txtBet
            // 
            txtBet.Location = new Point(142, 74);
            txtBet.Name = "txtBet";
            txtBet.PlaceholderText = "Enter your bet";
            txtBet.Size = new Size(302, 31);
            txtBet.TabIndex = 3;
            // 
            // btnRoll
            // 
            btnRoll.Cursor = Cursors.Hand;
            btnRoll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoll.ForeColor = Color.Black;
            btnRoll.Location = new Point(142, 156);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(112, 34);
            btnRoll.TabIndex = 4;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblOutcome
            // 
            lblOutcome.AutoSize = true;
            lblOutcome.BackColor = Color.IndianRed;
            lblOutcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutcome.ForeColor = Color.White;
            lblOutcome.Location = new Point(142, 365);
            lblOutcome.Name = "lblOutcome";
            lblOutcome.Size = new Size(125, 32);
            lblOutcome.TabIndex = 5;
            lblOutcome.Text = "Outcome:";
            // 
            // Craps
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(774, 450);
            Controls.Add(lblOutcome);
            Controls.Add(btnRoll);
            Controls.Add(txtBet);
            Controls.Add(lblBank);
            Controls.Add(lblDice2);
            Controls.Add(lblDice1);
            ForeColor = Color.White;
            Name = "Craps";
            Text = "Craps";
            Load += Craps_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblDice1;
        private Label lblDice2;
        private Label lblBank;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblOutcome;
    }
}