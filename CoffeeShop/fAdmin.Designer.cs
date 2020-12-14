namespace CoffeeShop
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnShowAccount = new System.Windows.Forms.TabPage();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowAcc = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.dtgvListAccount = new System.Windows.Forms.DataGridView();
            this.tpFoodCategory = new System.Windows.Forms.TabPage();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dtgvFoodCategory = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dtgvListFood = new System.Windows.Forms.DataGridView();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkTodate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromdate = new System.Windows.Forms.DateTimePicker();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpReport = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_GetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsRevenueReport = new CoffeeShop.DsRevenueReport();
            this.USP_GetListBillByDateForReportTableAdapter = new CoffeeShop.DsRevenueReportTableAdapters.USP_GetListBillByDateForReportTableAdapter();
            this.btnShowAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.tpFoodCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodCategory)).BeginInit();
            this.tpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).BeginInit();
            this.tpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tcAdmin.SuspendLayout();
            this.tpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsRevenueReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Controls.Add(this.nmAccountType);
            this.btnShowAccount.Controls.Add(this.btnResetPassword);
            this.btnShowAccount.Controls.Add(this.txtDisplayName);
            this.btnShowAccount.Controls.Add(this.txtAccountName);
            this.btnShowAccount.Controls.Add(this.label9);
            this.btnShowAccount.Controls.Add(this.label8);
            this.btnShowAccount.Controls.Add(this.label7);
            this.btnShowAccount.Controls.Add(this.btnShowAcc);
            this.btnShowAccount.Controls.Add(this.btnUpdateAccount);
            this.btnShowAccount.Controls.Add(this.btnDeleteAccount);
            this.btnShowAccount.Controls.Add(this.btnAddAccount);
            this.btnShowAccount.Controls.Add(this.dtgvListAccount);
            this.btnShowAccount.Location = new System.Drawing.Point(4, 22);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Padding = new System.Windows.Forms.Padding(3);
            this.btnShowAccount.Size = new System.Drawing.Size(525, 287);
            this.btnShowAccount.TabIndex = 4;
            this.btnShowAccount.Text = "Tài khoản";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // nmAccountType
            // 
            this.nmAccountType.Location = new System.Drawing.Point(332, 161);
            this.nmAccountType.Margin = new System.Windows.Forms.Padding(2);
            this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(72, 19);
            this.nmAccountType.TabIndex = 12;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(332, 195);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(169, 26);
            this.btnResetPassword.TabIndex = 11;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(332, 109);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(169, 19);
            this.txtDisplayName.TabIndex = 9;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(332, 62);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(169, 19);
            this.txtAccountName.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "Loại tài khoản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên hiển thị:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên tài khoản:";
            // 
            // btnShowAcc
            // 
            this.btnShowAcc.Location = new System.Drawing.Point(249, 6);
            this.btnShowAcc.Name = "btnShowAcc";
            this.btnShowAcc.Size = new System.Drawing.Size(75, 23);
            this.btnShowAcc.TabIndex = 4;
            this.btnShowAcc.Text = "Xem";
            this.btnShowAcc.UseVisualStyleBackColor = true;
            this.btnShowAcc.Click += new System.EventHandler(this.btnShowAcc_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(168, 6);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAccount.TabIndex = 3;
            this.btnUpdateAccount.Text = "Cập nhật";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 6);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // dtgvListAccount
            // 
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListAccount.Location = new System.Drawing.Point(6, 35);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowHeadersWidth = 51;
            this.dtgvListAccount.RowTemplate.Height = 21;
            this.dtgvListAccount.Size = new System.Drawing.Size(318, 246);
            this.dtgvListAccount.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            this.tpFoodCategory.Controls.Add(this.txtCategoryName);
            this.tpFoodCategory.Controls.Add(this.txtCategoryId);
            this.tpFoodCategory.Controls.Add(this.label11);
            this.tpFoodCategory.Controls.Add(this.label10);
            this.tpFoodCategory.Controls.Add(this.btnShowCategory);
            this.tpFoodCategory.Controls.Add(this.btnUpdateCategory);
            this.tpFoodCategory.Controls.Add(this.btnDeleteCategory);
            this.tpFoodCategory.Controls.Add(this.btnAddCategory);
            this.tpFoodCategory.Controls.Add(this.dtgvFoodCategory);
            this.tpFoodCategory.Location = new System.Drawing.Point(4, 22);
            this.tpFoodCategory.Name = "tpFoodCategory";
            this.tpFoodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoodCategory.Size = new System.Drawing.Size(525, 287);
            this.tpFoodCategory.TabIndex = 2;
            this.tpFoodCategory.Text = "Danh mục";
            this.tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(410, 85);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(109, 19);
            this.txtCategoryName.TabIndex = 8;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(410, 43);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(109, 19);
            this.txtCategoryId.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tên danh mục:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "Mã Danh mục:";
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(252, 6);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(75, 23);
            this.btnShowCategory.TabIndex = 4;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(171, 6);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCategory.TabIndex = 3;
            this.btnUpdateCategory.Text = "Cập nhật";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(6, 6);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dtgvFoodCategory
            // 
            this.dtgvFoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFoodCategory.Location = new System.Drawing.Point(6, 35);
            this.dtgvFoodCategory.Name = "dtgvFoodCategory";
            this.dtgvFoodCategory.RowTemplate.Height = 21;
            this.dtgvFoodCategory.Size = new System.Drawing.Size(321, 234);
            this.dtgvFoodCategory.TabIndex = 0;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.txtSearchFood);
            this.tpFood.Controls.Add(this.txtFoodName);
            this.tpFood.Controls.Add(this.txtId);
            this.tpFood.Controls.Add(this.btnSearch);
            this.tpFood.Controls.Add(this.nmPrice);
            this.tpFood.Controls.Add(this.cbFoodCategory);
            this.tpFood.Controls.Add(this.label6);
            this.tpFood.Controls.Add(this.label5);
            this.tpFood.Controls.Add(this.label4);
            this.tpFood.Controls.Add(this.label3);
            this.tpFood.Controls.Add(this.btnShowFood);
            this.tpFood.Controls.Add(this.btnEditFood);
            this.tpFood.Controls.Add(this.btnDeleteFood);
            this.tpFood.Controls.Add(this.btnAddFood);
            this.tpFood.Controls.Add(this.dtgvListFood);
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(525, 287);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(330, 8);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(118, 19);
            this.txtSearchFood.TabIndex = 14;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(394, 101);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(120, 19);
            this.txtFoodName.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(394, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(120, 19);
            this.txtId.TabIndex = 9;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(452, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm món";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // nmPrice
            // 
            this.nmPrice.Location = new System.Drawing.Point(394, 183);
            this.nmPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(120, 19);
            this.nmPrice.TabIndex = 12;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(394, 142);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(120, 20);
            this.cbFoodCategory.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Danh mục:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên món:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id:";
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(249, 6);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(75, 23);
            this.btnShowFood.TabIndex = 4;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(168, 6);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(75, 23);
            this.btnEditFood.TabIndex = 3;
            this.btnEditFood.Text = "Cập nhật";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFood.TabIndex = 2;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(6, 6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dtgvListFood
            // 
            this.dtgvListFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListFood.Location = new System.Drawing.Point(6, 35);
            this.dtgvListFood.Name = "dtgvListFood";
            this.dtgvListFood.RowHeadersWidth = 51;
            this.dtgvListFood.RowTemplate.Height = 21;
            this.dtgvListFood.Size = new System.Drawing.Size(318, 246);
            this.dtgvListFood.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.label1);
            this.tpBill.Controls.Add(this.label2);
            this.tpBill.Controls.Add(this.dtpkTodate);
            this.tpBill.Controls.Add(this.dtpkFromdate);
            this.tpBill.Controls.Add(this.btnViewBill);
            this.tpBill.Controls.Add(this.dtgvBill);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(525, 287);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến ngày:";
            // 
            // dtpkTodate
            // 
            this.dtpkTodate.Location = new System.Drawing.Point(272, 14);
            this.dtpkTodate.Name = "dtpkTodate";
            this.dtpkTodate.Size = new System.Drawing.Size(141, 19);
            this.dtpkTodate.TabIndex = 3;
            // 
            // dtpkFromdate
            // 
            this.dtpkFromdate.Location = new System.Drawing.Point(59, 14);
            this.dtpkFromdate.Name = "dtpkFromdate";
            this.dtpkFromdate.Size = new System.Drawing.Size(138, 19);
            this.dtpkFromdate.TabIndex = 2;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(419, 11);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(75, 23);
            this.btnViewBill.TabIndex = 1;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(6, 45);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 21;
            this.dtgvBill.Size = new System.Drawing.Size(490, 236);
            this.dtgvBill.TabIndex = 0;
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpFoodCategory);
            this.tcAdmin.Controls.Add(this.btnShowAccount);
            this.tcAdmin.Controls.Add(this.tpReport);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(533, 313);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpReport
            // 
            this.tpReport.Controls.Add(this.reportViewer1);
            this.tpReport.Location = new System.Drawing.Point(4, 22);
            this.tpReport.Name = "tpReport";
            this.tpReport.Padding = new System.Windows.Forms.Padding(3);
            this.tpReport.Size = new System.Drawing.Size(525, 287);
            this.tpReport.TabIndex = 5;
            this.tpReport.Text = "Report";
            this.tpReport.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetListBillByDateForReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CoffeeShop.RevenueReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(519, 281);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_GetListBillByDateForReportBindingSource
            // 
            this.USP_GetListBillByDateForReportBindingSource.DataMember = "USP_GetListBillByDateForReport";
            this.USP_GetListBillByDateForReportBindingSource.DataSource = this.DsRevenueReport;
            // 
            // DsRevenueReport
            // 
            this.DsRevenueReport.DataSetName = "DsRevenueReport";
            this.DsRevenueReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_GetListBillByDateForReportTableAdapter
            // 
            this.USP_GetListBillByDateForReportTableAdapter.ClearBeforeFill = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 342);
            this.Controls.Add(this.tcAdmin);
            this.Name = "fAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.btnShowAccount.ResumeLayout(false);
            this.btnShowAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.tpFoodCategory.ResumeLayout(false);
            this.tpFoodCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodCategory)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.tpFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).EndInit();
            this.tpBill.ResumeLayout(false);
            this.tpBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            this.tpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsRevenueReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage btnShowAccount;
        private System.Windows.Forms.NumericUpDown nmAccountType;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowAcc;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.DataGridView dtgvListAccount;
        private System.Windows.Forms.TabPage tpFoodCategory;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dtgvListFood;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkTodate;
        private System.Windows.Forms.DateTimePicker dtpkFromdate;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dtgvFoodCategory;
        private System.Windows.Forms.TabPage tpReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateForReportBindingSource;
        private DsRevenueReport DsRevenueReport;
        private DsRevenueReportTableAdapters.USP_GetListBillByDateForReportTableAdapter USP_GetListBillByDateForReportTableAdapter;
    }
}