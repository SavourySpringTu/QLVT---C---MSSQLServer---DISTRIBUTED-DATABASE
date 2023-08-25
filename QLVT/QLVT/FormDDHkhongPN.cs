using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDDHkhongPN : Form
    {
        public FormDDHkhongPN()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ReportDDHkPN report = new ReportDDHkPN();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDDHkPN report = new ReportDDHkPN();
            if (File.Exists(@"D:\ReportDDHkPN.pdf"))
            {
                DialogResult dr = MessageBox.Show("File ReportDDHkPN.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    report.ExportToPdf(@"D:\ReportDDHkPN.pdf");
                    MessageBox.Show("File ReportDDHkPN.pdf đã được ghi thành công tại ổ D",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                report.ExportToPdf(@"D:\ReportDDHkPN.pdf");
                MessageBox.Show("File ReportDDHkPN.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormDDHkhongPN_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
            if (Program.role == "CONGTY")
            {
                this.cmbChiNhanh.Enabled = true;
            }
            else
            {
                this.cmbChiNhanh.Enabled = false;
            }
            
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChinh form = new FormChinh();
            form.Show();
            this.Dispose();
        }
    }
}
