using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;

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

        public bool Login(string username, string password)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            return result.Rows.Count > 0;
        }

        public AccountDTO GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from account where username = '"+username+"'");

            foreach (DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }

        public bool UpdateAccount(string username, string displayName, string password, string newPassword)
        {
            string query = "exec USP_UpdateAccount @username , @display_name , @password , @newpassword";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, displayName, password, newPassword });
            return result > 0; 
            
        }
    }
}
