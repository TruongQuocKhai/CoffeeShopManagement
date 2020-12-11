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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkTodate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromdate = new System.Windows.Forms.DateTimePicker();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dtgvListFood = new System.Windows.Forms.DataGridView();
            this.tpFoodCategory = new System.Windows.Forms.TabPage();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.btnShowAccount = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowAcc = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvListAccount = new System.Windows.Forms.DataGridView();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).BeginInit();
            this.btnShowAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpFoodCategory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.btnShowAccount);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(533, 313);
            this.tcAdmin.TabIndex = 0;
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
            this.dtgvBill.RowTemplate.Height = 21;
            this.dtgvBill.Size = new System.Drawing.Size(490, 236);
            this.dtgvBill.TabIndex = 0;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.txtSearchFood);
            this.tpFood.Controls.Add(this.btnSearch);
            this.tpFood.Controls.Add(this.nmPrice);
            this.tpFood.Controls.Add(this.cbFoodCategory);
            this.tpFood.Controls.Add(this.txtFoodName);
            this.tpFood.Controls.Add(this.txtId);
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
            this.dtgvListFood.RowTemplate.Height = 21;
            this.dtgvListFood.Size = new System.Drawing.Size(318, 246);
            this.dtgvListFood.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            this.tpFoodCategory.Location = new System.Drawing.Point(4, 22);
            this.tpFoodCategory.Name = "tpFoodCategory";
            this.tpFoodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoodCategory.Size = new System.Drawing.Size(525, 287);
            this.tpFoodCategory.TabIndex = 2;
            this.tpFoodCategory.Text = "Danh mục";
            this.tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(525, 287);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Controls.Add(this.cbAccountType);
            this.btnShowAccount.Controls.Add(this.button5);
            this.btnShowAccount.Controls.Add(this.txtDisplayName);
            this.btnShowAccount.Controls.Add(this.txtAccountName);
            this.btnShowAccount.Controls.Add(this.label9);
            this.btnShowAccount.Controls.Add(this.label8);
            this.btnShowAccount.Controls.Add(this.label7);
            this.btnShowAccount.Controls.Add(this.btnShowAcc);
            this.btnShowAccount.Controls.Add(this.button3);
            this.btnShowAccount.Controls.Add(this.button2);
            this.btnShowAccount.Controls.Add(this.button1);
            this.btnShowAccount.Controls.Add(this.dtgvListAccount);
            this.btnShowAccount.Location = new System.Drawing.Point(4, 22);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Padding = new System.Windows.Forms.Padding(3);
            this.btnShowAccount.Size = new System.Drawing.Size(525, 287);
            this.btnShowAccount.TabIndex = 4;
            this.btnShowAccount.Text = "Tài khoản";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(332, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "Đặt lại mật khẩu";
            this.button5.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtgvListAccount
            // 
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListAccount.Location = new System.Drawing.Point(6, 35);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowTemplate.Height = 21;
            this.dtgvListAccount.Size = new System.Drawing.Size(318, 246);
            this.dtgvListAccount.TabIndex = 0;
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(332, 169);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(169, 20);
            this.cbAccountType.TabIndex = 12;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.tcAdmin);
            this.Name = "fAdmin";
            this.Text = "Admin";
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.tpBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.tpFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).EndInit();
            this.btnShowAccount.ResumeLayout(false);
            this.btnShowAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TabPage tpFoodCategory;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage btnShowAccount;
        private System.Windows.Forms.DateTimePicker dtpkTodate;
        private System.Windows.Forms.DateTimePicker dtpkFromdate;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dtgvListFood;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowAcc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvListAccount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbAccountType;
    }
}