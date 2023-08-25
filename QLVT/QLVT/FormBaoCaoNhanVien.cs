using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLVT
{
    public partial class FormBaoCaoNhanVien : Form
    {
        private SqlConnection connPublisher = new SqlConnection();
        private string chiNhanh = "";
        public FormBaoCaoNhanVien()
        {
            InitializeComponent();
        }
        private void layDanhSachPhanManh(String cmd)
        {
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            da.Fill(dt);

            connPublisher.Close();
            Program.bindingSource.DataSource = dt;
            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";

        }
        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.QLVT_DATHANGDataSet);

        }

        private void FormBaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            QLVT_DATHANGDataSet.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.QLVT_DATHANGDataSet.NhanVien);

            QLVT_DATHANGDataSet.EnforceConstraints = false;
            chiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
            this.cmbChiNhanh.Enabled = false;
            if (Program.role == "CONGTY")
            {
                this.cmbChiNhanh.Enabled = true;
            }
            
            this.nhanVienTableAdapter.Fill(this.QLVT_DATHANGDataSet.NhanVien);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ReportNhanVien report = new ReportNhanVien();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                ReportNhanVien report = new ReportNhanVien();
                if (File.Exists(@"D:\ReportDanhSachNhanVien.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportDSNhanVien.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportDSNhanVien.pdf");
                        MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportDanhSachNhanVien.pdf");
                    MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportDSNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChinh form = new FormChinh();
            form.Show();
            this.Dispose();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
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
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.QLVT_DATHANGDataSet.NhanVien);
                chiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString().Trim();
            }
        }
    }
}
