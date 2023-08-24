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
    public partial class FormChonKhoHang : Form
    {
        public FormChonKhoHang()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.QLVT_DATHANGDataSet);

        }

        private void FormChonKhoHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            QLVT_DATHANGDataSet.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.QLVT_DATHANGDataSet.Kho);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string maKhoHang = ((DataRowView)bdsKhoHang.Current)["MAKHO"].ToString();
            Program.maKhoDuocChon = maKhoHang;
            this.Close();
        }
    }
}
