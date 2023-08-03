using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardInterestCalculator_1
{
    public partial class CreditCardInterestCalculator : Form
    {
        public CreditCardInterestCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCreditBalance.Text, out double creditBalance) &&
                double.TryParse(txtInstallmentPeriod.Text, out double installmentPeriod) &&
                double.TryParse(txtInterest.Text, out double interest))
            {
                // Calculate the monthly installment amount
                double monthlyInstallmentAmount = creditBalance / installmentPeriod;

                // Calculate the amount of interest payment per month
                double amountOfInterestPaymentPerMonth = (creditBalance / 100) * interest;


                double total = amountOfInterestPaymentPerMonth + monthlyInstallmentAmount;
                // Display the results
                lblMonthlyInstallmentAmount.Text = "Installment amount per month is : " + monthlyInstallmentAmount.ToString("C");
                lblAmountOfInterestPayment.Text = "Amount of interest payment per month is : " + amountOfInterestPaymentPerMonth.ToString("C");
                label4.Text = "Total installments per month : " + total.ToString("C");

            }
            else
            {
                MessageBox.Show("Invalid input. Please enter numeric values for all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInstallmentPeriod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
