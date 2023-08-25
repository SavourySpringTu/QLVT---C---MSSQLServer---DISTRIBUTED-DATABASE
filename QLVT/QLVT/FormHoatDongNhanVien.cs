using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using DevExpress.XtraReports.UI;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLVT
{
    public partial class FormHoatDongNhanVien : Form
    {
        public FormHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void FormHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            qLVT_DATHANGDataSet.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);

            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;

            this.cmbChiNhanh.Enabled = false;
            if (Program.role == "CONGTY")
            {
                this.cmbChiNhanh.Enabled = true;
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChinh form = new FormChinh();
            this.Dispose();
            form.Show();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNV.Text;
            DateTime fromDate = txtBD.DateTime;
            DateTime toDate = txtKT.DateTime;
            ReportHDNV report = new ReportHDNV(maNhanVien, fromDate, toDate);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
