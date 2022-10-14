using Lab5_2.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    public partial class Form1 : Form
    {
        ProductContext productContext = new ProductContext();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
           
            List<Order> listOrders = productContext.Orders.ToList();
            
            if (radioDay.Checked)
            {
               
                var orders = productContext.Orders.Where(x => DbFunctions.TruncateTime(x.Invoice.DeliveryDate) == DbFunctions.TruncateTime(dtpDay.Value)).GroupBy(x => new
                {
                    x.InvoiceNo,
                    x.Invoice.DeliveryDate,
                }).ToList()
                .Select((x, i) => new OrderReport()
                {
                    Index = i + 1,
                    InvoiceNo = x.Key.InvoiceNo,
                    DeliveryDate = x.Key.DeliveryDate,
                    Total = x.Sum(y => (double)y.Quantity * (double)y.Price)
                }).ToList();
                if (orders.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hoá đơn nào");
                    return;
                }
                this.reportViewer1.LocalReport.ReportPath = "D:/TH_Winform/Lab5/Lab5/Lab5_2/OrderReport.rdlc";
                var reportDataSource = new ReportDataSource("OrderDataset", orders);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            }
            else if (radioMonth.Checked)
            {
                var orders = productContext.Orders.Where(x => x.Invoice.DeliveryDate.Month == dtpDay.Value.Month && x.Invoice.DeliveryDate.Year == dtpMonth.Value.Year).GroupBy(x => new
                {
                    x.InvoiceNo,
                    x.Invoice.DeliveryDate,
                }).ToList()
                .Select((x, i) => new OrderReport()
                {
                    Index = i + 1,
                    InvoiceNo = x.Key.InvoiceNo,
                    DeliveryDate = x.Key.DeliveryDate,
                    Total = x.Sum(y => (double)y.Quantity * (double)y.Price)
                }).ToList();
                if (orders.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hoá đơn nào");
                    return;
                }
                this.reportViewer1.LocalReport.ReportPath = "D:/TH_Winform/Lab5/Lab5/Lab5_2/OrderReport.rdlc";
                var reportDataSource = new ReportDataSource("OrderDataset", orders);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            else
            {
                var orders = productContext.Orders.Where(x => x.Invoice.DeliveryDate >= dtpDayToDay1.Value && dtpDayToDay2.Value >= x.Invoice.DeliveryDate).GroupBy(x => new
                {
                    x.InvoiceNo,
                    x.Invoice.DeliveryDate,
                }).ToList()
               .Select((x, i) => new OrderReport()
               {
                   Index = i + 1,
                   InvoiceNo = x.Key.InvoiceNo,
                   DeliveryDate = x.Key.DeliveryDate,
                   Total = x.Sum(y => (double)y.Quantity * (double)y.Price)
               }).ToList();
                if (orders.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hoá đơn nào");
                    return;
                }
                this.reportViewer1.LocalReport.ReportPath = "D:/TH_Winform/Lab5/Lab5/Lab5_2/OrderReport.rdlc";
                var reportDataSource = new ReportDataSource("OrderDataset", orders);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            this.reportViewer1.RefreshReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        
    }
}
