using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;

namespace CoffeeShop.ADO
{
    public class MenuADO
    {
        private MenuADO() { }

        // create thuoc tinh instace de khoi tao du lieu cho ca chuong trinh
        private static MenuADO instance;
        public static MenuADO Instance
        {
            get
            {
                if (instance == null) instance = new MenuADO();
                return instance;
            }
            private set { instance = value; }
        }


        public List<MenuDTO> GetListMenuByTable(int id)
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();

            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count as total_price FROM bill_info as bi, bill as b, food f WHERE bi.bill_id = b.id and bi.food_id = f.id and b.status = 0 and b.table_id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
