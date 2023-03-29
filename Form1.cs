using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
       public CalculatorForm()
        {
            InitializeComponent();
            // Add inputBox1
            inputBox1 = new System.Windows.Forms.TextBox();
            inputBox1.Location = new Point(10, 10);
            inputBox1.Size = new Size(100, 20);
            this.Controls.Add(inputBox1);

            // Add inputBox2
            inputBox2 = new System.Windows.Forms.TextBox();
            inputBox2.Location = new Point(120, 10);
            inputBox2.Size = new Size(100, 20);
            this.Controls.Add(inputBox2);

            // Add displayBox
            displayBox = new System.Windows.Forms.TextBox();
            displayBox.Location = new Point(10, 40);
            displayBox.Size = new Size(210, 20);
            displayBox.ReadOnly = true;
            this.Controls.Add(displayBox);

            // Add buttons
            string[] buttonTexts = { "+", "-", "x", "/", "sqrt", "abs", "sin", "cos", "tan", "pow", "ln", "ceil", "floor" };
            int x = 10;
            int y = 70;

            for (int i = 0; i < buttonTexts.Length; i++)
            {
                System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                button.Text = buttonTexts[i];
                button.Location = new Point(x, y);
                button.Size = new Size(50, 30);
                button.Click += (sender, e) =>
                {
                    var buttonClicked = sender as System.Windows.Forms.Button;
                    PerformOperation(buttonClicked.Text);
                };

                this.Controls.Add(button);

                x += 60;

                if ((i + 1) % 4 == 0)
                {
                    x = 10;
                    y += 40;
                }
            }

        }

        void PerformOperation(string operation)
        {
            switch (operation)
            {
                case "+":
                    addButton_Click(null, EventArgs.Empty);
                    break;
                case "-":
                    subtractButton_Click(null, EventArgs.Empty);
                    break;
                case "x":
                    multiplyButton_Click(null, EventArgs.Empty);
                    break;
                case "/":
                    divideButton_Click(null, EventArgs.Empty);
                    break;
                case "sqrt":
                    sqrtButton_Click(null, EventArgs.Empty);
                    break;
                case "abs":
                    absButton_Click(null, EventArgs.Empty);
                    break;
                case "sin":
                    sineButton_Click(null, EventArgs.Empty);
                    break;
                case "cos":
                    cosineButton_Click(null, EventArgs.Empty);
                    break;
                case "tan":
                    tangentButton_Click(null, EventArgs.Empty);
                    break;
                case "pow":
                    powerButton_Click(null, EventArgs.Empty);
                    break;
                case "ln":
                    lnButton_Click(null, EventArgs.Empty);
                    break;
                case "ceil":
                    ceilingButton_Click(null, EventArgs.Empty);
                    break;
                case "floor":
                    floorButton_Click(null, EventArgs.Empty);
                    break;
            }
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
            System.Windows.Forms.TextBox displayBox = new System.Windows.Forms.TextBox();
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
            // Get the user inputs
            double input1 = Convert.ToDouble(inputBox1.Text);
            double input2 = Convert.ToDouble(inputBox2.Text);

            // Perform exponentiation
            double result = Math.Pow(input1, input2);

            // Display the result in 'displayBox'
            displayBox.Text = result.ToString();
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(inputBox1.Text);
            double result = Math.Sqrt(input1);
            displayBox.Text = result.ToString();
        }

        private void absButton_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(inputBox1.Text);
            double result = Math.Abs(input1);
            displayBox.Text = result.ToString();
        }

        private void sineButton_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(inputBox1.Text);
            double result = Math.Sin(input1);
            displayBox.Text = result.ToString();
        }

        private void cosineButton_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(inputBox1.Text);
            double result = Math.Cos(input1);
            displayBox.Text = result.ToString();
        }

        private void tangentButton_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(inputBox1.Text);
            double result = Math.Tan(input1);
            displayBox.Text = result.ToString();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(inputBox1.Text);
            double input2 = Convert.ToDouble(inputBox2.Text);
            double result = Math.Pow(input1, input2);
            displayBox.Text = result.ToString();
        }

        private void lnButton_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(inputBox1.Text);
            double result = Math.Log(input1);
            displayBox.Text = result.ToString();
        }

        private void floorButton_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(inputBox1.Text);
            double result = Math.Floor(input1);
            displayBox.Text = result.ToString();
        }


        private void ceilingButton_Click(object? sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(inputBox1.Text);
            double result = Math.Ceiling(input1);
            displayBox.Text = result.ToString();
        }





    }
}
