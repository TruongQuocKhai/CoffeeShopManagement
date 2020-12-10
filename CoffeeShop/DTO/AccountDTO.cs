using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class AccountDTO
    {
        public AccountDTO(string username, string displayName, int type, string password = null)
        {
            this.username = username;
            this.password = password;
            this.displayName = displayName;
            this.type = type;
        }

        public AccountDTO(DataRow row)
        {
            this.username = row["username"].ToString();
            this.password = row["password"].ToString();
            this.displayName = row["display_name"].ToString();
            this.type = (int)row["type"];
        }

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
