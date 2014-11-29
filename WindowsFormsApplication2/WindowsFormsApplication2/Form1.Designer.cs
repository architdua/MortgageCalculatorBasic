namespace WindowsFormsApplication2
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
            this.lblPropertyVal = new System.Windows.Forms.Label();
            this.lblAnnualIntRate = new System.Windows.Forms.Label();
            this.lblLoanDuration = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.txtPropertyVal = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtLoanDuration = new System.Windows.Forms.TextBox();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPropertyVal
            // 
            this.lblPropertyVal.AutoSize = true;
            this.lblPropertyVal.Location = new System.Drawing.Point(13, 26);
            this.lblPropertyVal.Name = "lblPropertyVal";
            this.lblPropertyVal.Size = new System.Drawing.Size(120, 13);
            this.lblPropertyVal.TabIndex = 0;
            this.lblPropertyVal.Text = "Enter property value ($):";
            // 
            // lblAnnualIntRate
            // 
            this.lblAnnualIntRate.AutoSize = true;
            this.lblAnnualIntRate.Location = new System.Drawing.Point(13, 66);
            this.lblAnnualIntRate.Name = "lblAnnualIntRate";
            this.lblAnnualIntRate.Size = new System.Drawing.Size(163, 13);
            this.lblAnnualIntRate.TabIndex = 1;
            this.lblAnnualIntRate.Text = "Enter the annual interest rate (%):\r\n";
            // 
            // lblLoanDuration
            // 
            this.lblLoanDuration.AutoSize = true;
            this.lblLoanDuration.Location = new System.Drawing.Point(12, 103);
            this.lblLoanDuration.Name = "lblLoanDuration";
            this.lblLoanDuration.Size = new System.Drawing.Size(151, 13);
            this.lblLoanDuration.TabIndex = 2;
            this.lblLoanDuration.Text = "Enter the loan duration (years):";
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Location = new System.Drawing.Point(12, 137);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(124, 13);
            this.lblDownPayment.TabIndex = 3;
            this.lblDownPayment.Text = "Enter down payment (%):";
            // 
            // txtPropertyVal
            // 
            this.txtPropertyVal.Location = new System.Drawing.Point(222, 26);
            this.txtPropertyVal.Name = "txtPropertyVal";
            this.txtPropertyVal.Size = new System.Drawing.Size(100, 20);
            this.txtPropertyVal.TabIndex = 4;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(222, 134);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(100, 20);
            this.txtDownPayment.TabIndex = 5;
            // 
            // txtLoanDuration
            // 
            this.txtLoanDuration.Location = new System.Drawing.Point(222, 96);
            this.txtLoanDuration.Name = "txtLoanDuration";
            this.txtLoanDuration.Size = new System.Drawing.Size(100, 20);
            this.txtLoanDuration.TabIndex = 6;
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(222, 59);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualInterestRate.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(129, 248);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 248);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 296);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAnnualInterestRate);
            this.Controls.Add(this.txtLoanDuration);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtPropertyVal);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.lblLoanDuration);
            this.Controls.Add(this.lblAnnualIntRate);
            this.Controls.Add(this.lblPropertyVal);
            this.Name = "Form1";
            this.Text = "Mortgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPropertyVal;
        private System.Windows.Forms.Label lblAnnualIntRate;
        private System.Windows.Forms.Label lblLoanDuration;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.TextBox txtPropertyVal;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtLoanDuration;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}

