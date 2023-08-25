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
    public partial class FormBaoCaoVatTu : Form
    {
        private SqlConnection connPublisher = new SqlConnection();
        private string chiNhanh = "";
        public FormBaoCaoVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.QLVT_DATHANGDataSet);

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
        private void FormBaoCaoVatTu_Load(object sender, EventArgs e)
        {
            QLVT_DATHANGDataSet.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.QLVT_DATHANGDataSet.Vattu);
            QLVT_DATHANGDataSet.EnforceConstraints = false;
            if (KetNoiDatabaseGoc() == 0)
                return;
            this.vattuTableAdapter.Fill(this.QLVT_DATHANGDataSet.Vattu);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ReportVatTu report = new ReportVatTu();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                ReportVatTu report = new ReportVatTu();
                if (File.Exists(@"D:\ReportDanhSachVatTu.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportDanhSachVatTu.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportDanhSachVatTu.pdf");
                        MessageBox.Show("File ReportDanhSachVatTu.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportDanhSachVatTu.pdf");
                    MessageBox.Show("File ReportDanhSachVatTu.pdf đã được ghi thành công tại ổ D",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportDanhSachVatTu.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChinh form = new FormChinh();
            form.Show();
            Dispose();
        }
    }
}
