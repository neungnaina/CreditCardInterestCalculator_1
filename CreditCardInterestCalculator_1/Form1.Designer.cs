namespace CreditCardInterestCalculator_1
{
    partial class CreditCardInterestCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreditBalance = new System.Windows.Forms.TextBox();
            this.txtInstallmentPeriod = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblMonthlyInstallmentAmount = new System.Windows.Forms.Label();
            this.lblAmountOfInterestPayment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Location = new System.Drawing.Point(319, 204);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(118, 41);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit Balance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "installmentPeriod :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(46, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "interest :";
            // 
            // txtCreditBalance
            // 
            this.txtCreditBalance.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCreditBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCreditBalance.Location = new System.Drawing.Point(167, 64);
            this.txtCreditBalance.Name = "txtCreditBalance";
            this.txtCreditBalance.Size = new System.Drawing.Size(269, 22);
            this.txtCreditBalance.TabIndex = 4;
            // 
            // txtInstallmentPeriod
            // 
            this.txtInstallmentPeriod.BackColor = System.Drawing.Color.SteelBlue;
            this.txtInstallmentPeriod.ForeColor = System.Drawing.SystemColors.Control;
            this.txtInstallmentPeriod.Location = new System.Drawing.Point(168, 100);
            this.txtInstallmentPeriod.Name = "txtInstallmentPeriod";
            this.txtInstallmentPeriod.Size = new System.Drawing.Size(269, 22);
            this.txtInstallmentPeriod.TabIndex = 5;
            this.txtInstallmentPeriod.TextChanged += new System.EventHandler(this.txtInstallmentPeriod_TextChanged);
            // 
            // txtInterest
            // 
            this.txtInterest.BackColor = System.Drawing.Color.SteelBlue;
            this.txtInterest.ForeColor = System.Drawing.SystemColors.Control;
            this.txtInterest.Location = new System.Drawing.Point(167, 141);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(269, 22);
            this.txtInterest.TabIndex = 6;
            // 
            // lblMonthlyInstallmentAmount
            // 
            this.lblMonthlyInstallmentAmount.AutoSize = true;
            this.lblMonthlyInstallmentAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMonthlyInstallmentAmount.Location = new System.Drawing.Point(46, 287);
            this.lblMonthlyInstallmentAmount.Name = "lblMonthlyInstallmentAmount";
            this.lblMonthlyInstallmentAmount.Size = new System.Drawing.Size(198, 16);
            this.lblMonthlyInstallmentAmount.TabIndex = 7;
            this.lblMonthlyInstallmentAmount.Text = "Installment amount per month is :";
            // 
            // lblAmountOfInterestPayment
            // 
            this.lblAmountOfInterestPayment.AutoSize = true;
            this.lblAmountOfInterestPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAmountOfInterestPayment.Location = new System.Drawing.Point(46, 319);
            this.lblAmountOfInterestPayment.Name = "lblAmountOfInterestPayment";
            this.lblAmountOfInterestPayment.Size = new System.Drawing.Size(248, 16);
            this.lblAmountOfInterestPayment.TabIndex = 8;
            this.lblAmountOfInterestPayment.Text = "Amount of interest payment per month is :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(46, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total installments per month :";
            // 
            // CreditCardInterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(564, 427);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAmountOfInterestPayment);
            this.Controls.Add(this.lblMonthlyInstallmentAmount);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtInstallmentPeriod);
            this.Controls.Add(this.txtCreditBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "CreditCardInterestCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditCardInterestCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreditBalance;
        private System.Windows.Forms.TextBox txtInstallmentPeriod;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblMonthlyInstallmentAmount;
        private System.Windows.Forms.Label lblAmountOfInterestPayment;
        private System.Windows.Forms.Label label4;
    }
}

