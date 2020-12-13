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

        // External account updates
        public bool UpdateAccount(string username, string displayName, string password, string newPassword)
        {
            string query = "exec USP_UpdateAccount @username , @display_name , @password , @newpassword";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, displayName, password, newPassword });
            return result > 0; 
        }

        // Get List Account
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select username, display_name, type from account");
        }

        // Add account
        public bool InsertAccount(string username, string displayName, int type)
        {
            string query = string.Format("insert into account(username, display_name, type) values('{0}', N'{1}', {2})", username, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // update account inside admin.
        public bool UpdateAccountInsideAdmin(string username, string displayName, int type)
        {
            string query = string.Format("update account set display_name = N'{0}', type = {1} where username = N'{2}'", displayName, type, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string username)
        {
            string query = string.Format("delete account where username = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // reset password = 0
        public bool ResetPassword(string username)
        {
            string query = string.Format("update account set password = N'0' where username = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
