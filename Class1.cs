using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS
{
    public partial class Customer
    {
        public string ReceiptID { get; }
        public string ServiceType { get; }
        public double Fees { get; }
        public int Quantity { get; }
        public double Subtotal { get; }
        public DateTime RequestDate { get; }
        public bool UrgentRequest { get; }
        public string CustomerID { get; }
        public string Status { get; }

        public Customer(
            string receiptID, string serviceType, double fees, int quantity,
            double subtotal, DateTime requestDate, bool urgentRequest,
            string customerID, string status)
        {
            ReceiptID = receiptID;
            ServiceType = serviceType;
            Fees = fees;
            Quantity = quantity;
            Subtotal = subtotal;
            RequestDate = requestDate;
            UrgentRequest = urgentRequest;
            CustomerID = customerID;
            Status = status;
        }

       
    }
}
