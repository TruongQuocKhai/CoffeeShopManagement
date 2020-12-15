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
    public partial class fAdmin : Form
    {
        // Using listfood of BindingSource() object when changing data is still biding
        BindingSource listFood = new BindingSource();
        BindingSource listFoodCategory = new BindingSource();
        BindingSource listFoodTable = new BindingSource();
        BindingSource listAccount = new BindingSource();

        public AccountDTO loginAccount;
        public fAdmin()
        {
            InitializeComponent();
            // Category Combox 
            LoadCategoryIntoComboBox(cbFoodCategory);
            // Revenue
            LoadDateTimePickerBill();
            LoadListViewByDate(dtpkFromdate.Value, dtpkTodate.Value);
            // Food
            dtgvListFood.DataSource = listFood;
            LoadListFood();
            FoodBiding();
            // Account
            dtgvListAccount.DataSource = listAccount;
            LoadListAccount();
            AccountBinding();
            // Food Category
            dtgvFoodCategory.DataSource = listFoodCategory;
            LoadFoodCategory();
            FoodCategoryBinding();
            // Food Table
            dtgvFoodTable.DataSource = listFoodTable;
            LoadListFoodTable();
            FoodTableBinding();
        }

        #region methods

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromdate.Value = new DateTime(today.Year, today.Month, 1); // return first month
            dtpkTodate.Value = dtpkFromdate.Value.AddMonths(1).AddDays(-1); // return last month
        }

        void LoadListViewByDate(DateTime checkin, DateTime checkout)
        {
            dtgvBill.DataSource = BillADO.Instance.GetListBill(checkin, checkout);
        }

        // Load all List food in database
        void LoadListFood()
        {
            listFood.DataSource = FoodADO.Instance.GetListFood();
        }

        // Binding food infor 
        void FoodBiding()
        {
            txtId.DataBindings.Add(new Binding("Text", dtgvListFood.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtFoodName.DataBindings.Add(new Binding("Text", dtgvListFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Value", dtgvListFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        // Load Food Category into Combobox
        void LoadCategoryIntoComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryADO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        // Dish search Function by name
        List<FoodDTO> SearchFoodByName(string name)
        {
            List<FoodDTO> listFood = FoodADO.Instance.SearchFoodByName(name);
            return listFood;
        }

        // Load the list of account out of datagidview
        void LoadListAccount()
        {
            listAccount.DataSource = AccountADO.Instane.GetListAccount();
        }

        // Binding Acccount Info
        void AccountBinding()
        {
            txtAccountName.DataBindings.Add(new Binding("Text", dtgvListAccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvListAccount.DataSource, "display_name", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvListAccount.DataSource, "type", true, DataSourceUpdateMode.Never));
        }

        void LoadFoodCategory()
        {
            listFoodCategory.DataSource = CategoryADO.Instance.GetListCategory();
        }

        // Binding Food Category
        void FoodCategoryBinding()
        {
            txtCategoryId.DataBindings.Add(new Binding("Text", dtgvFoodCategory.DataSource, "id", true, DataSourceUpdateMode.Never)); //true, DataSourceUpdateMode.Never: sua cac truong ben ngoai ko anh huong den datagidview
            txtCategoryName.DataBindings.Add(new Binding("Text", dtgvFoodCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        // Load list Food Table
        void LoadListFoodTable()
        {
            listFoodTable.DataSource = TableADO.Instance.LoadTableList();
        }
        // Binding foodtable 
        void FoodTableBinding()
        {
            txtTableName.DataBindings.Add(new Binding("Text", dtgvFoodTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtTableId.DataBindings.Add(new Binding("Text", dtgvFoodTable.DataSource, "Id", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region events

        // Create event Insert, Delete, Update Food
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        // Create event Insert, Delete, Update Table
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        // TAB PAGE FOOD
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListViewByDate(dtpkFromdate.Value, dtpkTodate.Value);
        }
        // binding category by id of food
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvListFood.SelectedCells.Count > 0)
                {
                    int id = (int)(dtgvListFood.SelectedCells[0].OwningRow.Cells["FoodCategoryId"].Value);// Get id value from listFood
                    CategoryDTO category = CategoryADO.Instance.GetCategoryById(id); // Execute the command when got id
                    cbFoodCategory.SelectedItem = category; // assigns object containing id to the selected Item

                    int index = 0;
                    int i = 0;
                    foreach (CategoryDTO item in cbFoodCategory.Items)
                    {
                        if (item.Id == category.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int category = (cbFoodCategory.SelectedItem as CategoryDTO).Id;
            float price = (float)nmPrice.Value;

            if (FoodADO.Instance.InsertFood(name, category, price))
            {
                MessageBox.Show("Thêm mới thành công!");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm mới món không thành công!");
            }
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            int foodId = Convert.ToInt32(txtId.Text);
            string name = txtFoodName.Text;
            int categoryId = (cbFoodCategory.SelectedItem as CategoryDTO).Id;
            float price = (float)nmPrice.Value;

            if (FoodADO.Instance.UpdateFood(name, categoryId, price, foodId))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadListFood();
                if (updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int foodId = Convert.ToInt32(txtId.Text);

            if (FoodADO.Instance.DeleteFood(foodId))
            {
                MessageBox.Show("Xóa thành công!");
                LoadListFood();
                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
        // Event click Dishes Search 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listFood.DataSource = SearchFoodByName(txtSearchFood.Text);
        }

        // TAB PAGE ACCOUNT
        // event click Add, Delete, Update Account inside admin
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txtAccountName.Text;
            string displayName = txtDisplayName.Text;
            int type = Convert.ToInt32(nmAccountType.Text);

            if (AccountADO.Instane.InsertAccount(username, displayName, type))
            {
                MessageBox.Show("Thêm mới tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Thêm mới tài khoản thất bại!");
            }
        }
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string username = txtAccountName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmAccountType.Value;

            if (AccountADO.Instane.UpdateAccountInsideAdmin(username, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!");
            }
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

            string username = txtAccountName.Text;
            if (loginAccount.Username.Equals(username))
            {
                MessageBox.Show("Bạn không thể xóa tài khoản hiện tại của bạn!");
                return;
            }
            if (AccountADO.Instane.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!");
            }
        }
        // reset password = 0
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string username = txtAccountName.Text;
            if (AccountADO.Instane.ResetPassword(username))
            {
                MessageBox.Show("Reset password thành công!");
            }
            else
            {
                MessageBox.Show("Reset password thất bại!");
            }
        }

        // TAB PAGE CATEGORY
        // event click Add, Delete, Update Category
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            if (CategoryADO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công!");
                LoadFoodCategory();
            }
            else
            {
                MessageBox.Show("Xóa danh mục thất bại!");
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            if (CategoryADO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm mới tài khoản thành công!");
                LoadFoodCategory();
            }
            else
            {
                MessageBox.Show("Thêm mới tài khoản thất bại!");
            }
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            string name = txtCategoryName.Text;
            if (CategoryADO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
                LoadFoodCategory();
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!");
            }

        }

        // TAB PAGE TABLE
        // event click Add, Delete, Update FoodTable
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;

            if (TableADO.Instance.InsertFoodTabel(name))
            {
                MessageBox.Show("Thêm bàn thành công!");
                LoadListFoodTable();
                if (insertTable != null)
                {
                    insertTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại!");
            }
        }
        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            int id = Convert.ToInt32(txtTableId.Text);
            if (TableADO.Instance.UpdateFoodTable(id, name))
            {
                MessageBox.Show("Cập nhật bàn thành công!");
                LoadListFoodTable();
                if (updateTable != null)
                {
                    updateTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Cập nhật bàn thất bại!");
            }
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtTableId.Text);
            if (TableADO.Instance.DeleteFoodTable(id))
            {
                MessageBox.Show("Xóa bàn thành công!");
                LoadListFoodTable();
                if (deleteTable != null)
                {
                    deleteTable(this, new EventArgs());
                }
            }
            else
            {
                {
                    MessageBox.Show("Xóa bàn thất bại!");
                }
            }

        }

        // TAB PAGE REPORT 
        private void fAdmin_Load(object sender, EventArgs e)
        {
            this.USP_GetListBillByDateForReportTableAdapter.Fill(this.CoffeeShopManagementDataSet.USP_GetListBillByDateForReport, dtpkFromdate.Value, dtpkTodate.Value);
            this.reportViewer1.RefreshReport();
        }
    }

    #endregion


}
