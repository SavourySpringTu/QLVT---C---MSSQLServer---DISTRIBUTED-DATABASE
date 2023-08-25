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
using System.Data.SqlClient;

namespace QLVT
{
    public partial class FormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        bool themmoiChiTiet = false;
        int viTriCT =0 ;
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

        private void FormPhieuNhap_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            
            if (Program.role == "CONGTY")
            {
                this.panelNhapLieu.Enabled = false;
                this.gcPhieuNhap.Enabled = false;
                this.gcChiTietPhieuNhap.Enabled = false;
                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;
                this.btnPhucHoi.Enabled = false;
                this.btnRefresh.Enabled = true;
            }
            else
            {
                this.cmbChiNhanh.Enabled = false;
            }

            this.txtMaKho.Enabled = false;
            this.txtMaNV.Enabled = false;
            QLVT_DATHANGDataSet.EnforceConstraints = false;
            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.QLVT_DATHANGDataSet.Vattu);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            try
            { 
                this.phieuNhapTableAdapter.Fill(this.QLVT_DATHANGDataSet.PhieuNhap); 
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex); 
            }
            this.dATHANGKHONGPHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dATHANGKHONGPHIEUNHAPTableAdapter.Fill(this.QLVT_DATHANGDataSet.DATHANGKHONGPHIEUNHAP);
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.QLVT_DATHANGDataSet.Kho);
            this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpnTableAdapter.Fill(this.QLVT_DATHANGDataSet.CTPN);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhieuNhap.AddNew();
            this.dateNgay.EditValue = DateTime.Now;
            this.txtMaNV.Text = Program.userName;
            ((DataRowView)(bdsPhieuNhap.Current))["NGAY"] = DateTime.Now;
            ((DataRowView)(bdsPhieuNhap.Current))["MANV"] = Program.userName;
            ((DataRowView)(bdsPhieuNhap.Current))["MAKHO"] = this.txtMaKho.Text;

            panelNhapLieu.Enabled = true;
            this.gcPhieuNhap.Enabled = false;
            this.gcChiTietPhieuNhap.Enabled = false;
            this.dateNgay.Enabled = false;
            this.txtMaNV.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = true;
            this.btnPhucHoi.Enabled = true;
            this.btnRefresh.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao("Phiếu Nhập");
            if (ketQua == false) return;
            String maPhieuNhap = txtMaPN.Text.Trim();
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaPhieuNhap '" +
                    maPhieuNhap + "' " +
                    "SELECT 'Value' = @result";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
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


            int viTriConTro = bdsPhieuNhap.Position;
            int viTriMaPhieuNhap = bdsPhieuNhap.Find("MAPN", maPhieuNhap);
            if (result == 1 && viTriMaPhieuNhap != viTriConTro)
            {
                MessageBox.Show("Mã phiếu nhập đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtMaPN.Focus();
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
                        //Console.WriteLine(txtMaNhanVien.Text);
                        /*TH1: them moi phieu nhap*/
                        this.bdsPhieuNhap.EndEdit();
                        this.phieuNhapTableAdapter.Update(this.QLVT_DATHANGDataSet.PhieuNhap);
                        this.btnThem.Enabled = true;
                        this.btnXoa.Enabled = true;
                        this.btnGhi.Enabled = true;
                        this.gcChiTietPhieuNhap.Enabled = true;
                        this.gcPhieuNhap.Enabled = true;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bdsPhieuNhap.RemoveCurrent();
                        MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

        }
        private bool kiemTraDuLieuDauVao(String cheDo)
        {
            if (cheDo == "Phiếu Nhập")
            {
                if (txtMaPN.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPN.Focus();
                    return false;
                }

                if (txtMaKho.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtMaDDH.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Không bỏ trống mã đơn đặt hàng !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            if (cheDo == "Chi Tiết Phiếu Nhập")
            {
            }
            return true;
        }

        private void menuBtnThem_Click(object sender, EventArgs e)
        {
            bdsCTPN.AddNew();
            menuBtnThem.Enabled = false;
            menuBtnXoa.Enabled = false;
            themmoiChiTiet = true;
            viTriCT = bdsCTPN.Position;
        }

        private void gcCTPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in gcChiTietPhieuNhap.Rows)
            {
                row.ReadOnly = true;
            }
            if (themmoiChiTiet == true)
            {
                gcChiTietPhieuNhap.Rows[viTriCT].ReadOnly = false;
            }
        }

        private void capNhatSoLuongVatTu(string maVatTu, string soLuong)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu 'IMPORT','" + maVatTu + "', " + soLuong;
            int n = Program.ExecSqlNonQuery(cauTruyVan);
        }

        private void menuBtnGhi_Click_1(object sender, EventArgs e)
        {
            viTriCT = bdsCTPN.Position;
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    String sl = (((DataRowView)(bdsCTPN.Current))["SOLUONG"]).ToString();
                    String mvt = (((DataRowView)(bdsCTPN.Current))["MAVT"]).ToString();
                    capNhatSoLuongVatTu(mvt, sl);
                    this.bdsCTPN.EndEdit();
                    this.ctpnTableAdapter.Update(this.QLVT_DATHANGDataSet.CTPN);
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    bdsCTPN.RemoveCurrent();
                    MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            menuBtnThem.Enabled = true;
            menuBtnXoa.Enabled = true;
            themmoiChiTiet = false;
        }
        private void menuBtnXoa_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
            String maNhanVien = drv["MANV"].ToString();
            if (Program.userName != maNhanVien)
            {
                MessageBox.Show("Bạn không xóa chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            String cauTruyVan =
                "DECLARE	@result int " +
                "EXEC @result = sp_CheckXoaCTPN '" +
                txtMaPN.Text.Trim() + "', '" + (((DataRowView)(bdsCTPN.Current))["MAVT"]).ToString().Trim() + "'" +
                "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
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
            if (result == 0)
            {
                MessageBox.Show("Số lượng vật tư không đủ để xóa!\n\n", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu 'EXPORT','" + (((DataRowView)(bdsCTPN.Current))["MAVT"]).ToString().Trim() + "', " + (((DataRowView)(bdsCTPN.Current))["SOLUONG"]).ToString().Trim();
                    Console.WriteLine(cauTruyVan);
                    int n = Program.ExecSqlNonQuery(cauTruyVan);
                    bdsCTPN.RemoveCurrent();
                    this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctpnTableAdapter.Update(this.QLVT_DATHANGDataSet.CTPN);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctpnTableAdapter.Update(this.QLVT_DATHANGDataSet.CTPN);
                    return;
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
            String maNhanVien = drv["MANV"].ToString();
            if (Program.userName != maNhanVien)
            {
                MessageBox.Show("Không xóa chi tiết phiếu xuất không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu nhập vì có chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTriCT = bdsPhieuNhap.Position;
                    bdsPhieuNhap.RemoveCurrent();
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.QLVT_DATHANGDataSet.PhieuNhap);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnPhucHoi.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.QLVT_DATHANGDataSet.PhieuNhap);

                    this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctpnTableAdapter.Update(this.QLVT_DATHANGDataSet.CTPN);
                    bdsPhieuNhap.Position = viTriCT;
                    return;
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.phieuNhapTableAdapter.Fill(this.QLVT_DATHANGDataSet.PhieuNhap);
            this.ctpnTableAdapter.Fill(this.QLVT_DATHANGDataSet.CTPN);
        }

        private void tENKHOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.QLVT_DATHANGDataSet.Kho);
                this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctpnTableAdapter.Fill(this.QLVT_DATHANGDataSet.CTPN);
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.QLVT_DATHANGDataSet.PhieuNhap);
            }
        }
    }
}