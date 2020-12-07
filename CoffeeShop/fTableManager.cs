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
        public fTableManager()
        {
            InitializeComponent();

            LoadTable();
            LoadCategory();

        }

        // Các event và properties tách ra bằng region
        #region Method
        // Load table
        void LoadTable()
        {
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

        // Load danh muc mon an
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
            CultureInfo culture = new CultureInfo("vi-VN"); // en-US
            txbTotalPrice.Text = totalPrice.ToString("c", culture);
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


        #endregion

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            CategoryDTO selected = cb.SelectedItem as CategoryDTO;
            id = selected.Id;

            LoadFoodListByCategoryId(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            TableDTO table = lsvBill.Tag as TableDTO; // Lấy dữ liệu của bảng table_food qua listBill 
            int billId = BillADO.Instance.GetUncheckBillIdByTableId(table.Id); // Lay id cua bill
            int foodId = (cbFood.SelectedItem as FoodDTO).Id;
            int count = (int)nmFoodCount.Value;
            if (billId == -1)
            {
                BillADO.Instance.InsertBill(table.Id);
                BillInforADO.Instance.InsertBillInfo(BillADO.Instance.GetMaxIdBill(), foodId, count);

            }

        }

        //private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
