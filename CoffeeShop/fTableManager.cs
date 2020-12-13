using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.ADO;
using CoffeeShop.DTO;

namespace CoffeeShop
{
    public partial class fTableManager : Form
    {
        private AccountDTO loginAccount;
        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(LoginAccount.Type); }
        }
        public fTableManager(AccountDTO acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboBoxTable(cbSwitchTable);
        }

        // Các event và properties tách ra bằng region
        #region Method
        // Login account Type
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + LoginAccount.DisplayName + ")";
        }

        // Load table
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<TableDTO> tableList = TableADO.Instance.LoadTableList();

            foreach (TableDTO item in tableList)
            {
                Button btn = new Button() { Width = TableADO.TableWidth, Height = TableADO.TableHeigth };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                // set event cho button 
                btn.Click += Btn_Click;
                btn.Tag = item;  // lay ca table khi click vao button

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.AliceBlue;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        // Load Food Category
        void LoadCategory()
        {
            List<CategoryDTO> listCategory = CategoryADO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";
        }

        // load danh sach cac mon an theo id danh muc 
        void LoadFoodListByCategoryId(int id)
        {
            List<FoodDTO> listFood = FoodADO.Instance.GetFoodListByCategoryId(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "name";
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<MenuDTO> listBillInfor = MenuADO.Instance.GetListMenuByTable(id);

            float totalPrice = 0;
            foreach (MenuDTO item in listBillInfor)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());

                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(listViewItem);
            }
            // CultureInfo culture = new CultureInfo("vi-VN"); // en-US
            // txbTotalPrice.Text = totalPrice.ToString("c", culture);
            txbTotalPrice.Text = string.Format("{0:#,##0}", totalPrice);
        }

        void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableADO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as TableDTO).Id; // lay ra id trong Object TableDTO
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableId);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        // combo box Category
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            CategoryDTO selected = cb.SelectedItem as CategoryDTO;
            id = selected.Id;

            // Load danh sach mon an theo category
            LoadFoodListByCategoryId(id);
        }


        // Add food
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            TableDTO table = lsvBill.Tag as TableDTO; // Lấy dữ liệu của bảng table_food qua listBill 
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn!");
            }
            int billId = BillADO.Instance.GetUncheckBillIdByTableId(table.Id); // Lay thong tin bill du vao id table
            int foodId = (cbFood.SelectedItem as FoodDTO).Id;
            int count = (int)nmFoodCount.Value;
            if (billId == -1) // billId == -1: bàn trống, ko có bill -> insert bill mới
            {
                BillADO.Instance.InsertBill(table.Id);
                BillInforADO.Instance.InsertBillInfo(BillADO.Instance.GetMaxIdBill(), foodId, count);
            }
            else // bàn có người, bill đã tồn tại -> Insert bill dựa vào billId đã có
            {
                BillInforADO.Instance.InsertBillInfo(billId, foodId, count);
            }
            ShowBill(table.Id);
            LoadTable();  // update Status again
        }

        // Bill payment button
        // Change the Status of the Table
        // 
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //try
            //{
            // Get the current table
            TableDTO table = lsvBill.Tag as TableDTO;
            // Get bill by talbe_id
            int billId = BillADO.Instance.GetUncheckBillIdByTableId(table.Id);


            double totalPrice = Convert.ToDouble(txbTotalPrice.Text);


            if (billId != -1) // bill already exist, the table have someone
            {
                if (MessageBox.Show("Bạn muốn thanh toán hóa đơn cho " + table.Name + "?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillADO.Instance.Checkout(billId, (float)totalPrice);
                    ShowBill(table.Id);
                    LoadTable(); // update Status again
                }
            }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Vui lòng chọn bàn cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            try
            {
                int id1 = (lsvBill.Tag as TableDTO).Id; // Getid of current table
                int id2 = (cbSwitchTable.SelectedItem as TableDTO).Id;

                if (MessageBox.Show(string.Format("Bạn muốn chuyển {0} qua {1}?", (lsvBill.Tag as TableDTO).Name,
                    (cbSwitchTable.SelectedItem as TableDTO).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TableADO.Instance.SwitchTable(id1, id2);
                    LoadTable();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;
            f.ShowDialog();
        }

        private void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as CategoryDTO).Id);
            if (lsvBill.Tag != null)
            {
                ShowBill((lsvBill.Tag as TableDTO).Id);
            }
        }

        private void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as CategoryDTO).Id);
            if (lsvBill.Tag != null)
            {
                ShowBill((lsvBill.Tag as TableDTO).Id);
            }
            LoadTable();
        }

        private void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as CategoryDTO).Id);
            if (lsvBill.Tag != null)
            {
                ShowBill((lsvBill.Tag as TableDTO).Id);
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }
        // Xu ly event cập nhật lại display name trực tiếp ko cần đăng nhập lại
        void f_UpdateAccount(object sender, AccountEvent accountEvent)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + accountEvent.Acc.DisplayName + ")";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
