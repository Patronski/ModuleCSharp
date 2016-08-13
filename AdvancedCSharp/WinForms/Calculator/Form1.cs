using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string operandOne;
        private string operationPerformed = "";
        private bool isAfterEqual;
        private bool isAfterOperation;
        private bool isAfterMinusOperator;

        public Form1()
        {
            InitializeComponent();
            this.EnableCalculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisableCalculator()
        {
            this.buttonOn.Show();
            this.buttonOff.Hide();
            this.textBoxResult.Text = string.Empty;
            this.operandOne = string.Empty;
            this.labelOperation.Text = string.Empty;
            this.operationPerformed = string.Empty;
            this.isAfterEqual = false;
            this.isAfterOperation = false;
            this.isAfterMinusOperator = false;

            this.textBoxResult.Enabled = false;
            this.buttonEqual.Enabled = false;
            this.buttonC.Enabled = false;
            this.buttonCE.Enabled = false;
            this.buttonDot.Enabled = false;
            this.buttonZero.Enabled = false;
            this.buttonOne.Enabled = false;
            this.buttonTwo.Enabled = false;
            this.buttonThree.Enabled = false;
            this.buttonFour.Enabled = false;
            this.buttonFive.Enabled = false;
            this.buttonSix.Enabled = false;
            this.buttonSeven.Enabled = false;
            this.buttonEight.Enabled = false;
            this.buttonNine.Enabled = false;
            this.buttonOperatorDivide.Enabled = false;
            this.buttonOperatorMultiply.Enabled = false;
            this.buttonOperatorPlus.Enabled = false;
            this.buttonOperatorMinus.Enabled = false;
        }

        private void EnableCalculator()
        {
            this.buttonOff.Show();
            this.buttonOn.Hide();
            this.textBoxResult.Text = "0";
            this.textBoxResult.Enabled = true;
            this.buttonEqual.Enabled = true;
            this.buttonC.Enabled = true;
            this.buttonCE.Enabled = true;
            this.buttonDot.Enabled = true;
            this.buttonZero.Enabled = true;
            this.buttonOne.Enabled = true;
            this.buttonTwo.Enabled = true;
            this.buttonThree.Enabled = true;
            this.buttonFour.Enabled = true;
            this.buttonFive.Enabled = true;
            this.buttonSix.Enabled = true;
            this.buttonSeven.Enabled = true;
            this.buttonEight.Enabled = true;
            this.buttonNine.Enabled = true;
            this.buttonOperatorDivide.Enabled = true;
            this.buttonOperatorMultiply.Enabled = true;
            this.buttonOperatorPlus.Enabled = true;
            this.buttonOperatorMinus.Enabled = true;
        }

        private void buttonNumberClick(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" || isAfterEqual || isAfterOperation)
            {
                textBoxResult.Clear();
            }
            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;

            this.isAfterOperation = false;
            this.isAfterEqual = false;
            this.isAfterMinusOperator = false;
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "-"
                && (textBoxResult.Text == string.Empty || textBoxResult.Text == "0"))
            {
                textBoxResult.Text = "-";
                this.isAfterEqual = false;
                this.isAfterMinusOperator = false;
                this.isAfterMinusOperator = true;
                return;
            }
            
            if (this.operandOne != string.Empty
                && this.operationPerformed != string.Empty)
            {
                this.isAfterOperation = true;
                this.buttonEqual.PerformClick();
            }
            
            operandOne = this.textBoxResult.Text;

            operationPerformed = button.Text;
            labelOperation.Text = operandOne
                    + " " + operationPerformed;
            this.isAfterEqual = false;
            this.isAfterMinusOperator = false;
            this.isAfterOperation = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (operationPerformed == string.Empty
                || textBoxResult.Text == string.Empty
                || isAfterEqual || isAfterMinusOperator)
            {
                return;
            }

            double numOne = double.Parse(operandOne);
            double numTwo = double.Parse(this.textBoxResult.Text);
            switch (operationPerformed)
            {
                case "+":
                    this.textBoxResult.Text = (numOne + numTwo).ToString();
                    break;
                case "-":
                    this.textBoxResult.Text = (numOne - numTwo).ToString();
                    break;
                case "×":
                    this.textBoxResult.Text = (numOne * numTwo).ToString();
                    break;
                case "÷":
                    this.textBoxResult.Text = (numOne / numTwo).ToString();
                    break;
            }

            this.operandOne = this.textBoxResult.Text;
            this.labelOperation.Text = string.Empty;
            this.operationPerformed = string.Empty;
            this.isAfterEqual = true;
            this.isAfterOperation = false;
        }

        private void buttonDotClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxResult.Text))
            {
                return;
            }
            Button button = (Button)sender;
            if (!textBoxResult.Text.Contains("."))
            {
                textBoxResult.Text = textBoxResult.Text + button.Text;
                this.isAfterOperation = false;
                this.isAfterMinusOperator = false;
                this.isAfterEqual = false;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            operandOne = string.Empty;
            labelOperation.Text = string.Empty;
            this.operationPerformed = string.Empty;
            this.isAfterEqual = false;
            this.isAfterOperation = false;
            this.isAfterMinusOperator = false;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length > 0)
            {
                textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1);
            }
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "0";
            }

            this.isAfterEqual = false;
            this.isAfterMinusOperator = false;
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            this.EnableCalculator();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            this.DisableCalculator();
        }
    }
}
