using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;

namespace CoffeeShop.ADO
{
    public class BillInforADO
    {
        private BillInforADO() { }

        // create instance de khoi tao du lieu cho ca chuong trinh
        private static BillInforADO instance;
        public static BillInforADO Instance
        {
            get
            {
                if (instance == null) instance = new BillInforADO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<BillInforDTO> GetListBillInfor(int id)
        {
            List<BillInforDTO> listBillInfor = new List<BillInforDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM bill_info WHERE id = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInforDTO billInfor = new BillInforDTO(item);
                listBillInfor.Add(billInfor);
            }

            return listBillInfor;
        }

        public void AddBillInfo(int billId, int foodId, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @bill_id , @food_id , @count", new object[] { billId, foodId, count });
        }

        public void RemoveBillInfoByFoodId(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete bill_info where food_id = " + id);
        }
    }
}
