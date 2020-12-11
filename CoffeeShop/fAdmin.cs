﻿using System;
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
        BindingSource listAccount = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            LoadCategoryIntoComboBox(cbFoodCategory);
            LoadDateTimePickerBill();
            LoadListViewByDate(dtpkFromdate.Value, dtpkTodate.Value);
            dtgvListFood.DataSource = listFood;
            LoadListFood();
            FoodBiding();

            dtgvListAccount.DataSource = listAccount;
            LoadListAccount();
            AccountBinding();
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
            cbAccountType.DataBindings.Add(new Binding("Value", dtgvListAccount.DataSource, "type", true, DataSourceUpdateMode.Never));
        }

        


        #endregion

        #region events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListViewByDate(dtpkFromdate.Value, dtpkTodate.Value);
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
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

        // create event insert food
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        // create event update food
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        // create event delete food
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        // Event click Dishes Search 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listFood.DataSource =  SearchFoodByName(txtSearchFood.Text);
        }

        private void btnShowAcc_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }
    }

    #endregion


}
