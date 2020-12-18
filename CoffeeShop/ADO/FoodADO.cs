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

        public List<FoodDTO> GetListFood()
        {
            List<FoodDTO> listFood = new List<FoodDTO>();
            string query = "SELECT * FROM food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                listFood.Add(food);
            }
            return listFood;
        }

        // CanInsertFood
        public bool CanAddFood(string name, int categoryId, float price)
        {
            string query = string.Format("insert into food (name, food_category_id, price) values (N'{0}', {1}, {2})", name, categoryId, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        
        // CanUpdateFood
        public bool CanUpdateFood(string name, int categoryId, float price, int id)
        {
            string query = string.Format("update food set name = N'{0}', food_category_id = {1}, price = {2} where id = {3}", name, categoryId, price, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // CanDeleteFood
        public bool CanRemoveFood(int id)
        {
            BillInforADO.Instance.RemoveBillInfoByFoodId(id);
            string query = "delete food where id = " + id;
            int result =DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<FoodDTO> SearchFoodByName(string name)
        {
            List<FoodDTO> listFood = new List<FoodDTO>();
            string query = string.Format("SELECT * FROM food WHERE dbo.FunctionConVertSign(name) LIKE N'%' + dbo.FunctionConVertSign(N'{0}') + '%'", name);
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
