using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
namespace QLVT
{
    public partial class FormDonDatHang : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;


        bool dangThemMoi = false;
        public string makho = "";
        string maChiNhanh = "";


        BindingSource bds = null;
        GridControl gc = null;
        string type = "";
        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            if (Program.role == "CONGTY")
            {
                this.gcDH.Enabled = false;
                this.gcCTDDH.Enabled = false;
                this.panelNhapLieu.Enabled = false;
                this.btnThem.Enabled = false;
                this.btnGhi.Enabled = false;
                this.btnRefresh.Enabled = false;
                this.btnPhucHoi.Enabled = false;
                this.btnXoa.Enabled = false;
            }
            else
            {
                this.cmbCHINHANH.Enabled = false;
            }
            this.txtMaNV.Enabled = false;
            this.mAKHOTextEdit.Enabled = false;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            try
            {
                this.datHangTableAdapter.Fill(this.dS.DatHang);
            }
            catch (Exception) { }
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            cmbCHINHANH.DataSource = Program.bindingSource;
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            bds = bdsDH;
            gc = gcDH;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bds.Position;
            dangThemMoi = true;
            bds.AddNew();
            this.dateNgay.Enabled = false;
            this.dateNgay.EditValue = DateTime.Now;
            this.txtMaNV.Text = Program.userName;
            ((DataRowView)(bdsDH.Current))["MANV"] = Program.userName;
            ((DataRowView)(bdsDH.Current))["NGAY"] = DateTime.Now;
            Console.WriteLine(viTri);
            this.btnThem.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnRefresh.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDH.Position;
            DataRowView drv = ((DataRowView)bdsDH[bdsDH.Position]);

            String maDonDatHangMoi = txtMaDDH.Text;
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaDonDatHang '" +
                    maDonDatHangMoi + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();


            int viTriHienTai = bds.Position;
            int viTriMaDonDatHang = bdsDH.Find("MasoDDH", txtMaDDH.Text);
            if (result == 1 && viTriHienTai != viTriMaDonDatHang)
            {
                MessageBox.Show("Mã đơn hàng này đã được sử dụng !\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        this.bdsDH.EndEdit();
                        this.datHangTableAdapter.Update(this.dS.DatHang);
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bds.RemoveCurrent();
                        MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            this.btnThem.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnRefresh.Enabled = true;
            this.btnXoa.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.datHangTableAdapter.Fill(this.dS.DatHang);
                this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
                this.gcDH.Enabled = true;
                this.gcCTDDH.Enabled = true;
                bdsDH.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void menuGhi_Click(object sender, EventArgs e)
        {
            viTri = bdsCTDDH.Position;
            Console.WriteLine(viTri);
            Console.WriteLine(((DataRowView)(bdsCTDDH.Current))["MAVT"]);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    this.bdsCTDDH.EndEdit();
                    this.cTDDHTableAdapter.Update(this.dS.CTDDH);
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    bds.RemoveCurrent();
                    MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void menuThem_Click(object sender, EventArgs e)
        {
            bdsCTDDH.AddNew();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChinh form = new FormChinh();
            form.Show();
            this.Dispose();
        }

        private void btnChonKho_Click(object sender, EventArgs e)
        {
            FormChonKhoHang form = new FormChonKhoHang();
            form.ShowDialog();
            this.mAKHOTextEdit.Text = Program.maKhoDuocChon;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}