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

        private void expButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(inputBox1.Text);
                double num2 = double.Parse(inputBox2.Text);
                double result = Math.Pow(num1, num2);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(inputBox1.Text);
                double result = Math.Sqrt(num);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void absButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(inputBox1.Text);
                double result = Math.Abs(num);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void sinButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(inputBox1.Text);
                double result = Math.Sin(num);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cosButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(inputBox1.Text);
                double result = Math.Cos(num);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tanButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(inputBox1.Text);
                double result = Math.Tan(num);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(inputBox1.Text);
                double result = Math.Log10(num);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lnButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(inputBox1.Text);
                double result = Math.Log(num);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void floorButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(inputBox1.Text);
                double result = Math.Floor(num1);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ceilButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(inputBox1.Text);
                double result = Math.Ceiling(num1);
                displayBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}
