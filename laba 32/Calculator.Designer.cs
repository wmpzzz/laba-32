namespace laba_32
{
    partial class Calculator
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
            DividendTextBox = new TextBox();
            DividerTextBox = new TextBox();
            DividendLabel = new Label();
            DividerLabel = new Label();
            CalculateButton = new Button();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // DividendTextBox
            // 
            DividendTextBox.Location = new Point(144, 113);
            DividendTextBox.Name = "DividendTextBox";
            DividendTextBox.Size = new Size(190, 23);
            DividendTextBox.TabIndex = 0;
            // 
            // DividerTextBox
            // 
            DividerTextBox.Location = new Point(144, 207);
            DividerTextBox.Name = "DividerTextBox";
            DividerTextBox.Size = new Size(190, 23);
            DividerTextBox.TabIndex = 1;
            // 
            // DividendLabel
            // 
            DividendLabel.AutoSize = true;
            DividendLabel.Location = new Point(144, 86);
            DividendLabel.Name = "DividendLabel";
            DividendLabel.Size = new Size(101, 15);
            DividendLabel.TabIndex = 2;
            DividendLabel.Text = "Введите делимое";
            // 
            // DividerLabel
            // 
            DividerLabel.AutoSize = true;
            DividerLabel.Location = new Point(144, 189);
            DividerLabel.Name = "DividerLabel";
            DividerLabel.Size = new Size(103, 15);
            DividerLabel.TabIndex = 3;
            DividerLabel.Text = "Введите делитель";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(144, 327);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(159, 64);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Вычислить";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(144, 281);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(63, 15);
            ResultLabel.TabIndex = 5;
            ResultLabel.Text = "Результат:";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(ResultLabel);
            Controls.Add(CalculateButton);
            Controls.Add(DividerLabel);
            Controls.Add(DividendLabel);
            Controls.Add(DividerTextBox);
            Controls.Add(DividendTextBox);
            Name = "Calculator";
            Text = " Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DividendTextBox;
        private TextBox DividerTextBox;
        private Label DividendLabel;
        private Label DividerLabel;
        private Button CalculateButton;
        private Label ResultLabel;
    }
}
