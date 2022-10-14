namespace Lab5_2
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
            this.btnResult = new System.Windows.Forms.Button();
            this.dtpDayToDay2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDayToDay1 = new System.Windows.Forms.DateTimePicker();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.radioDayToDay = new System.Windows.Forms.RadioButton();
            this.radioMonth = new System.Windows.Forms.RadioButton();
            this.radioDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.dtpDayToDay2);
            this.groupBox1.Controls.Add(this.dtpDayToDay1);
            this.groupBox1.Controls.Add(this.dtpMonth);
            this.groupBox1.Controls.Add(this.dtpDay);
            this.groupBox1.Controls.Add(this.radioDayToDay);
            this.groupBox1.Controls.Add(this.radioMonth);
            this.groupBox1.Controls.Add(this.radioDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(154, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(324, 112);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Xem";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // dtpDayToDay2
            // 
            this.dtpDayToDay2.CustomFormat = "dd/MM/yyyy";
            this.dtpDayToDay2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayToDay2.Location = new System.Drawing.Point(324, 66);
            this.dtpDayToDay2.Name = "dtpDayToDay2";
            this.dtpDayToDay2.Size = new System.Drawing.Size(84, 20);
            this.dtpDayToDay2.TabIndex = 2;
            // 
            // dtpDayToDay1
            // 
            this.dtpDayToDay1.CustomFormat = "dd/MM/yyyy";
            this.dtpDayToDay1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayToDay1.Location = new System.Drawing.Point(234, 66);
            this.dtpDayToDay1.Name = "dtpDayToDay1";
            this.dtpDayToDay1.Size = new System.Drawing.Size(84, 20);
            this.dtpDayToDay1.TabIndex = 2;
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MM/yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(234, 40);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(84, 20);
            this.dtpMonth.TabIndex = 2;
            // 
            // dtpDay
            // 
            this.dtpDay.CustomFormat = "dd/MM/yyyy";
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDay.Location = new System.Drawing.Point(234, 14);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(84, 20);
            this.dtpDay.TabIndex = 2;
            // 
            // radioDayToDay
            // 
            this.radioDayToDay.AutoSize = true;
            this.radioDayToDay.Location = new System.Drawing.Point(132, 69);
            this.radioDayToDay.Name = "radioDayToDay";
            this.radioDayToDay.Size = new System.Drawing.Size(84, 17);
            this.radioDayToDay.TabIndex = 1;
            this.radioDayToDay.TabStop = true;
            this.radioDayToDay.Text = "Xem từ ngày";
            this.radioDayToDay.UseVisualStyleBackColor = true;
            // 
            // radioMonth
            // 
            this.radioMonth.AutoSize = true;
            this.radioMonth.Location = new System.Drawing.Point(132, 38);
            this.radioMonth.Name = "radioMonth";
            this.radioMonth.Size = new System.Drawing.Size(100, 17);
            this.radioMonth.TabIndex = 1;
            this.radioMonth.TabStop = true;
            this.radioMonth.Text = "Xem theo tháng";
            this.radioMonth.UseVisualStyleBackColor = true;
            // 
            // radioDay
            // 
            this.radioDay.AutoSize = true;
            this.radioDay.Location = new System.Drawing.Point(132, 15);
            this.radioDay.Name = "radioDay";
            this.radioDay.Size = new System.Drawing.Size(96, 17);
            this.radioDay.TabIndex = 1;
            this.radioDay.TabStop = true;
            this.radioDay.Text = "Xem theo ngày";
            this.radioDay.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lab5_2.OrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(131, 194);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(632, 244);
            this.reportViewer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.DateTimePicker dtpDayToDay2;
        private System.Windows.Forms.DateTimePicker dtpDayToDay1;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.RadioButton radioDayToDay;
        private System.Windows.Forms.RadioButton radioMonth;
        private System.Windows.Forms.RadioButton radioDay;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

