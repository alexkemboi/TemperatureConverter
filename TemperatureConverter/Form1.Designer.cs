namespace TemperatureConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            celciusTextBox = new TextBox();
            farenHeitTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(292, 81);
            label1.Name = "label1";
            label1.Size = new Size(280, 32);
            label1.TabIndex = 0;
            label1.Text = "Temperature Converter";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 135);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Celcius";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 267);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Farenheit";
            // 
            // celciusTextBox
            // 
            celciusTextBox.Location = new Point(319, 127);
            celciusTextBox.Name = "celciusTextBox";
            celciusTextBox.Size = new Size(162, 23);
            celciusTextBox.TabIndex = 3;
            // 
            // farenHeitTextBox
            // 
            farenHeitTextBox.Location = new Point(319, 259);
            farenHeitTextBox.Name = "farenHeitTextBox";
            farenHeitTextBox.Size = new Size(162, 23);
            farenHeitTextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(319, 182);
            button1.Name = "button1";
            button1.Size = new Size(162, 47);
            button1.TabIndex = 5;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(farenHeitTextBox);
            Controls.Add(celciusTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Temperature Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox celciusTextBox;
        private TextBox farenHeitTextBox;
        private Button button1;
    }
}