using DevExpress.XtraEditors;
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
    public partial class FormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.QLVT_DATHANGDataSet);

        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            QLVT_DATHANGDataSet.EnforceConstraints = false;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            try
            { this.phieuNhapTableAdapter.Fill(this.QLVT_DATHANGDataSet.PhieuNhap); }
            catch (Exception ex) { Console.WriteLine(ex); }
            this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpnTableAdapter.Fill(this.QLVT_DATHANGDataSet.CTPN);

        }

        private void mAPNLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnChonKhoHang_Click(object sender, EventArgs e)
        {
            FormChonKhoHang form = new FormChonKhoHang();
            form.ShowDialog();
            //this.mAKHOTextEdit.Text = Program.maKhoDuocChon;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChinh form = new FormChinh();
            form.Show();
            Dispose();
        }
    }
}