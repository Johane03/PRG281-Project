using Loan_Application_System_PRG281;
/* 
Johané Badenhorst 577401
Janita de Vries	577698
Zeldene van Vüren 577115
Walter  Nienaber 577297
Stefan  Sutherland 577574
*/
namespace ProjectV2
{
    public partial class Form1 : Form
    {
        public BindingSource bs = new BindingSource();
        List<Loan> loans = new List<Loan>();
        private void createLoan(string loanNumber, string customerLastName, string customerFirstName, double loanAmount, int loanTerm, double interestRate, char loanType)
        {
            if (loanType == 'B')
            {
                BusinessLoan bl = new BusinessLoan(loanNumber, customerLastName, customerFirstName, loanAmount, loanTerm, interestRate);
                bl.InterestRate = bl.CalculateInterestRate(0.5);
                loans.Add(bl);
            }
            else if (loanType == 'P')
            {
                PersonalLoan pl = new PersonalLoan(loanNumber, customerLastName, customerFirstName, loanAmount, loanTerm, interestRate);
                pl.InterestRate = pl.CalculateInterestRate(0.2);
                loans.Add(pl);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Thread displayTime = new Thread(TimeDisplay);
            displayTime.Start();




            createLoan("76", "Jenkins", "Lui", 20000, 3, 5, 'B');
            createLoan("09", "Powell", "Jenna", 12000, 5, 5, 'P');
            bs.DataSource = loans;
            dgvdisplay.DataSource = "";
            dgvdisplay.DataSource = bs;

        }
        private void TimeDisplay()
        {
            while (true)
            {
                UpdateTime();
                Thread.Sleep(1000);
            }
        }
        private void UpdateTime()
        {
            if (lbTime.InvokeRequired)
            {
                lbTime.Invoke(new Action(UpdateTime));
            }
            else lbTime.Text = System.DateTime.Now.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPrimeInterestRate_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrimeInterestRate.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPrimeInterestRate.Text = txtPrimeInterestRate.Text.Remove(txtPrimeInterestRate.Text.Length - 1);
            }
        }

        private void BtnNewLoan_Click(object sender, EventArgs e)
        {
            char loanType = new char();
            if (cmbLoanType.SelectedIndex == 0)
            {
                loanType = 'B';
            }
            else
            {
                loanType = 'P';
            }

            int loanTerm = new int();
            switch (cmbLoanTerm.SelectedIndex)
            {
                case 0:
                    loanTerm = 1;
                    break;
                case 1:
                    loanTerm = 3;
                    break;
                case 2:
                    loanTerm = 5;
                    break;
                default:
                    break;
            }
            foreach (var item in loans)
            {
                while (txtFirstName.Text == item.CustomerFirstName1)
                {
                    MessageBox.Show("User already exists");
                    return;
                }

            }
            createLoan(txtLoanAmount.Text, txtLastName.Text, txtFirstName.Text, Convert.ToDouble(txtPrimeInterestRate.Text), Convert.ToInt32(txtLoanAmount.Text), loanTerm, loanType);
            bs.DataSource = loans;
            dgvdisplay.DataSource = "";
            dgvdisplay.DataSource = bs;

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtLoanAmount.Text = "";
            cmbLoanTerm.Text = "";
            cmbLoanType.Text = "";
            txtPrimeInterestRate.Text = "";


        }

        private void txtLoanAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLoanAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtLoanAmount.Text = txtLoanAmount.Text.Remove(txtLoanAmount.Text.Length - 1);
            }
        }
    }
}