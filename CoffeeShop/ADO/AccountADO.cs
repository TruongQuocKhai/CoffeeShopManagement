using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DTO;

// kiểu bool: Is + adj, Can + V, Has + Quá khứ phân từ(V2_ed) , Động từ số nhiều + N, Động từ số nhiều.


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

        // CanGet
        public bool CanGetUsernamePassword(string username, string password)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public bool CheckPassword(string password)
        {
            string query = string.Format("select password from account where password = '{0}'", password);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
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
        // channge personal information
        public bool HasChangedAccount(string username, string displayName, string password, string newPassword)
        {
            string query = "USP_UpdateAccount @username , @display_name , @password , @newpassword";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, displayName, password, newPassword });
            return result > 0; 
        }

        // Get List Account
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select username, display_name, type from account");
        }

        // Name the method the return type bool: CanInsertAccount
        public bool CanAddAccount(string username, string displayName, int type)
        {
            string query = string.Format("insert into account(username, display_name, type) values('{0}', N'{1}', {2})", username, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Name the method the return bool: CanInsertAccount
        public bool CanUpdateAccount(string username, string displayName, int type)
        {
            string query = string.Format("update account set display_name = N'{0}', type = {1} where username = N'{2}'", displayName, type, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool CanRemoveAccount(string username)
        {
            string query = string.Format("delete account where username = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // reset password = 0
        // CanResetPassword
        public bool CanResetPassword(string username)
        {
            string query = string.Format("update account set password = N'0' where username = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
