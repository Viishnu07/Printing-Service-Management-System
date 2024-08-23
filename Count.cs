using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    internal class Count
    {
        int _BW;
        int _C;
        int _CB;
        int _TC;
        int _P;
        int _B;
        string[] _ServiceType = new string[6];
        double[] _Fees = new double[6];
        int[] _Quantity = new int[6];
        double[] _Subtotal = new double[6];
        double UR;        

        public Count(int bw, int c, int cb, int tc, int p, int b)
        {
            _BW = bw;
            _C = c;
            _CB = cb;
            _TC = tc;
            _P = p;
            _B = b;
        }

        public Count()
        {

        }

        public string[] ServiceType
        {
            get { return _ServiceType; }
        }

        public double[] Fees
        {
            get { return _Fees; }
        }

        public int[] Qauntity
        {
            get { return _Quantity; }
        }

        public double[] Subtotal
        { 
            get { return _Subtotal; }
        }



        public int Detail()
        {
            int i = 0;
            if ( _BW > 0 )
            {
                _ServiceType[i] = "Printing A4– Black and White";
                _Fees[i] = 0.80;
                _Quantity[i] = _BW;
                _Subtotal[i] = Calculate(_BW, 0.8);
                i++;
            }

            if ( _C > 0 ) 
            {
                _ServiceType[i] = "Printing A4 – Color";
                _Fees[i] = 2.50;
                _Quantity[i] = _C;
                _Subtotal[i] = Calculate(_C, 2.50);
                i++;
            }

            if (_CB > 0)
            {
                _ServiceType[i] = "Binding – Comb Binding";
                _Fees[i] = 5.00;
                _Quantity[i] = _CB;
                _Subtotal[i] = Calculate(_CB, 5.00);
                i++;
            }

            if (_TC > 0)
            {
                _ServiceType[i] = "Binding – Thick Cover";
                _Fees[i] = 15.00;
                _Quantity[i] = _TC;
                _Subtotal[i] = Calculate(_TC, 15.00);
                i++;
            }

            if (_P > 0)
            {
                _ServiceType[i] = "Poster printing (A0 – A3)";
                _Fees[i] = 3.00;
                _Quantity[i] = _P;
                _Subtotal[i] = Calculate(_P, 3.00);
                i++;
            }

            if (_B > 0)
            {
                _ServiceType[i] = "Banner";
                _Fees[i] = 10.00;
                _Quantity[i] = _B;
                _Subtotal[i] = Calculate(_B, 10.00);
                i++;
            }

            return i;
        }

        private double Calculate(int quantity, double price)
        {
            double Subtotal = quantity * price;
            return Subtotal;
        }

        public (double,double) Calculate2(int i,double[] subtotal,string _Ur)
        {
            double Total = 0;
            for (int j = 0; j < i; j++)
            {               
                Total += subtotal[j];
            }

            if (_Ur == "True")
            {
                UR = Total * 30 / 100;
                Total += UR;
            }
            else
            {
                UR = 0;
            }
            
            return (UR,Total);
        }
    }
}
