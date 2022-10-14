using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class OrderReport
    {
        public int Index { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string InvoiceNo { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
    }
}
