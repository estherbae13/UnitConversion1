
namespace UnitConversion1
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.conversions1Label = new System.Windows.Forms.Label();
            this.conversions4Label = new System.Windows.Forms.Label();
            this.conversions3Label = new System.Windows.Forms.Label();
            this.conversions2Label = new System.Windows.Forms.Label();
            this.conversionChoiceLabel = new System.Windows.Forms.Label();
            this.convertedValueLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.conversionChoiceInput = new System.Windows.Forms.TextBox();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(268, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(276, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linear Conversion";
            // 
            // conversions1Label
            // 
            this.conversions1Label.AutoSize = true;
            this.conversions1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversions1Label.Location = new System.Drawing.Point(29, 95);
            this.conversions1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conversions1Label.Name = "conversions1Label";
            this.conversions1Label.Size = new System.Drawing.Size(265, 29);
            this.conversions1Label.TabIndex = 1;
            this.conversions1Label.Text = "1. Inches to centimetres";
            // 
            // conversions4Label
            // 
            this.conversions4Label.AutoSize = true;
            this.conversions4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversions4Label.Location = new System.Drawing.Point(29, 294);
            this.conversions4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conversions4Label.Name = "conversions4Label";
            this.conversions4Label.Size = new System.Drawing.Size(240, 29);
            this.conversions4Label.TabIndex = 3;
            this.conversions4Label.Text = "4. Miles to kilometres";
            // 
            // conversions3Label
            // 
            this.conversions3Label.AutoSize = true;
            this.conversions3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversions3Label.Location = new System.Drawing.Point(29, 226);
            this.conversions3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conversions3Label.Name = "conversions3Label";
            this.conversions3Label.Size = new System.Drawing.Size(207, 29);
            this.conversions3Label.TabIndex = 4;
            this.conversions3Label.Text = "3. Yards to metres";
            // 
            // conversions2Label
            // 
            this.conversions2Label.AutoSize = true;
            this.conversions2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversions2Label.Location = new System.Drawing.Point(29, 159);
            this.conversions2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conversions2Label.Name = "conversions2Label";
            this.conversions2Label.Size = new System.Drawing.Size(244, 29);
            this.conversions2Label.TabIndex = 5;
            this.conversions2Label.Text = "2. Feet to centimetres";
            // 
            // conversionChoiceLabel
            // 
            this.conversionChoiceLabel.AutoSize = true;
            this.conversionChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionChoiceLabel.Location = new System.Drawing.Point(111, 398);
            this.conversionChoiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conversionChoiceLabel.Name = "conversionChoiceLabel";
            this.conversionChoiceLabel.Size = new System.Drawing.Size(332, 29);
            this.conversionChoiceLabel.TabIndex = 6;
            this.conversionChoiceLabel.Text = "Enter conversion choice (1-4):";
            // 
            // convertedValueLabel
            // 
            this.convertedValueLabel.AutoSize = true;
            this.convertedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedValueLabel.Location = new System.Drawing.Point(111, 469);
            this.convertedValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.convertedValueLabel.Name = "convertedValueLabel";
            this.convertedValueLabel.Size = new System.Drawing.Size(311, 29);
            this.convertedValueLabel.TabIndex = 7;
            this.convertedValueLabel.Text = "Enter value to be converted:";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.outputLabel.Location = new System.Drawing.Point(16, 695);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(793, 76);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conversionChoiceInput
            // 
            this.conversionChoiceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionChoiceInput.Location = new System.Drawing.Point(561, 394);
            this.conversionChoiceInput.Margin = new System.Windows.Forms.Padding(4);
            this.conversionChoiceInput.Name = "conversionChoiceInput";
            this.conversionChoiceInput.Size = new System.Drawing.Size(132, 35);
            this.conversionChoiceInput.TabIndex = 9;
            // 
            // valueInput
            // 
            this.valueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueInput.Location = new System.Drawing.Point(561, 465);
            this.valueInput.Margin = new System.Windows.Forms.Padding(4);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(132, 35);
            this.valueInput.TabIndex = 10;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Orange;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(117, 555);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(577, 69);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Convert";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(825, 782);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.conversionChoiceInput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertedValueLabel);
            this.Controls.Add(this.conversionChoiceLabel);
            this.Controls.Add(this.conversions2Label);
            this.Controls.Add(this.conversions3Label);
            this.Controls.Add(this.conversions4Label);
            this.Controls.Add(this.conversions1Label);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Unit Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label conversions1Label;
        private System.Windows.Forms.Label conversions4Label;
        private System.Windows.Forms.Label conversions3Label;
        private System.Windows.Forms.Label conversions2Label;
        private System.Windows.Forms.Label conversionChoiceLabel;
        private System.Windows.Forms.Label convertedValueLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox conversionChoiceInput;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Button calculateButton;
    }
}

