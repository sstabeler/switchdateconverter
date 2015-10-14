namespace Switchdateconverter
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
            this.txtDaynum = new System.Windows.Forms.MaskedTextBox();
            this.txtMonthnum = new System.Windows.Forms.MaskedTextBox();
            this.txtYearNum = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtDayformatted = new System.Windows.Forms.MaskedTextBox();
            this.txtMonthformatted = new System.Windows.Forms.MaskedTextBox();
            this.txtYearFormatted = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtDaynum
            // 
            this.txtDaynum.Location = new System.Drawing.Point(330, 48);
            this.txtDaynum.Mask = "00";
            this.txtDaynum.Name = "txtDaynum";
            this.txtDaynum.Size = new System.Drawing.Size(27, 20);
            this.txtDaynum.TabIndex = 0;
            // 
            // txtMonthnum
            // 
            this.txtMonthnum.Location = new System.Drawing.Point(330, 86);
            this.txtMonthnum.Mask = "00";
            this.txtMonthnum.Name = "txtMonthnum";
            this.txtMonthnum.Size = new System.Drawing.Size(26, 20);
            this.txtMonthnum.TabIndex = 1;
            // 
            // txtYearNum
            // 
            this.txtYearNum.Location = new System.Drawing.Point(332, 120);
            this.txtYearNum.Mask = "00";
            this.txtYearNum.Name = "txtYearNum";
            this.txtYearNum.Size = new System.Drawing.Size(24, 20);
            this.txtYearNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(473, 44);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnConvert_MouseClick);
            // 
            // txtDayformatted
            // 
            this.txtDayformatted.Location = new System.Drawing.Point(694, 48);
            this.txtDayformatted.Name = "txtDayformatted";
            this.txtDayformatted.Size = new System.Drawing.Size(100, 20);
            this.txtDayformatted.TabIndex = 7;
            // 
            // txtMonthformatted
            // 
            this.txtMonthformatted.Location = new System.Drawing.Point(694, 85);
            this.txtMonthformatted.Name = "txtMonthformatted";
            this.txtMonthformatted.Size = new System.Drawing.Size(100, 20);
            this.txtMonthformatted.TabIndex = 8;
            // 
            // txtYearFormatted
            // 
            this.txtYearFormatted.Location = new System.Drawing.Point(694, 120);
            this.txtYearFormatted.Name = "txtYearFormatted";
            this.txtYearFormatted.Size = new System.Drawing.Size(100, 20);
            this.txtYearFormatted.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 630);
            this.Controls.Add(this.txtYearFormatted);
            this.Controls.Add(this.txtMonthformatted);
            this.Controls.Add(this.txtDayformatted);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYearNum);
            this.Controls.Add(this.txtMonthnum);
            this.Controls.Add(this.txtDaynum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDaynum;
        private System.Windows.Forms.MaskedTextBox txtMonthnum;
        private System.Windows.Forms.MaskedTextBox txtYearNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.MaskedTextBox txtDayformatted;
        private System.Windows.Forms.MaskedTextBox txtMonthformatted;
        private System.Windows.Forms.MaskedTextBox txtYearFormatted;
    }
}

