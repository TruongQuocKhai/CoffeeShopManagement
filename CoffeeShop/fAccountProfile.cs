using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.ADO;
using CoffeeShop.DTO;

namespace CoffeeShop
{
    public partial class fAccountProfile : Form
    {
        private AccountDTO loginAccount;
        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(AccountDTO acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        public fAccountProfile() { }

        #region methods
        public void ChangeAccount(AccountDTO acc)
        {
            txbUserName.Text = LoginAccount.Username;
            txbDisplayName.Text = LoginAccount.DisplayName;
        }

        void UpdateAccountInfor()
        {
            string username = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            string password = txbPassword.Text;
            string newPassword = txbNewPassword.Text;
            string confirmNewPassword = txbConfirmNewPassword.Text;

            if (!newPassword.Equals(confirmNewPassword))
            {
                MessageBox.Show("Xác nhận mật khẩu chưa đúng!");
            }
            else
            {
                if (AccountADO.Instane.UpdateAccount(username, displayName, password, newPassword))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(AccountADO.Instane.GetAccountByUsername(username)));
                        this.Hide();
                    }
                }
                else if(password == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu để đổi tên hiển thị!");
                }
                else if (!password.Equals(AccountADO.Instane.CheckPassword(password)))
                {
                    MessageBox.Show("Mật khẩu sai, vui lòng thử lại!");
                }
            }
        }
        #endregion

        #region events

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            UpdateAccountInfor();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }

    // Class Event
    public class AccountEvent : EventArgs
    {
        private AccountDTO acc;
        public AccountDTO Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public AccountEvent(AccountDTO acc)
        {
            this.Acc = acc;
        }
    }
}
