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


    }
}
