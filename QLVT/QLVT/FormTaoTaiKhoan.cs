using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLVT
{
    public partial class FormTaoTaiKhoan : Form
    {
        private string taiKhoan = "";
        private string matKhau = "";
        private string maNhanVien = "";
        private string vaiTro = "";
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            taiKhoan = txtTenDangNhap.Text;
            matKhau = txtMatKhau.Text;
            maNhanVien = txtMaNhanVien.Text;
            vaiTro = (rdChiNhanh.Checked == true) ? "CHINHANH" : "USER";

            Console.WriteLine(taiKhoan);
            Console.WriteLine(matKhau);
            Console.WriteLine(maNhanVien);
            Console.WriteLine(vaiTro);

            /*declare @returnedResult int
             exec @returnedResult = sp_TraCuu_KiemTraMaNhanVien '20'
             select @returnedResult*/
            String cauTruyVan =
                    "EXEC sp_TaoTaiKhoan '" + taiKhoan + "' , '" + matKhau + "', '"
                    + maNhanVien + "', '" + vaiTro + "'";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {


                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }

                MessageBox.Show("Đăng kí tài khoản thành công\n\nTài khoản: " + taiKhoan + "\nMật khẩu: " + matKhau + "\n Mã Nhân Viên: " + maNhanVien + "\n Vai Trò: " + vaiTro, "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }
        private bool kiemTraDuLieuDauVao()
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Thiếu tên đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Thiếu mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatKhau.Text != txtMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormChinh form = new FormChinh();
            form.Show();
            Dispose();
        }

        private void FormTaoTaiKhoan_Load_1(object sender, EventArgs e)
        {
            if (Program.role == "CONGTY")
            {
                vaiTro = "CONGTY";
                rdCongTy.Enabled = false;
                rdChiNhanh.Enabled = false;
                rdUser.Enabled = false;
                rdCongTy.Checked = true;
            }
            else
            {
                rdCongTy.Enabled = false;
                rdChiNhanh.Enabled = true;
                rdUser.Enabled = true;
            }
        }
    }
}
