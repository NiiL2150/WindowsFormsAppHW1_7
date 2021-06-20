
namespace WindowsFormsAppHW1_7
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
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.radioButtonMinute = new System.Windows.Forms.RadioButton();
            this.radioButtonSecond = new System.Windows.Forms.RadioButton();
            this.labelTimeUntilDate = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(13, 13);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 0;
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Location = new System.Drawing.Point(13, 40);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(52, 17);
            this.radioButtonYear.TabIndex = 1;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "Years";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Location = new System.Drawing.Point(13, 64);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMonth.TabIndex = 2;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "Months";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Location = new System.Drawing.Point(13, 88);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(49, 17);
            this.radioButtonDay.TabIndex = 3;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "Days";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinute
            // 
            this.radioButtonMinute.AutoSize = true;
            this.radioButtonMinute.Location = new System.Drawing.Point(13, 112);
            this.radioButtonMinute.Name = "radioButtonMinute";
            this.radioButtonMinute.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMinute.TabIndex = 4;
            this.radioButtonMinute.TabStop = true;
            this.radioButtonMinute.Text = "Minutes";
            this.radioButtonMinute.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecond
            // 
            this.radioButtonSecond.AutoSize = true;
            this.radioButtonSecond.Location = new System.Drawing.Point(13, 136);
            this.radioButtonSecond.Name = "radioButtonSecond";
            this.radioButtonSecond.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSecond.TabIndex = 5;
            this.radioButtonSecond.TabStop = true;
            this.radioButtonSecond.Text = "Seconds";
            this.radioButtonSecond.UseVisualStyleBackColor = true;
            // 
            // labelTimeUntilDate
            // 
            this.labelTimeUntilDate.AutoSize = true;
            this.labelTimeUntilDate.Location = new System.Drawing.Point(13, 160);
            this.labelTimeUntilDate.Name = "labelTimeUntilDate";
            this.labelTimeUntilDate.Size = new System.Drawing.Size(13, 13);
            this.labelTimeUntilDate.TabIndex = 6;
            this.labelTimeUntilDate.Text = "0";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 176);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 209);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelTimeUntilDate);
            this.Controls.Add(this.radioButtonSecond);
            this.Controls.Add(this.radioButtonMinute);
            this.Controls.Add(this.radioButtonDay);
            this.Controls.Add(this.radioButtonMonth);
            this.Controls.Add(this.radioButtonYear);
            this.Controls.Add(this.textBoxDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.RadioButton radioButtonMinute;
        private System.Windows.Forms.RadioButton radioButtonSecond;
        private System.Windows.Forms.Label labelTimeUntilDate;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

