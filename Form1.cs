using System;
using System.Windows.Forms;

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
            Button addButton = new Button();
            addButton.Text = "+";
            addButton.Location = new Point(10, 10);
            addButton.Size = new Size(50, 50);
            addButton.Click += new EventHandler(addButton_Click);
            this.Controls.Add(addButton);

            Button subtractButton = new Button();
            subtractButton.Text = "-";
            subtractButton.Location = new Point(70, 10);
            subtractButton.Size = new Size(50, 50);
            subtractButton.Click += new EventHandler(subtractButton_Click);
            this.Controls.Add(subtractButton);

            Button multiplyButton = new Button();
            multiplyButton.Text = "x";
            multiplyButton.Location = new Point(130, 10);
            multiplyButton.Size = new Size(50, 50);
            multiplyButton.Click += new EventHandler(multiplyButton_Click);
            this.Controls.Add(multiplyButton);

            Button divideButton = new Button();
            divideButton.Text = "/";
            divideButton.Location = new Point(190, 10);
            divideButton.Size = new Size(50, 50);
            divideButton.Click += new EventHandler(divideButton_Click);
            this.Controls.Add(divideButton);

            Button sineButton = new Button();
            sineButton.Text = "sin";
            sineButton.Location = new Point(10, 70);
            sineButton.Size = new Size(50, 50);
            sineButton.Click += new EventHandler(sineButton_Click);
            this.Controls.Add(sineButton);

            Button cosineButton = new Button();
            cosineButton.Text = "cos";
            cosineButton.Location = new Point(70, 70);
            cosineButton.Size = new Size(50, 50);
            cosineButton.Click += new EventHandler(cosineButton_Click);
            this.Controls.Add(cosineButton);

            Button tangentButton = new Button();
            tangentButton.Text = "tan";
            tangentButton.Location = new Point(130, 70);
            tangentButton.Size = new Size(50, 50);
            tangentButton.Click += new EventHandler(tangentButton_Click);
            this.Controls.Add(tangentButton);

            Button powerButton = new Button();
            powerButton.Text = "^";
            powerButton.Location = new Point(190, 70);
            powerButton.Size = new Size(50, 50);
            powerButton.Click += new EventHandler(powerButton_Click);
            this.Controls.Add(powerButton);

            Button floorButton = new Button();
            floorButton.Text = "floor";
            floorButton.Location = new Point(10, 130);
            floorButton.Size = new Size(50, 50);
            floorButton.Click += new EventHandler(floorButton_Click);
            this.Controls.Add(floorButton);

            Button ceilingButton = new Button();
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
            Button sqrtButton = new Button();
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

        private void cosineButton_Click(object? sender, EventArgs e)
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

        private void tangentButton_Click(object? sender, EventArgs e)
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

        private void powerButton_Click(object? sender, EventArgs e)
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

        private void ceilingButton_Click(object? sender, EventArgs e)
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
