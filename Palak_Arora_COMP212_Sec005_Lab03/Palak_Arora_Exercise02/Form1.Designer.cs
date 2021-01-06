namespace Palak_Arora_Exercise02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCalculateFact = new System.Windows.Forms.Button();
            this.txtFact = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.interestLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.principalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFact)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnswer);
            this.groupBox1.Controls.Add(this.btnCalculateFact);
            this.groupBox1.Controls.Add(this.txtFact);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Factorial Asynchronously";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(51, 251);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(225, 123);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // btnCalculateFact
            // 
            this.btnCalculateFact.Location = new System.Drawing.Point(65, 141);
            this.btnCalculateFact.Name = "btnCalculateFact";
            this.btnCalculateFact.Size = new System.Drawing.Size(140, 70);
            this.btnCalculateFact.TabIndex = 2;
            this.btnCalculateFact.Text = "Calculate Factorial";
            this.btnCalculateFact.UseVisualStyleBackColor = true;
            this.btnCalculateFact.Click += new System.EventHandler(this.btnCalculateFact_Click);
            // 
            // txtFact
            // 
            this.txtFact.Location = new System.Drawing.Point(139, 72);
            this.txtFact.Name = "txtFact";
            this.txtFact.Size = new System.Drawing.Size(125, 22);
            this.txtFact.TabIndex = 1;
            this.txtFact.ValueChanged += new System.EventHandler(this.txtFact_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Factorial Of: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.interestLabel);
            this.groupBox2.Controls.Add(this.calculateButton);
            this.groupBox2.Controls.Add(this.displayTextBox);
            this.groupBox2.Controls.Add(this.yearUpDown);
            this.groupBox2.Controls.Add(this.interestTextBox);
            this.groupBox2.Controls.Add(this.principalTextBox);
            this.groupBox2.Controls.Add(this.balanceLabel);
            this.groupBox2.Controls.Add(this.yearsLabel);
            this.groupBox2.Controls.Add(this.principalLabel);
            this.groupBox2.Location = new System.Drawing.Point(356, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 395);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Loan Calculator";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(41, 120);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(97, 17);
            this.interestLabel.TabIndex = 9;
            this.interestLabel.Text = "Interest Rate: ";
            this.interestLabel.Click += new System.EventHandler(this.interestLabel_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(331, 69);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(144, 73);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Interest";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(147, 235);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(203, 107);
            this.displayTextBox.TabIndex = 7;
            this.displayTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(147, 168);
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(120, 22);
            this.yearUpDown.TabIndex = 6;
            this.yearUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(147, 120);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(100, 22);
            this.interestTextBox.TabIndex = 5;
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(147, 69);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(100, 22);
            this.principalTextBox.TabIndex = 4;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(12, 235);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(129, 17);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "Interest Calculated:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(59, 168);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(49, 17);
            this.yearsLabel.TabIndex = 2;
            this.yearsLabel.Text = "Years:";
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Location = new System.Drawing.Point(41, 69);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(100, 17);
            this.principalLabel.TabIndex = 0;
            this.principalLabel.Text = "Loan Amount: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFact)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCalculateFact;
        private System.Windows.Forms.NumericUpDown txtFact;
        private System.Windows.Forms.Label label1;
    }
}

