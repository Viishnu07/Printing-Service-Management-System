using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP1
{
    public class Request
    {
        private int _ReceiptID;
        private string _Servicetype;
        private double _Fees;
        private int _Quantity;
        private bool _UrgentRequest;
        private int _CustomerID;
        private string _Status;


        public Request(int ReceiptID, string Servicetype, double Fees, int Quantity, bool UrgentRequest, int CustomerID, string Status)

        {
            _ReceiptID = ReceiptID;
            _Servicetype = Servicetype;
            _Fees = Fees;
            _Quantity = Quantity;
            _UrgentRequest = UrgentRequest;
            _CustomerID = CustomerID;
            _Status = Status;
        }

        public int ReceiptID
        {
            get { return _ReceiptID; }
        }
        public string ServiceType
        {
            get { return _Servicetype; }
        }
        public double Fees
        {
            get { return _Fees; }
        }
        public int Quantity
        {
            get { return _Quantity; }
        }
        public bool UrgentRequest
        {
            get { return _UrgentRequest; }
        }
        public int CustomerID
        {
            get { return _CustomerID; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}
