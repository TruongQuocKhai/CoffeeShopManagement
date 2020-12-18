using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;

namespace CoffeeShop.ADO
{
    public class CategoryADO
    {
        private CategoryADO() { }

        // Tao thuoc tinh instance de khoi tao du lieu 1 lan duy nhat cho chuong trinh
        private static CategoryADO instance;
        public static CategoryADO Instance
        {
            get
            {
                if (instance == null) instance = new CategoryADO();
                return instance;
            }
            private set { instance = value; }
        }

        // Lay ra list danh muc mon an
        public List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> listCategory = new List<CategoryDTO>();
            string query = "SELECT * FROM food_category";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CategoryDTO category = new CategoryDTO(item);
                listCategory.Add(category);
            }
            return listCategory;
        }

        // Get Category by id
        public CategoryDTO GetCategoryById(int id)
        {
            CategoryDTO category = null;
            List<CategoryDTO> listCategoryById = new List<CategoryDTO>();
            string query = "select * from food_category where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new CategoryDTO(item);
                return category;
            }
            return category;
        }

        // CanInsertCategory
        public bool CanAddCategory(string name)
        {
            string query = string.Format("insert into food_category values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // CanDeleteCategory 
        public bool CanRemoveCategory(int id)
        {
            FoodADO.Instance.CanRemoveFood(id);
            string query = string.Format("delete food_category where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // 
        public bool CanUpdateCategory(int id, string name)
        {
            string query = string.Format("update food_category set name = N'{0}' where id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
