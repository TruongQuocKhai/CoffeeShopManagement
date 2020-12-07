using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;

namespace CoffeeShop.ADO
{
    public class BillADO
    {
        private BillADO() { }

        // Design singleton 
        // Tao 1 thuoc instance de khoi tao du lieu 1 lan duy nhat cho ca truong trinh
        private static BillADO instance;
        public static BillADO Instance
        {
            get
            {
                if (instance == null) instance = new BillADO();
                return instance;
            }
            private set { instance = value; }
        }

        // Lay id cua bill
        public int GetUncheckBillIdByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM bill WHERE table_id = " + id + " and status = 0");

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
            }
            return -1;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exc USP_InsertBill @table_id", new object[] { id });
        }


        public int GetMaxIdBill()
        {
            return DataProvider.Instance.ExecuteScalarQuery("SELECT MAX(id) FROM bill");
        }


    }
}
