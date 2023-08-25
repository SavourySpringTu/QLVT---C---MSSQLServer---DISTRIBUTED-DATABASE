
namespace QLVT
{
    partial class FormTaoTaiKhoan
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
            this.btnDangKi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.rdChiNhanh = new System.Windows.Forms.RadioButton();
            this.rdUser = new System.Windows.Forms.RadioButton();
            this.rdCongTy = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDangKi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.ForeColor = System.Drawing.Color.White;
            this.btnDangKi.Location = new System.Drawing.Point(264, 304);
            this.btnDangKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(114, 50);
            this.btnDangKi.TabIndex = 0;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseVisualStyleBackColor = false;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(537, 348);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(251, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "TẠO TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Xác Nhận Mật Khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vai trò";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(225, 97);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(186, 25);
            this.txtTenDangNhap.TabIndex = 8;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(225, 131);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(186, 25);
            this.txtMaNhanVien.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(225, 167);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(186, 25);
            this.txtMatKhau.TabIndex = 10;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(225, 204);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(186, 25);
            this.txtXacNhanMatKhau.TabIndex = 11;
            // 
            // rdChiNhanh
            // 
            this.rdChiNhanh.AutoSize = true;
            this.rdChiNhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChiNhanh.Location = new System.Drawing.Point(322, 244);
            this.rdChiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdChiNhanh.Name = "rdChiNhanh";
            this.rdChiNhanh.Size = new System.Drawing.Size(89, 21);
            this.rdChiNhanh.TabIndex = 12;
            this.rdChiNhanh.Text = "Chi Nhánh";
            this.rdChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rdUser
            // 
            this.rdUser.AutoSize = true;
            this.rdUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUser.Location = new System.Drawing.Point(432, 244);
            this.rdUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdUser.Name = "rdUser";
            this.rdUser.Size = new System.Drawing.Size(55, 21);
            this.rdUser.TabIndex = 13;
            this.rdUser.Text = "User";
            this.rdUser.UseVisualStyleBackColor = true;
            // 
            // rdCongTy
            // 
            this.rdCongTy.AutoSize = true;
            this.rdCongTy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCongTy.Location = new System.Drawing.Point(225, 244);
            this.rdCongTy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdCongTy.Name = "rdCongTy";
            this.rdCongTy.Size = new System.Drawing.Size(76, 21);
            this.rdCongTy.TabIndex = 14;
            this.rdCongTy.Text = "Công Ty";
            this.rdCongTy.UseVisualStyleBackColor = true;
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 403);
            this.Controls.Add(this.rdCongTy);
            this.Controls.Add(this.rdUser);
            this.Controls.Add(this.rdChiNhanh);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDangKi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "FormTaoTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.RadioButton rdChiNhanh;
        private System.Windows.Forms.RadioButton rdUser;
        private System.Windows.Forms.RadioButton rdCongTy;
    }
}