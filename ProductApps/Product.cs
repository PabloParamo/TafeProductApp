using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal totalCharge;
        private decimal totalChargeAfterGrap;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }

        public decimal TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; }
        }

        public decimal TotalChargeAfterGrap
        {
            get { return totalChargeAfterGrap; }
            set { totalChargeAfterGrap = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = 25; }//value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Calculate the total cost
       
        public void calTotalCharge()
        {
            TotalCharge = TotalPayment + 25;
        }

        //Calculate the total cost after grap

        public void calTotalChargeAfterGrap()
        {
            TotalChargeAfterGrap = TotalPayment + 25 + 5;
        }
    }
}
