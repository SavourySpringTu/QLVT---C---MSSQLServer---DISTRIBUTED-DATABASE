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
    public partial class FormChonVatTu : Form
    {
        public FormChonVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            QLVT_DATHANGDataSet.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.QLVT_DATHANGDataSet.Vattu);

        }

        private void FormChonVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            QLVT_DATHANGDataSet.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.QLVT_DATHANGDataSet.Vattu);

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string maVatTu = ((DataRowView)bdsVatTu.Current)["MAVT"].ToString();
            int soLuongVatTu = int.Parse(((DataRowView)bdsVatTu.Current)["SOLUONGTON"].ToString());

            Program.maVatTuDuocChon = maVatTu;
            Program.soLuongVatTu = soLuongVatTu;

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
