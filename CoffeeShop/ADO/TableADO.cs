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

        // Load List table
        public List<TableDTO>LoadTableList()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            // data table_food
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            // Loop through the rows in the table_food
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }

        // Use procedure for switch tables
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @tableId1 , @tableId2 ", new object[] { id1, id2 });
        }

        // CanInsertFoodTable 
        public bool CanAddTable(string name)
        {
            string query = string.Format("insert into table_food(name) values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // CanUpdateFoodTable
        public bool CanUpdateTable(int id, string name)
        {
            string query = string.Format("update table_food set name = N'{0}' where id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // CanDeleteTable
        public bool CanRemoveTable(int id)
        {
            string query = string.Format("delete table_food where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
