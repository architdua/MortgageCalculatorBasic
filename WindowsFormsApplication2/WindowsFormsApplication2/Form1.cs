using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                //get value from pV textbox
                double doubleConverter; // dummy variable used for parsing/error handling
                double propertyValue;
                double annualInterestRate;
                double loanDuration;
                double downPaymentPercent;

                if (double.TryParse(txtPropertyVal.Text, out doubleConverter))
                {
                    propertyValue = doubleConverter;
                }
                else
                {
                    errorMessage();
                    txtPropertyVal.Focus();
                    txtPropertyVal.Text= String.Empty;
                    return;
                }
                //get value from aIR textbox
                if (double.TryParse(txtAnnualInterestRate.Text, out doubleConverter))
                {
                    annualInterestRate = doubleConverter;
                }
                else
                {
                    errorMessage();
                    txtAnnualInterestRate.Focus();
                    txtAnnualInterestRate.Text = String.Empty;
                    return;
                }
                // get value from lD textbox
                
                if (double.TryParse(txtLoanDuration.Text, out doubleConverter))
                {
                    loanDuration = doubleConverter;
                }
                else
                {
                    errorMessage();
                    txtLoanDuration.Focus();
                    txtLoanDuration.Text = String.Empty;
                    return;
                }
                //get value for dP textbox
                if (double.TryParse(txtDownPayment.Text, out doubleConverter))
                {
                    downPaymentPercent = doubleConverter;
                }
                else
                {
                    errorMessage();
                    txtDownPayment.Focus();
                    txtDownPayment.Text = String.Empty;
                    return;
                }

                double downPayment = downPaymentCalc(propertyValue, downPaymentPercent);
                double loanPayment = loanPaymentCalc(propertyValue, downPayment);
                double monthlyInterestRate = monthlyIRCalc(annualInterestRate);
                double monthPayment = monthPaymentCalc(loanPayment, monthlyInterestRate, loanDuration);
                MessageBox.Show("Your monthly payment is " + monthPayment.ToString("C2"), "Monthly Payment");

                clearInputFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void errorMessage()
        {
            MessageBox.Show("Input not valid. Please enter values that correspond to the field");
        }

        private double downPaymentCalc(double propertyValue, double downPaymentPercent)
        {
            double downPayment = downPaymentPercent / 100 * propertyValue;
            return downPayment; 
        }

        private double loanPaymentCalc(double propertyValue, double downPayment)
        {
            double loanPayment = propertyValue - downPayment;
            return loanPayment; 
        }
        private double monthlyIRCalc(double annualInterestRate)
        {
            double monthlyIR = annualInterestRate /100 / 12;
            return monthlyIR;
        }
        private double monthPaymentCalc(double loanPayment, double monthlyInterestRate, double loanDuration)
        {
            double monthPayment = loanPayment * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, loanDuration * 12));
            return monthPayment;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInputFields();

        }
        private void clearInputFields()
        {
            txtPropertyVal.Text = String.Empty;
            txtAnnualInterestRate.Text = String.Empty;
            txtLoanDuration.Text = String.Empty;
            txtDownPayment.Text = String.Empty;

        }
    }
}
