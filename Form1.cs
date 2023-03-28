using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(inputBox1.Text);
                double num2 = double.Parse(inputBox2.Text);
                double result = num1 + num2;
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(inputBox1.Text);
                double num2 = double.Parse(inputBox2.Text);
                double result = num1 - num2;
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(inputBox1.Text);
                double num2 = double.Parse(inputBox2.Text);
                double result = num1 * num2;
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(inputBox1.Text);
                double num2 = double.Parse(inputBox2.Text);
                double result = num1 / num2;
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
