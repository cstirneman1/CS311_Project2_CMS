namespace Craps
{
    public partial class Craps : Form
    {
        private Boolean point = false;
        private int points = 0;
        public Craps()
        {
            InitializeComponent();
        }//end constructor


        private void calculate_Score()
        {

            string bankLabelText = lblBank.Text.Replace("Bank: $", ""); // Removes "Bank: $" from the label text
            double currentBalance = double.Parse(bankLabelText);
            double currentBet = double.Parse(txtBet.Text);

            if (currentBalance < currentBet)
            {
                txtBet.Text = "Not enough money to place bet!";
            }

            else
            {
                Random rand = new Random();
                int dieRoll1 = rand.Next(1, 7);
                int dieRoll2 = rand.Next(1, 7);
                int dieSum = dieRoll1 + dieRoll2;

                lblDice1.Text = "Die 1 Value: " + dieRoll1;
                lblDice2.Text = "Die 2 Value: " + dieRoll2;

                if (!point)
                {
                    switch (dieSum)
                    {
                        case 7:
                        case 11:
                            lblOutcome.Text = "You Win!";
                            double betAmountWin = double.Parse(txtBet.Text);
                            double currentBalanceWin = double.Parse(lblBank.Text.Replace("Bank: $", ""));
                            double newBalanceWin = currentBalanceWin + betAmountWin;
                            lblBank.Text = "Bank: $" + newBalanceWin.ToString("F2");
                            break;

                        case 2:
                        case 3:
                        case 12:
                            lblOutcome.Text = "You Lose!";
                            double betAmountLose = double.Parse(txtBet.Text);
                            double currentBalanceLose = double.Parse(lblBank.Text.Replace("Bank: $", ""));
                            double newBalanceLose = currentBalanceLose - betAmountLose;
                            lblBank.Text = "Bank: $" + newBalanceLose.ToString("F2");//updates bank, formated to 2 decimal places(F2)
                            break;

                        default:
                            lblOutcome.Text = "Point outcome: " + dieSum;
                            points = dieSum;
                            point = true;
                            break;
                    }//end switch statement

                }//end if !point

                else
                {
                    switch (dieSum)
                    {
                        case 7:
                            lblOutcome.Text = "You Lose!";
                            point = false;
                            double betAmountLose = double.Parse(txtBet.Text);
                            double currentBalanceLose = double.Parse(lblBank.Text.Replace("Bank: $", ""));
                            double newBalanceLose = currentBalanceLose - betAmountLose;
                            lblBank.Text = "Bank: $" + newBalanceLose.ToString("F2");
                            break;

                        default:
                            if (dieSum == points)
                            {
                                lblOutcome.Text = "You Win!";
                                double betAmountWin = double.Parse(txtBet.Text);
                                double currentBalanceWin = double.Parse(lblBank.Text.Replace("Bank: $", ""));
                                double newBalanceWin = currentBalanceWin + betAmountWin;
                                lblBank.Text = "Bank: $" + newBalanceWin.ToString("F2");
                                point = false;
                            }
                            else
                            {
                                lblOutcome.Text = "Point is: " + points + ". Roll again.";
                            }
                            break;
                    }
                }
            }


        }//end calculateScore

        private void Craps_Load(object sender, EventArgs e)
        {
            double balance = 100.00;
            lblBank.Text = "Bank: " + balance.ToString("C");// initialize bank label to display $100
        }//end Craps load

        private void btnRoll_Click(object sender, EventArgs e)
        {
            calculate_Score();
        }


    }//end form

}//end namespace