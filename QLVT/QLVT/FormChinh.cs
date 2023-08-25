using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormNhanVien form = new FormNhanVien();
                this.Dispose();
                //form.MdiParent = this;
                form.Show();
            }
        }
        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }
        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout();
            Form f = this.CheckExists(typeof(Login));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Login form = new Login();
                this.Dispose();
                form.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormVatTu form = new FormVatTu();
                this.Dispose();
                form.Show();
            }
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            this.ttMaNV.Text = "Mã NV: " + Program.userName;
            this.ttHoTen.Text = "Họ Tên: " + Program.staff;
            this.ttNhom.Text = "Nhóm: " + Program.role;
            if(Program.role == "USER"){
                this.btnTaoTaiKhoan.Enabled = false;
                this.btnBCNhanVien.Enabled = false;
                this.btnBCVatTu.Enabled = false;
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormPhieuXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormPhieuXuat form = new FormPhieuXuat();
                this.Dispose();
                form.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormTaoTaiKhoan form = new FormTaoTaiKhoan();
            form.Show();
            Dispose();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDonDatHang form = new FormDonDatHang();
            form.Show();
            Dispose();
        }

        private void btnPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormPhieuNhap form = new FormPhieuNhap();
            form.Show();
            Dispose();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormKhoHang form = new FormKhoHang();
            form.Show();
            Dispose();
        }

        private void btnBCNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormBaoCaoNhanVien form = new FormBaoCaoNhanVien();
            form.Show();
            Dispose();
        }

        private void btnBCVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormBaoCaoVatTu form = new FormBaoCaoVatTu();
            form.Show();
            Dispose();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDDHkhongPN form = new FormDDHkhongPN();
            form.Show();
            Dispose();
        }

        private void btnHDNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHoatDongNhanVien form = new FormHoatDongNhanVien();
            form.Show();
            Dispose();
        }
    }
}