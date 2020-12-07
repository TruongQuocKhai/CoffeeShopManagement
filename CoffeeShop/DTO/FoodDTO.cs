using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class FoodDTO
    {
        public FoodDTO(int id, string name, int foodCategoryId, float price)
        {
            this.id = id;
            this.name = name;
            this.foodCategoryId = foodCategoryId;
            this.price = price;
        }

        public FoodDTO(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = (string)row["name"];
            this.foodCategoryId = (int)row["food_category_id"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int foodCategoryId;
        public int FoodCategoryId
        {
            get { return foodCategoryId; }
            set { foodCategoryId = value; }
        }

        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
