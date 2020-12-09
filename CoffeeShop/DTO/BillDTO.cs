using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class BillDTO
    {
        public BillDTO(int id, DateTime checkin_date, DateTime checkout_date, int status)
        {
            this.id = id;
            this.checkin_date = checkin_date;
            this.checkout_date = checkout_date;
            this.status = status;
            //this.totalPrice = totalPrice;
        }
        // Constructor datarow
        public BillDTO(DataRow row)
        {
            this.id = (int)row["id"];
            this.checkin_date = (DateTime?)row["checkin_date"];
            var checkout_dateTemp = row["checkout_date"];
            if (checkout_dateTemp.ToString() != "")
            {
                this.checkout_date = (DateTime?)checkout_dateTemp;

            }
            this.status = (int)row["status"];
           // this.totalPrice = (float)row["totalPrice"];
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime? checkin_date;
        public DateTime? Checkin_date
        {
            get { return checkin_date; }
            set { checkin_date = value; }
        }
        private DateTime? checkout_date;
        public DateTime? Checkout_date
        {
            get { return checkout_date; }
            set { checkout_date = value; }
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        //private float totalPrice;
        //public float TotalPrice
        //{
        //    get { return totalPrice; }
        //    set { totalPrice = value; }
        //}
    }
}
