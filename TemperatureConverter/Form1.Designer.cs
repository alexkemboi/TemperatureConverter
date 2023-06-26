namespace TemperatureConverter
{
    partial class temperatureConverter
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
            convertTemperature = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(219, 68);
            label1.Name = "label1";
            label1.Size = new Size(280, 32);
            label1.TabIndex = 0;
            label1.Text = "Temperature Converter";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(219, 127);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 1;
            label2.Text = "Celcius";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(219, 259);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 2;
            label3.Text = "Farenheit";
            // 
            // celciusTextBox
            // 
            celciusTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            celciusTextBox.Location = new Point(319, 127);
            celciusTextBox.Name = "celciusTextBox";
            celciusTextBox.Size = new Size(162, 29);
            celciusTextBox.TabIndex = 3;
            // 
            // farenHeitTextBox
            // 
            farenHeitTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            farenHeitTextBox.Location = new Point(319, 259);
            farenHeitTextBox.Name = "farenHeitTextBox";
            farenHeitTextBox.Size = new Size(162, 29);
            farenHeitTextBox.TabIndex = 4;
            // 
            // convertTemperature
            // 
            convertTemperature.BackColor = SystemColors.Highlight;
            convertTemperature.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            convertTemperature.ForeColor = SystemColors.ControlLightLight;
            convertTemperature.Location = new Point(319, 182);
            convertTemperature.Name = "convertTemperature";
            convertTemperature.Size = new Size(162, 47);
            convertTemperature.TabIndex = 5;
            convertTemperature.Text = "Convert";
            convertTemperature.UseVisualStyleBackColor = false;
            convertTemperature.Click += button1_Click;
            // 
            // temperatureConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(convertTemperature);
            Controls.Add(farenHeitTextBox);
            Controls.Add(celciusTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "temperatureConverter";
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
        private Button convertTemperature;
    }
}