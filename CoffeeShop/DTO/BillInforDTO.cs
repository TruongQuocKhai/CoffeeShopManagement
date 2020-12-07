using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class BillInforDTO
    {
        public BillInforDTO(int id, int billId, int foodId, int count)
        {
            this.id = id;
            this.billId = billId;
            this.foodId = foodId;
            this.count = count;
        }

        public BillInforDTO(DataRow row)
        {
            this.id = (int)row["id"];
            this.billId = (int)row["billId"];
            this.foodId = (int)row["foodId"];
            this.count = (int)row["count"];
        }


        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int billId;
        public int BillId
        {
            get { return billId; }
            set { billId = value; }
        }

        private int foodId;
        public int FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }


    }
}
