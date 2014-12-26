namespace InterestCalculator
{
    partial class InterestCalculatorUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.PrincipalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // PrincipalTextBox
            // 
            this.PrincipalTextBox.Location = new System.Drawing.Point(168, 37);
            this.PrincipalTextBox.Name = "PrincipalTextBox";
            this.PrincipalTextBox.Size = new System.Drawing.Size(247, 20);
            this.PrincipalTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Annual Interest Rate (%)";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(168, 72);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(247, 20);
            this.interestRateTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time Period (in Year)";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(168, 110);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(247, 20);
            this.TimeTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Amount (Result)";
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Location = new System.Drawing.Point(168, 212);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(247, 20);
            this.TotalAmountTextBox.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(340, 162);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Noted that Interest Calculation Interval : Yearly";
            // 
            // InterestCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 320);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrincipalTextBox);
            this.Controls.Add(this.label1);
            this.Name = "InterestCalculatorUI";
            this.Text = "A Simple Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrincipalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label5;
    }
}

