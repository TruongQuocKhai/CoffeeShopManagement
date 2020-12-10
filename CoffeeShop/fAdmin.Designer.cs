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
            this.tpFoodCategory = new System.Windows.Forms.TabPage();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.dtgvListFood = new System.Windows.Forms.DataGridView();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpFoodCategory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(510, 313);
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
            this.tpBill.Size = new System.Drawing.Size(502, 287);
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
            this.tpFood.Controls.Add(this.txtPrice);
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
            this.tpFood.Size = new System.Drawing.Size(502, 287);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // tpFoodCategory
            // 
            this.tpFoodCategory.Location = new System.Drawing.Point(4, 22);
            this.tpFoodCategory.Name = "tpFoodCategory";
            this.tpFoodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoodCategory.Size = new System.Drawing.Size(502, 287);
            this.tpFoodCategory.TabIndex = 2;
            this.tpFoodCategory.Text = "Danh mục";
            this.tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(502, 287);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(502, 287);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
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
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(6, 6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(87, 6);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFood.TabIndex = 2;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(168, 6);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(75, 23);
            this.btnEditFood.TabIndex = 3;
            this.btnEditFood.Text = "Cập nhật";
            this.btnEditFood.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên món:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Danh mục:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(389, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 19);
            this.txtId.TabIndex = 9;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(389, 64);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(100, 19);
            this.txtFoodName.TabIndex = 10;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(389, 103);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(100, 20);
            this.cbFoodCategory.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(389, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 19);
            this.txtPrice.TabIndex = 12;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 365);
            this.Controls.Add(this.tcAdmin);
            this.Name = "fAdmin";
            this.Text = "Admin";
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.tpBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.tpFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TabPage tpFoodCategory;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.DateTimePicker dtpkTodate;
        private System.Windows.Forms.DateTimePicker dtpkFromdate;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
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
    }
}