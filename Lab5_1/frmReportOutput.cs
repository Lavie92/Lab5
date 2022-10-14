using Lab5_1.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_1
{
    public partial class frmReportOutput : Form
    {
        ProductContext productContext = new ProductContext();
        public frmReportOutput()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void frmReportOutput_Load(object sender, EventArgs e)
        {
            var dataSource = productContext.Invoices.OrderByDescending(x => x.DeliveryDate).ToList();
            cbxInvoice.DataSource = dataSource;
            cbxInvoice.DisplayMember = "InvoiceNo";
            cbxInvoice.ValueMember = "InvoiceNo";
            this.reportViewer1.RefreshReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (radioPrice.Checked)
            {
                List<Product> listProduct = productContext.Products.ToList();
                this.reportViewer1.LocalReport.ReportPath = "D:/TH_Winform/Lab5/Lab5/Lab5_1/ProductReport.rdlc";
                var reportDataSource = new ReportDataSource("ProductDataset", listProduct);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DisplayName = "Bảng Báo Giá";
            }
            else
            {
                Invoice invoice = productContext.Invoices.FirstOrDefault(p => p.InvoiceNo == cbxInvoice.Text);
                List<Order> listOrder = productContext.Orders.Where(p => p.InvoiceNo == cbxInvoice.Text).ToList();
                if (invoice == null || listOrder.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng");
                    return;
                }
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("InvoiceNo", invoice.InvoiceNo);
                param[1] = new ReportParameter("DeliveryDateStr", string.Format("Ngày " +
               invoice.DeliveryDate.ToString("dd/MM/yyyy")));
                this.reportViewer1.LocalReport.ReportPath = "D:/TH_Winform/Lab5/Lab5/Lab5_1/rptOrder.rdlc";
                this.reportViewer1.LocalReport.SetParameters(param);
                var reportDataSource = new ReportDataSource("OrderDataSet", listOrder);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DisplayName = "Phiếu giao hàng";
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
