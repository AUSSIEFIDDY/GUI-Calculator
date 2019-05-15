using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * GUI Calculator
 * Author:  Thomas Green
 * ID:      P460247
 * Date:    01/04/2019
 * Version: 1.0 
 */

namespace GUI_Calculator
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        //Totals to be used in calculations.
        double total1 = 0;
        double total2 = 0;

        //Boolean values for the button clicks.
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        //Button Click methods that add the relevant number into 
        //the Display when the user clicks a number. 
        private void Btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn0.Text;
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn1.Text;
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn2.Text;
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn3.Text;
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn4.Text;
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn5.Text;
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn6.Text;
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn7.Text;
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn8.Text;
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn9.Text;
        }

        //Button Click clear method that clears the Display.
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        //Button Click method to add a decimal point to the Display.
        private void BtnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += BtnDot.Text;
        }

        //Button Click method that is used in conjuction with Equals 
        //to add two numbers.
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                total1 += double.Parse(txtDisplay.Text);
            }
            else
                return;
            txtDisplay.Clear();

            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        //Button Click method that is used in conjuction with Equals 
        //to subtract a number from another.
        private void BtnMinus_Click(object sender, EventArgs e)
        {

            if (txtDisplay.Text != "")
            {
                total1 += double.Parse(txtDisplay.Text);
            }
            else
                return;
            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        //Button Click method that is used in conjuction with Equals 
        //to divide a number by another.
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                total1 += double.Parse(txtDisplay.Text);
            }
            else
                return;
            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
        }

        //Button Click method that is used in conjuction with Equals 
        //to multiply a number by another.
        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                total1 += double.Parse(txtDisplay.Text);
            }
            else
                return;
            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
        }

        //Button Click method that is used return the result 
        //of a calculation and display it on the Display.
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked == true
                && txtDisplay.Text != "")
            {
                total2 = ArithMath.Arithmetic.Add(total1,
                    double.Parse(txtDisplay.Text));
            }
            else if (minusButtonClicked == true
                && txtDisplay.Text != "")
            {
                total2 = ArithMath.Arithmetic.Sub(total1,
                    double.Parse(txtDisplay.Text));
            }
            else if (divideButtonClicked == true
                && txtDisplay.Text != "")
            {
                total2 = ArithMath.Arithmetic.Div(total1,
                    double.Parse(txtDisplay.Text));
            }
            else if (multiplyButtonClicked == true
                && txtDisplay.Text != "")
            {
                total2 = ArithMath.Arithmetic.Mult(total1,
                    double.Parse(txtDisplay.Text));
            }

            //If the user tries to divide by zero
            if (double.IsNaN(total2))
            {
                MessageBox.Show("Cannot divide by zero.",
                    "Error Message");
                ResetValues();
                return;
            }
            txtDisplay.Text = total2.ToString();
            ResetValues();
        }

        //Button Click method that returns the Square Root of a 
        //number to the Display.
        private void BtnSQRT_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    txtDisplay.Text = AlgebraicMath.Algebraic.
                        Sqrt(num).ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive",
                        "Error Message");
                    txtDisplay.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.",
                    "Error Message");
            }
        }

        //Button Click method that returns the Cube Root of a number 
        //to the Display.
        private void BtnCBRT_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                if (num >= 0)
                {
                    txtDisplay.Text = AlgebraicMath.Algebraic.
                        Cbrt(num).ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive",
                        "Error Message");
                    txtDisplay.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.",
                    "Error Message");
            }
        }

        //Button Click method that returns the Inverse of a number 
        //to the Display.
        private void BtnInv_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                if (AlgebraicMath.Algebraic.Inv(num) != 0)
                {
                    txtDisplay.Text = AlgebraicMath.Algebraic.
                        Inv(num).ToString();
                }
                else
                {
                    txtDisplay.Text = "";
                    MessageBox.Show("Invalid Input.",
                        "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.",
                    "Error Message");
            }
        }

        //Button Click method that returns the Tangent of a number 
        //to the Display.
        private void BtnTan_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                if (num != 90)
                {
                    txtDisplay.Text = TrigMath.Trigonomic.
                        Tan(num).ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Input.",
                        "Error Message");
                    txtDisplay.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.",
                    "Error Message");
            }
        }

        //Button Clickmethod that returns the Sine of a number to 
        //the Display.
        private void BtnSin_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                txtDisplay.Text = TrigMath.Trigonomic.
                    Sin(num).ToString();
            }
            else
            {
                MessageBox.Show("Please enter a number.",
                    "Error Message");
            }
        }

        //Button Click method that returns the Cosine of a number 
        //to the Display.
        private void BtnCos_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                txtDisplay.Text = TrigMath.Trigonomic.
                    Cos(num).ToString();
            }
            else
            {
                MessageBox.Show("Please enter a number.",
                    "Error Message");
            }
        }

        //ResetValues method to reset all of the calculation values
        private void ResetValues()
        {
            total1 = 0;
            total2 = 0;
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        //QuitToolStripMenuItem Click method that Exits the program when clicked.
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        //ClearToolStripMenuItem Click method that clears the Display when clicked.
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}
