using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private Button? addButton = null;
        private Button? subtractButton = null;
        private Button? multiplyButton = null;
        private Button? divideButton = null;
        private Button? sineButton = null;
        private Button? cosineButton = null;
        private Button? tangentButton = null;
        private Button? powerButton = null;
        private Button? floorButton = null;
        private Button? ceilingButton = null;
        private Button? sqrtButton = null;

        public CalculatorForm()
        {
            InitializeComponent();
        }
        private void CalculatorForm_Load(object? sender, EventArgs e)
        {
            // Set up the form and controls
            this.Text = "Calculator";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Create buttons for each operation
            System.Windows.Forms.Button addButton = new System.Windows.Forms.Button();
            addButton.Text = "+";
            addButton.Location = new Point(10, 10);
            addButton.Size = new Size(50, 50);
            addButton.Click += new EventHandler(addButton_Click);
            this.Controls.Add(addButton);

            System.Windows.Forms.Button subtractButton = new System.Windows.Forms.Button();
            subtractButton.Text = "-";
            subtractButton.Location = new Point(70, 10);
            subtractButton.Size = new Size(50, 50);
            subtractButton.Click += new EventHandler(subtractButton_Click);
            this.Controls.Add(subtractButton);

            System.Windows.Forms.Button multiplyButton = new System.Windows.Forms.Button();
            multiplyButton.Text = "x";
            multiplyButton.Location = new Point(130, 10);
            multiplyButton.Size = new Size(50, 50);
            multiplyButton.Click += new EventHandler(multiplyButton_Click);
            this.Controls.Add(multiplyButton);

            System.Windows.Forms.Button divideButton = new System.Windows.Forms.Button();
            divideButton.Text = "/";
            divideButton.Location = new Point(190, 10);
            divideButton.Size = new Size(50, 50);
            divideButton.Click += new EventHandler(divideButton_Click);
            this.Controls.Add(divideButton);

            System.Windows.Forms.Button sineButton = new System.Windows.Forms.Button();
            sineButton.Text = "sin";
            sineButton.Location = new Point(10, 70);
            sineButton.Size = new Size(50, 50);
            sineButton.Click += new EventHandler(sineButton_Click);
            this.Controls.Add(sineButton);

            System.Windows.Forms.Button cosineButton = new System.Windows.Forms.Button();
            cosineButton.Text = "cos";
            cosineButton.Location = new Point(70, 70);
            cosineButton.Size = new Size(50, 50);
            cosineButton.Click += new EventHandler(cosineButton_Click);
            this.Controls.Add(cosineButton);

            System.Windows.Forms.Button tangentButton = new System.Windows.Forms.Button();
            tangentButton.Text = "tan";
            tangentButton.Location = new Point(130, 70);
            tangentButton.Size = new Size(50, 50);
            tangentButton.Click += new EventHandler(tangentButton_Click);
            this.Controls.Add(tangentButton);

            System.Windows.Forms.Button powerButton = new System.Windows.Forms.Button();
            powerButton.Text = "^";
            powerButton.Location = new Point(190, 70);
            powerButton.Size = new Size(50, 50);
            powerButton.Click += new EventHandler(powerButton_Click);
            this.Controls.Add(powerButton);

            System.Windows.Forms.Button floorButton = new System.Windows.Forms.Button();
            floorButton.Text = "floor";
            floorButton.Location = new Point(10, 130);
            floorButton.Size = new Size(50, 50);
            floorButton.Click += new EventHandler(floorButton_Click);
            this.Controls.Add(floorButton);

            System.Windows.Forms.Button ceilingButton = new System.Windows.Forms.Button();
            ceilingButton.Text = "ceiling";
            ceilingButton.Location = new Point(70, 130);
            ceilingButton.Size = new Size(50, 50);
            ceilingButton.Click += new EventHandler(ceilingButton_Click);
            this.Controls.Add(ceilingButton);

            // Create a display box to show the result
            TextBox displayBox = new TextBox();
            displayBox.Location = new Point(10, 70);
            displayBox.Size = new Size(200, 30);
            displayBox.ReadOnly = true;
            this.Controls.Add(displayBox);

            // Create a panel to group the function buttons
            Panel functionPanel = new Panel();
            functionPanel.Location = new Point(10, 110);
            functionPanel.Size = new Size(200, 150);
            functionPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(functionPanel);

            // Create buttons for each function
            System.Windows.Forms.Button sqrtButton = new System.Windows.Forms.Button();
            sqrtButton.Text = "sqrt";
            sqrtButton.Location = new Point(10, 10);
            sqrtButton.Size = new Size(50, 50);
            sqrtButton.Click += new EventHandler(sqrtButton_Click);
            functionPanel.Controls.Add(sqrtButton);


        }

        private void addButton_Click(object? sender, EventArgs e)
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

        private void subtractButton_Click(object? sender, EventArgs e)
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

        private void multiplyButton_Click(object? sender, EventArgs e)
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

        private void divideButton_Click(object? sender, EventArgs e)
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

        private void expButton_Click(object? sender, EventArgs e)
        {
            double inputValue;
            if (double.TryParse(textBox1.Text, out inputValue))
            {
                if (inputValue >= 0)
                {
                    double result = Math.Sqrt(inputValue);
                    textBox1.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input. Square root of a negative number is not supported.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void sqrtButton_Click(object? sender, EventArgs e)
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

        private void absButton_Click(object? sender, EventArgs e)
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

        private void sineButton_Click(object? sender, EventArgs e)
        {
            double inputValue;
            if (double.TryParse(textBox1.Text, out inputValue))
            {
                double result = Math.Sin(inputValue);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void cosineButton_Click(object? sender, EventArgs e)
        {
            double inputValue;
            if (double.TryParse(textBox1.Text, out inputValue))
            {
                double result = Math.Cos(inputValue);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void tangentButton_Click(object? sender, EventArgs e)
        {
            double inputValue;
            if (double.TryParse(textBox1.Text, out inputValue))
            {
                double result = Math.Tan(inputValue);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void powerButton_Click(object? sender, EventArgs e)
        {
            double inputValue;
            if (double.TryParse(textBox1.Text, out inputValue))
            {
                double result = Math.Exp(inputValue);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void lnButton_Click(object? sender, EventArgs e)
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

        private void floorButton_Click(object? sender, EventArgs e)
        {
            double inputValue;
            if (double.TryParse(textBox1.Text, out inputValue))
            {
                double result = Math.Floor(inputValue);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void ceilingButton_Click(object? sender, EventArgs e)
        {
            double inputValue;
            if (double.TryParse(textBox1.Text, out inputValue))
            {
                double result = Math.Ceiling(inputValue);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }





    }
}
