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

namespace CoffeeShop
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string password = txbPassword.Text;

            if (Login(userName, password))
            {
                fTableManager f = new fTableManager();
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("Username hoac password sai!");
            }
        }

        private bool Login(string userName, string passWord)
        {
            return AccountADO.Instane.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
