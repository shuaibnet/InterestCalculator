using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class InterestCalculatorUI : Form
    {
        public InterestCalculatorUI()
        {
            InitializeComponent();
        }

        private double principal;
        private double interestRate;
        private int PerYear ;
        private double years;
        private double totalAmount;
        public TextBox InterestRateTextBox
        {
            get { return interestRateTextBox; }
            set { interestRateTextBox = value; }
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            principal = Convert.ToInt32(PrincipalTextBox.Text);
            interestRate = Convert.ToDouble(interestRateTextBox.Text)/100;
            
            years = Convert.ToDouble(TimeTextBox.Text);

            totalAmount = CompoundInterest(principal, interestRate, years);
            TotalAmountTextBox.Text = totalAmount.ToString();

        }

        static double CompoundInterest(double principal,double interestRate,double years)
        {
            double body = 1 + interestRate;

            return principal * (Math.Pow(body, years));
        }
    }
}
