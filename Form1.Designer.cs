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
           
        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.TextBox textBox1;


    }
}
