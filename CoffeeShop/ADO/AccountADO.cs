using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.ADO
{
    public class AccountADO
    {
        private AccountADO() { }

        private static AccountADO instance;

        public static AccountADO Instane
        {
            get
            {
                if (instance == null) instance = new AccountADO();
                return instance;
            }
            private set { instance = value; }
        }

        public bool Login(string userName, string password)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, password });

            return result.Rows.Count > 0;
        }


    }
}
