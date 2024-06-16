namespace ProjectV2
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
            Label lbHead;
            lbTime = new Label();
            dgvdisplay = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cmbLoanType = new ComboBox();
            label5 = new Label();
            txtPrimeInterestRate = new TextBox();
            label4 = new Label();
            cmbLoanTerm = new ComboBox();
            label3 = new Label();
            txtLoanAmount = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnNewLoan = new Button();
            lbHead = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdisplay).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbHead
            // 
            lbHead.AutoSize = true;
            lbHead.Font = new Font("Segoe UI", 21.75F, FontStyle.Underline, GraphicsUnit.Point);
            lbHead.ForeColor = Color.Red;
            lbHead.Location = new Point(12, 28);
            lbHead.Name = "lbHead";
            lbHead.Size = new Size(330, 40);
            lbHead.TabIndex = 0;
            lbHead.Text = "Loan Application System";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.Location = new Point(382, 48);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(43, 21);
            lbTime.TabIndex = 1;
            lbTime.Text = "0:0:0";
            lbTime.Click += lbTime_Click;
            // 
            // dgvdisplay
            // 
            dgvdisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdisplay.Location = new Point(12, 81);
            dgvdisplay.Name = "dgvdisplay";
            dgvdisplay.RowTemplate.Height = 25;
            dgvdisplay.Size = new Size(649, 156);
            dgvdisplay.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbLoanType);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrimeInterestRate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbLoanTerm);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLoanAmount);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(btnNewLoan);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(12, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 133);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Loan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 70);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 12;
            label6.Text = "Type Of Loan";
            // 
            // cmbLoanType
            // 
            cmbLoanType.FormattingEnabled = true;
            cmbLoanType.Items.AddRange(new object[] { "Business Loan", "Personal Loan" });
            cmbLoanType.Location = new Point(133, 89);
            cmbLoanType.Name = "cmbLoanType";
            cmbLoanType.Size = new Size(121, 23);
            cmbLoanType.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 71);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 10;
            label5.Text = "Prime Interest Rate";
            // 
            // txtPrimeInterestRate
            // 
            txtPrimeInterestRate.Location = new Point(260, 89);
            txtPrimeInterestRate.Name = "txtPrimeInterestRate";
            txtPrimeInterestRate.Size = new Size(100, 23);
            txtPrimeInterestRate.TabIndex = 9;
            txtPrimeInterestRate.TextChanged += txtPrimeInterestRate_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 70);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "Loan Term";
            // 
            // cmbLoanTerm
            // 
            cmbLoanTerm.FormattingEnabled = true;
            cmbLoanTerm.Items.AddRange(new object[] { "Short-Term (1 Year)", "Medium Term (3 Years)", "Long-Term (5 Years)" });
            cmbLoanTerm.Location = new Point(6, 89);
            cmbLoanTerm.Name = "cmbLoanTerm";
            cmbLoanTerm.Size = new Size(121, 23);
            cmbLoanTerm.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 27);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 6;
            label3.Text = "Loan Amount";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(218, 45);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(100, 23);
            txtLoanAmount.TabIndex = 5;
            txtLoanAmount.TextChanged += txtLoanAmount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 25);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 45);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(6, 45);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // btnNewLoan
            // 
            btnNewLoan.Location = new Point(513, 27);
            btnNewLoan.Name = "btnNewLoan";
            btnNewLoan.Size = new Size(110, 85);
            btnNewLoan.TabIndex = 0;
            btnNewLoan.Text = "Create Loan";
            btnNewLoan.UseVisualStyleBackColor = true;
            btnNewLoan.Click += BtnNewLoan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvdisplay);
            Controls.Add(lbTime);
            Controls.Add(lbHead);
            ForeColor = Color.Crimson;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdisplay).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTime;
        private DataGridView dgvdisplay;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnNewLoan;
        private Label label3;
        private TextBox txtLoanAmount;
        private Label label4;
        private ComboBox cmbLoanTerm;
        private TextBox txtPrimeInterestRate;
        private Label label5;
        private Label label6;
        private ComboBox cmbLoanType;
    }
}