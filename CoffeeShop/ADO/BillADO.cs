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

        // Lấy thông tin bill theo id của bàn
        public int GetUncheckBillIdByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM bill WHERE table_id = " + id + " and status = 0");

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.Id;
            }
            else
            {
                return -1; // bàn đang trống, ko có bill nào
            }
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @table_id" , new object[] { id });
        }                                            


        public int GetMaxIdBill()
        { // try catch -> return 1;
            return (int)DataProvider.Instance.ExecuteScalarQuery("SELECT MAX(id) FROM bill");
        }

        public void Checkout(int id, float totalPrice)
        {
            string query = "UPDATE bill SET checkout_date = GETDATE(), status = 1, "+ "totalPrice = " + totalPrice + "WHERE id = " +id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }


        public DataTable GetListBill(DateTime checkin, DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBill @checkin , @checkout ", new object[] { checkin, checkout });
        }
    }
}
