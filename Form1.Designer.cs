namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputBox1 = new TextBox();
            inputBox2 = new TextBox();
            displayBox = new TextBox();
           /* addButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();*/
            SuspendLayout();
            // 
            // inputBox1
            // 
            inputBox1.Location = new Point(12, 12);
            inputBox1.Margin = new Padding(4, 3, 4, 3);
            inputBox1.Name = "inputBox1";
            inputBox1.Size = new Size(81, 23);
            inputBox1.TabIndex = 0;
            // 
            // inputBox2
            // 
            inputBox2.Location = new Point(105, 12);
            inputBox2.Margin = new Padding(4, 3, 4, 3);
            inputBox2.Name = "inputBox2";
            inputBox2.Size = new Size(81, 23);
            inputBox2.TabIndex = 1;
            // 
            // displayBox
            // 
            displayBox.Location = new Point(12, 53);
            displayBox.Margin = new Padding(4, 3, 4, 3);
            displayBox.Name = "displayBox";
            displayBox.ReadOnly = true;
            displayBox.Size = new Size(233, 23);
            displayBox.TabIndex = 6;
            displayBox.TabStop = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 115);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(47, 46);
            addButton.TabIndex = 3;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(13, 167);
            subtractButton.Margin = new Padding(4, 3, 4, 3);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(47, 46);
            subtractButton.TabIndex = 4;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(12, 219);
            multiplyButton.Margin = new Padding(4, 3, 4, 3);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(47, 46);
            multiplyButton.TabIndex = 5;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(13, 271);
            divideButton.Margin = new Padding(4, 3, 4, 3);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(46, 40);
            divideButton.TabIndex = 5;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 323);
            Controls.Add(displayBox);
            Controls.Add(inputBox2);
            Controls.Add(inputBox1);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "CalculatorForm";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();



        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.TextBox displayBox;
    }
}
