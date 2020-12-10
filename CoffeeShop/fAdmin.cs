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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadListFood();
            LoadListViewByDate(dtpkFromdate.Value, dtpkTodate.Value);
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
            dtgvListFood.DataSource = FoodADO.Instance.GetListFood();
        }


       void AddFoodBiding()
        {
            txtFoodName.DataBindings.Add(new Binding("Text", dtgvListFood.DataSource, "Name"));
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
        #endregion

    }
}
