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
        // 
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

        #region Method
        // Login account Type
        void ChangeAccount(int type)
        {
            // Login với Type = 1 là Admin, cho phép thao tác vào Tab Admin, Type = 0 là staff -> tab Admin disable 
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " - " + LoginAccount.DisplayName + " ";
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

                // set event for button 
                btn.Click += Btn_Click;
                btn.Tag = item;  // Use Tag property to store object 

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

        // Load all Category table data
        void LoadCategory()
        {
            List<CategoryDTO> listCategory = CategoryADO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";
        }

        // Load the list of food by category id
        void LoadFoodListByCategoryId(int id)
        {
            List<FoodDTO> listFood = FoodADO.Instance.GetFoodListByCategoryId(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "name";
        }

        // Display order list
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

        // Load Table data out of ComboBox
        void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableADO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Events
        // Event click on Table
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as TableDTO).Id; // Get id TableDTO
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableId);
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
        // Order
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                TableDTO table = lsvBill.Tag as TableDTO; // Lấy dữ liệu của bảng table_food qua listBill 
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
            catch (Exception)
            {
                MessageBox.Show("Chưa cập nhật món cho danh mục này, vui lòng chọn danh mục khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event Pay, change paid status and table changes to 'Trống' status
        // Get table data when click
        // Get id of 'bill' by FK table_id
        // Execute Update 'bill'
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Get the current table
            TableDTO table = lsvBill.Tag as TableDTO; // Use the Tag property to store objects
            if (lsvBill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Get id of bill by foreign key talbe_id
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
        }

        // Event Switch Table
        // Get id of current table at listBill
        // Get id of comboboxTable
        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id1 = (lsvBill.Tag as TableDTO).Id; // Getid of current table
            int id2 = (cbSwitchTable.SelectedItem as TableDTO).Id;

            if (MessageBox.Show(string.Format("Bạn muốn chuyển {0} qua {1}?", (lsvBill.Tag as TableDTO).Name,
                (cbSwitchTable.SelectedItem as TableDTO).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableADO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
        }

        // Call the Admin form
        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;
            // bắt sự kiện từ form con Admin
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;

            f.InsertCategory += F_InsertCategory;
            f.DeleteCategory += F_DeleteCategory;
            f.UpdateCategory += F_UpdateCategory;

            f.InsertTable += f_InsertTable;
            f.DeleteTable += f_DeleteTable;
            f.UpdateTable += f_UpdateTable;

            f.ShowDialog();
        }

        // Bắt sự kiện Insert, Delete, Updaet CATEGORY
        private void F_UpdateCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as CategoryDTO).Id);
            if (lsvBill.Tag != null)
            {
                ShowBill((lsvBill.Tag as TableDTO).Id);
            }
            LoadTable();
            LoadCategory();
        }
        private void F_DeleteCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as CategoryDTO).Id);
            if (lsvBill.Tag != null)
            {
                ShowBill((lsvBill.Tag as TableDTO).Id);
            }
            LoadTable();
            LoadCategory();
        }
        private void F_InsertCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as CategoryDTO).Id);
            if (lsvBill.Tag != null)
            {
                ShowBill((lsvBill.Tag as TableDTO).Id);
            }
            LoadTable();
            LoadCategory();
        }

        // Bắt sự kiện Insert, Delete, Updaet TABLE từ form Admin
        private void f_UpdateTable(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void f_DeleteTable(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void f_InsertTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        // Bắt sự kiện Insert, Delete, Updaet FOOD từ form Admin
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
        // Bắt sự kiện cập nhật lại display name từ form AccountProfile
        void f_UpdateAccount(object sender, AccountEvent accountEvent)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + accountEvent.Acc.DisplayName + ")";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
