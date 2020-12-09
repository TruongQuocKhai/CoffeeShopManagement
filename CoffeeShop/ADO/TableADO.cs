using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;

namespace CoffeeShop.ADO
{
    public class TableADO
    {
        // Constructor
        private TableADO() { }

        // Khai bao thuoc tinh Button Table
        public static int TableWidth = 90;
        public static int TableHeigth = 90;

        // Design singleton 
        // Create property instacne khoi tao du lieu 1 lan duy nhat cho ca chuong trinh
        private static TableADO instance;
        public static TableADO Instance
        {
            get
            {
                if (instance == null) instance = new TableADO();
                return instance;
            }
            private set { instance = value; }
        }
        public List<TableDTO>LoadTableList()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            // data chua du lieu bang table_food
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            // Lay ra cac row trong bang table_food
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @tableId1 , @tableId2 ", new object[] { id1, id2 });
        }
    }
}
