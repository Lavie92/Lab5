namespace Lab5_1
{
    partial class frmReportOutput
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
            this.radioPrice = new System.Windows.Forms.RadioButton();
            this.radioTicket = new System.Windows.Forms.RadioButton();
            this.btnReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbxInvoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // radioPrice
            // 
            this.radioPrice.AutoSize = true;
            this.radioPrice.Location = new System.Drawing.Point(160, 69);
            this.radioPrice.Name = "radioPrice";
            this.radioPrice.Size = new System.Drawing.Size(160, 17);
            this.radioPrice.TabIndex = 0;
            this.radioPrice.TabStop = true;
            this.radioPrice.Text = "Xem bảng báo giá sản phẩm";
            this.radioPrice.UseVisualStyleBackColor = true;
            // 
            // radioTicket
            // 
            this.radioTicket.AutoSize = true;
            this.radioTicket.Location = new System.Drawing.Point(160, 102);
            this.radioTicket.Name = "radioTicket";
            this.radioTicket.Size = new System.Drawing.Size(125, 17);
            this.radioTicket.TabIndex = 0;
            this.radioTicket.TabStop = true;
            this.radioTicket.Text = "Xem phiếu giao hàng";
            this.radioTicket.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(536, 98);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Xuất Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lab5_1.rptProduct.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 140);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 298);
            this.reportViewer1.TabIndex = 3;
            // 
            // cbxInvoice
            // 
            this.cbxInvoice.FormattingEnabled = true;
            this.cbxInvoice.Location = new System.Drawing.Point(406, 99);
            this.cbxInvoice.Name = "cbxInvoice";
            this.cbxInvoice.Size = new System.Drawing.Size(121, 21);
            this.cbxInvoice.TabIndex = 4;
            // 
            // frmReportOutput
            // 
            this.AcceptButton = this.btnReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxInvoice);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.radioTicket);
            this.Controls.Add(this.radioPrice);
            this.Name = "frmReportOutput";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmReportOutput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioPrice;
        private System.Windows.Forms.RadioButton radioTicket;
        private System.Windows.Forms.Button btnReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbxInvoice;
    }
}

