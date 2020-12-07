using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class MenuDTO
    {

        public MenuDTO(string foodName, int count, float price, float totalPrice = 0)
        {
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
        }

        public MenuDTO(DataRow row)
        {
            this.foodName = (string)row["name"];
            this.count = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.totalPrice = (float)Convert.ToDouble(row["total_price"].ToString());
        }

        private string foodName;
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private float totalPrice;
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
