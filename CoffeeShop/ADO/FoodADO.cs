using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;

namespace CoffeeShop.ADO
{
    public class FoodADO
    {
        private FoodADO() { }

        // Tao thuoc tinh instance sd keyword static khoi tao du lieu 1 lan duy nhat cho ca chuong trinh
        private static FoodADO instance;
        public static FoodADO Instance
        {
            get
            {
                if (instance == null) instance = new FoodADO();
                return instance;
            }
            private set { instance = value; }
        }


        // Lay mon an theo id danh muc
        public List<FoodDTO> GetFoodListByCategoryId(int id)
        {
            List<FoodDTO> listFood = new List<FoodDTO>();

            string query = "SELECT * FROM food WHERE food_category_id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                listFood.Add(food);
            }
            return listFood;
        }
    }
}
