namespace CurrencyConverter
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lbllSelectCurrency = new System.Windows.Forms.Label();
            this.lblConvertedAmount = new System.Windows.Forms.Label();
            this.rb_Yen = new System.Windows.Forms.RadioButton();
            this.rb_USD = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtConvertedAmount = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rb_Myr = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(171, 106);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbllSelectCurrency
            // 
            this.lbllSelectCurrency.AutoSize = true;
            this.lbllSelectCurrency.Location = new System.Drawing.Point(132, 151);
            this.lbllSelectCurrency.Name = "lbllSelectCurrency";
            this.lbllSelectCurrency.Size = new System.Drawing.Size(82, 13);
            this.lbllSelectCurrency.TabIndex = 1;
            this.lbllSelectCurrency.Text = "Select Currency";
            // 
            // lblConvertedAmount
            // 
            this.lblConvertedAmount.AutoSize = true;
            this.lblConvertedAmount.Location = new System.Drawing.Point(119, 247);
            this.lblConvertedAmount.Name = "lblConvertedAmount";
            this.lblConvertedAmount.Size = new System.Drawing.Size(95, 13);
            this.lblConvertedAmount.TabIndex = 2;
            this.lblConvertedAmount.Text = "Converted Amount";
            // 
            // rb_Yen
            // 
            this.rb_Yen.AutoSize = true;
            this.rb_Yen.Location = new System.Drawing.Point(237, 174);
            this.rb_Yen.Name = "rb_Yen";
            this.rb_Yen.Size = new System.Drawing.Size(93, 17);
            this.rb_Yen.TabIndex = 3;
            this.rb_Yen.TabStop = true;
            this.rb_Yen.Text = "Japanese Yen";
            this.rb_Yen.UseVisualStyleBackColor = true;
            // 
            // rb_USD
            // 
            this.rb_USD.AutoSize = true;
            this.rb_USD.Location = new System.Drawing.Point(237, 151);
            this.rb_USD.Name = "rb_USD";
            this.rb_USD.Size = new System.Drawing.Size(75, 17);
            this.rb_USD.TabIndex = 4;
            this.rb_USD.TabStop = true;
            this.rb_USD.Text = "US Dollars";
            this.rb_USD.UseVisualStyleBackColor = true;
            this.rb_USD.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(237, 103);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(154, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // txtConvertedAmount
            // 
            this.txtConvertedAmount.Location = new System.Drawing.Point(237, 244);
            this.txtConvertedAmount.Name = "txtConvertedAmount";
            this.txtConvertedAmount.Size = new System.Drawing.Size(154, 20);
            this.txtConvertedAmount.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(454, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(454, 244);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rb_Myr
            // 
            this.rb_Myr.AutoSize = true;
            this.rb_Myr.Location = new System.Drawing.Point(237, 197);
            this.rb_Myr.Name = "rb_Myr";
            this.rb_Myr.Size = new System.Drawing.Size(108, 17);
            this.rb_Myr.TabIndex = 9;
            this.rb_Myr.TabStop = true;
            this.rb_Myr.Text = "Malaysian Ringgit";
            this.rb_Myr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_Myr);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtConvertedAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.rb_USD);
            this.Controls.Add(this.rb_Yen);
            this.Controls.Add(this.lblConvertedAmount);
            this.Controls.Add(this.lbllSelectCurrency);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lbllSelectCurrency;
        private System.Windows.Forms.Label lblConvertedAmount;
        private System.Windows.Forms.RadioButton rb_Yen;
        private System.Windows.Forms.RadioButton rb_USD;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtConvertedAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rb_Myr;
    }
}

