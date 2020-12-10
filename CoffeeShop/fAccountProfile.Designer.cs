namespace CoffeeShop
{
    partial class fAccountProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hiển thị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập lại mật khẩu mới:";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(155, 29);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(152, 19);
            this.txbUserName.TabIndex = 5;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(156, 60);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(152, 19);
            this.txbDisplayName.TabIndex = 6;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(156, 92);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(152, 19);
            this.txbPassword.TabIndex = 7;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Location = new System.Drawing.Point(156, 123);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(152, 19);
            this.txbNewPassword.TabIndex = 8;
            // 
            // txbConfirmNewPassword
            // 
            this.txbConfirmNewPassword.Location = new System.Drawing.Point(156, 151);
            this.txbConfirmNewPassword.Name = "txbConfirmNewPassword";
            this.txbConfirmNewPassword.Size = new System.Drawing.Size(152, 19);
            this.txbConfirmNewPassword.TabIndex = 9;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(153, 191);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAccount.TabIndex = 10;
            this.btnUpdateAccount.Text = "Cập nhật";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fAccountProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 234);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.txbConfirmNewPassword);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbDisplayName);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fAccountProfile";
            this.Text = "Tài khoản cá nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.TextBox txbConfirmNewPassword;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnExit;
    }
}