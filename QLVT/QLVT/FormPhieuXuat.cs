using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.Collections;
using System.Data.SqlClient;

namespace QLVT
{
    public partial class FormPhieuXuat : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        public string makho = "";
        string maChiNhanh = "";
        Stack undoList = new Stack();
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";
        bool cd = true;
        public FormPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuXuat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.QLVT_DATHANGDataSet);

        }
        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            QLVT_DATHANGDataSet.EnforceConstraints = false;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.QLVT_DATHANGDataSet.PhieuXuat);
            this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietPhieuXuatTableAdapter.Fill(this.QLVT_DATHANGDataSet.CTPX);

            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;

                this.btnPhucHoi.Enabled = false;
                this.btnRefresh.Enabled = false;
                this.btnCDCTPhieuXuat.Enabled = false;
                this.btnCDPhieuXuat.Enabled = false;
                this.btnThoat.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }
            else
            {
                bds = bdsPhieuXuat;
                this.txtMaVatTuChiTietPhieuXuat.Enabled = false;
                this.txtSoLuongChiTietPhieuXuat.Enabled = false;
                this.txtDonGiaChiTietPhieuXuat.Enabled = false;
                this.txtMaNV.Enabled = false;
                this.btnChonVatTu.Enabled = false;

                this.btnCDCTPhieuXuat.Enabled = true;
                this.btnCDPhieuXuat.Enabled = false;
                this.panelChiNhanh.Enabled = false;
                this.gcChiTietPhieuXuat.Enabled = false;
                this.panelNhapLieu.Enabled = true;
            }

        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChinh form = new FormChinh();
            form.Show();
            Dispose();
        }

        private void cmbChiNhanh_SelectedIndexChanged_1(object sender, EventArgs e)
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
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.QLVT_DATHANGDataSet.PhieuXuat);

                this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietPhieuXuatTableAdapter.Fill(this.QLVT_DATHANGDataSet.CTPX);
            }
        }

        private void btnCDPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bds = bdsPhieuXuat;
            gc = gcPhieuXuat;
            cd = true;

            this.panelNhapLieu.Enabled = true;
            this.txtMaPhieuXuat.Enabled = true;
            this.dteNgay.Enabled = true;
            this.txtTenKhachHang.Enabled = true;
            this.btnChonKhoHang.Enabled = true;
            this.txtMaKho.Enabled = true;

            this.txtMaVatTuChiTietPhieuXuat.Enabled = false;
            this.btnChonVatTu.Enabled = false;
            this.txtSoLuongChiTietPhieuXuat.Enabled = false;
            this.txtDonGiaChiTietPhieuXuat.Enabled = false;
            this.btnCDPhieuXuat.Enabled = false;
            this.btnCDCTPhieuXuat.Enabled = true;

            this.gcPhieuXuat.Enabled = true;
            this.gcChiTietPhieuXuat.Enabled = false;
        }

        private void btnCDCTPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
            String maNhanVien = drv["MANV"].ToString();
            if (Program.userName != maNhanVien)
            {
                MessageBox.Show("Không thể thêm chỉnh sửa tiết phiếu xuất không phải mình tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            bds = bdsChiTietPhieuXuat;
            cd = false;

            this.panelNhapLieu.Enabled = true;
            this.btnGhi.Enabled = false;
            this.txtMaPhieuXuat.Enabled = false;
            this.dteNgay.Enabled = false;
            this.txtTenKhachHang.Enabled = false;
            this.btnChonKhoHang.Enabled = false;
            this.btnChonKhoHang.Enabled = false;
            this.txtMaKho.Enabled = false;
            this.btnCDCTPhieuXuat.Enabled = false;
            this.btnCDPhieuXuat.Enabled = true;
            this.txtMaVatTuChiTietPhieuXuat.Enabled = false;
            this.txtSoLuongChiTietPhieuXuat.Enabled = false;
            this.txtDonGiaChiTietPhieuXuat.Enabled = false;
            this.btnChonVatTu.Enabled = false;
            this.btnXoa.Enabled = false;
            this.gcPhieuXuat.Enabled = false;
            this.gcChiTietPhieuXuat.Enabled = true;
        }
        private void btnChonKhoHang_Click(object sender, EventArgs e)
        {
            FormChonKhoHang form = new FormChonKhoHang();
            form.ShowDialog();
            this.txtMaKho.Text = Program.maKhoDuocChon;
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {
            FormChonVatTu form = new FormChonVatTu();
            form.ShowDialog();
            this.txtMaVatTuChiTietPhieuXuat.Text = Program.maVatTuDuocChon;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            bds.AddNew();
            viTri = bds.Position;

            if (cd==true)
            {
                this.txtMaPhieuXuat.Enabled = true;
                this.dteNgay.EditValue = DateTime.Now;
                this.dteNgay.Enabled = false;
                this.txtTenKhachHang.Enabled = true;
                this.txtMaNV.Text = Program.userName;
                this.btnChonKhoHang.Enabled = true;
                this.txtMaKho.Text = Program.maKhoDuocChon;

                this.txtMaVatTuChiTietPhieuXuat.Enabled = false;
                this.btnChonVatTu.Enabled = false;
                this.txtSoLuongChiTietPhieuXuat.Enabled = false;
                this.txtDonGiaChiTietPhieuXuat.Enabled = false;

                ((DataRowView)(bdsPhieuXuat.Current))["NGAY"] = DateTime.Now;
                ((DataRowView)(bdsPhieuXuat.Current))["MANV"] = Program.userName;
                ((DataRowView)(bdsPhieuXuat.Current))["MAKHO"] =
                Program.maKhoDuocChon;

            }

            if (cd == false)
            {
               ((DataRowView)(bdsChiTietPhieuXuat.Current))["MAPX"] = ((DataRowView)(bdsPhieuXuat.Current))["MAPX"];
                ((DataRowView)(bdsChiTietPhieuXuat.Current))["MAVT"] =
                    Program.maVatTuDuocChon;
                this.txtMaVatTuChiTietPhieuXuat.Enabled = false;
                this.btnChonVatTu.Enabled = true;

                this.txtSoLuongChiTietPhieuXuat.Enabled = true;
                this.txtSoLuongChiTietPhieuXuat.EditValue = 1;

                this.txtDonGiaChiTietPhieuXuat.Enabled = true;
                this.txtDonGiaChiTietPhieuXuat.EditValue = 1;
            }
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = true;

            this.btnPhucHoi.Enabled = true;
            this.btnRefresh.Enabled = false;
            this.btnCDCTPhieuXuat.Enabled = false;
            this.btnCDPhieuXuat.Enabled = false;
            this.btnThoat.Enabled = false;

            gcPhieuXuat.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TimSoLuongTonVatTu() == false)
            {
                MessageBox.Show("Không có vật tư", "Thông báo", MessageBoxButtons.OK);
            }
            bool ketQua = kiemTraDuLieuDauVao(cd);
            if (ketQua == false) return;

            string cauTruyVanHoanTac = taoCauTruyVanHoanTac(cd);
            String maPhieuXuat = txtMaPhieuXuat.Text.Trim();
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaPhieuXuat '" +
                    maPhieuXuat + "' " +
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

            int viTriConTro = bdsPhieuXuat.Position;
            int viTriMaPhieuXuat = bdsPhieuXuat.Find("MAPX", maPhieuXuat);

            if (result == 1 && cd == true && viTriMaPhieuXuat != viTriConTro)
            {
                MessageBox.Show("Mã phiếu xuất đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtMaPhieuXuat.Focus();
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
                        if (cd == true && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.PHIEUXUAT " +
                                "WHERE MAPX = '" + maPhieuXuat + "'";
                                this.gcPhieuXuat.Enabled = true;
                                this.btnCDCTPhieuXuat.Enabled = true;
                            this.btnXoa.Enabled = true;
                        }

                        if (cd == false)
                        {
                            /*etPhieuXuat.Position;
                            int viTriMaVT = bdsChiTietPhieuXuat.Find("MAVT", maVT);
                            if(viTriMaVT!= viTriConTro1)
                            {
                                MessageBox.Show("Mã vật tư đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                                txtMaVatTuChiTietPhieuXuat.Focus();
                                return;
                            }*/
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.CTPN " +
                                "WHERE MAPN = '" + maPhieuXuat + "' " +
                                "AND MAVT = '" + Program.maVatTuDuocChon + "'";

                            string maVatTu = txtMaVatTuChiTietPhieuXuat.Text.Trim();
                            string soLuong = txtSoLuongChiTietPhieuXuat.Text.Trim();

                            capNhatSoLuongVatTu(maVatTu, soLuong);
                            this.gcChiTietPhieuXuat.Enabled = true;
                            this.btnCDPhieuXuat.Enabled = true;
                        }
                        undoList.Push(cauTruyVanHoanTac);

                        this.bdsPhieuXuat.EndEdit();
                        this.bdsChiTietPhieuXuat.EndEdit();
                        this.phieuXuatTableAdapter.Update(this.QLVT_DATHANGDataSet.PhieuXuat);
                        this.chiTietPhieuXuatTableAdapter.Update(this.QLVT_DATHANGDataSet.CTPX);
                        this.txtMaPhieuXuat.Enabled = false;

                        this.btnThem.Enabled = true;
                        this.btnGhi.Enabled = true;

                        this.btnPhucHoi.Enabled = true;
                        this.btnRefresh.Enabled = true;
                        this.btnThoat.Enabled = true;
                        this.btnChonVatTu.Enabled = false;
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        this.btnThoat.Enabled = true;
                        Console.WriteLine(ex.Message);
                        bds.RemoveCurrent();
                        MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }

        }
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnThem.Enabled == false)
            {
                dangThemMoi = false;
                if (cd==true)
                {
                    this.btnCDCTPhieuXuat.Enabled = true;
                    this.btnCDPhieuXuat.Enabled = false;
                    this.gcPhieuXuat.Enabled = true;
                }
                if (cd==false)
                {
                    this.btnGhi.Enabled = false;
                    this.panelNhapLieu.Enabled = false;
                    this.btnCDPhieuXuat.Enabled = true;
                    this.gcChiTietPhieuXuat.Enabled = true;
                }
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnRefresh.Enabled = true;
                this.btnThoat.Enabled = true;
                bds.RemoveCurrent();
                bds.Position = viTri;
                bds.CancelEdit();
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnPhucHoi.Enabled = false;
                return;
            }
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.phieuXuatTableAdapter.Fill(this.QLVT_DATHANGDataSet.PhieuXuat);
        }
        private bool TimSoLuongTonVatTu()
        {
            string cauTruyVan = "DECLARE @result int " +
                    "EXEC @result = sp_LaySoLuongTonVatTu '" +
                    txtMaVatTuChiTietPhieuXuat.Text.Trim() + "' " +
                    "SELECT 'Value' = @result"; ;
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            Program.soLuongVatTu = result;
            return true; 
        }
        private void capNhatSoLuongVatTu(string maVatTu, string soLuong)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu 'EXPORT','" + maVatTu + "', " + soLuong;
            int n = Program.ExecSqlNonQuery(cauTruyVan);
        }
        private string taoCauTruyVanHoanTac(bool cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;
            if (cheDo == false && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsPhieuXuat.Current));
                DateTime ngay = (DateTime)drv["NGAY"];


                cauTruyVan = "UPDATE DBO.PHIEUXUAT " +
                    "SET " +
                    "NGAY = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "HOTENKH = '" + drv["HOTENKH"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MAPX = '" + drv["MAPX"].ToString().Trim() + "' ";
            }

            if (cheDo == true && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsChiTietPhieuXuat.Current));
                int soLuong = int.Parse(drv["SOLUONG"].ToString().Trim());
                float donGia = float.Parse(drv["DONGIA"].ToString().Trim());
                String maPhieuXuat = drv["MAPX"].ToString().Trim();
                String maVatTu = drv["MAVT"].ToString().Trim();

                cauTruyVan = "UPDATE DBO.CTPX " +
                    "SET " +
                    "SOLUONG = " + soLuong + " " +
                    "DOGIA = " + donGia + " " +
                    "WHERE MAPX = '" + maPhieuXuat + "' " +
                    "AND MAVT = '" + maVatTu + "' ";
            }

            return cauTruyVan;
        }
        private bool kiemTraDuLieuDauVao(bool cheDo)
        {
            if (cd == true)
            {
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Không thể sửa phiếu xuất do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtMaPhieuXuat.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPhieuXuat.Focus();
                    return false;
                }

                if (txtMaPhieuXuat.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPhieuXuat.Focus();
                    return false;
                }

                if (txtTenKhachHang.Text == "")
                {
                    MessageBox.Show("Không bỏ trống tên khách hàng !", "Thông báo", MessageBoxButtons.OK);
                    txtTenKhachHang.Focus();
                    return false;
                }

                if (txtTenKhachHang.Text.Length > 100)
                {
                    MessageBox.Show("Tên khách hàng không quá 100 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtTenKhachHang.Focus();
                    return false;
                }

                if (txtMaKho.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

            }

            if (cd == false)
            {
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Không thể thêm chi tiết phiếu xuất với phiếu xuất do người khác tạo !", "Thông báo", MessageBoxButtons.OK);
                    bdsChiTietPhieuXuat.RemoveCurrent();
                    return false;
                }

                if (txtMaPhieuXuat.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPhieuXuat.Focus();
                    return false;
                }

                if (txtMaPhieuXuat.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPhieuXuat.Focus();
                    return false;
                }

                if (txtMaVatTuChiTietPhieuXuat.Text == "")
                {
                    MessageBox.Show("Thiếu mã vật tư !", "Thông báo", MessageBoxButtons.OK);
                    txtMaVatTuChiTietPhieuXuat.Focus();
                    return false;
                }

                if (txtMaVatTuChiTietPhieuXuat.Text.Length > 4)
                {
                    MessageBox.Show("Mã vật tư không quá 4 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaVatTuChiTietPhieuXuat.Focus();
                    return false;
                }
                if (txtSoLuongChiTietPhieuXuat.Value < 0 || txtSoLuongChiTietPhieuXuat.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Số lượng vật tư không thể bé hơn 0 & lớn hơn số lượng vật tư đang có trong kho hàng !", "Thông báo", MessageBoxButtons.OK);
                    txtSoLuongChiTietPhieuXuat.Focus();
                    return false;
                }

                if (txtDonGiaChiTietPhieuXuat.Value < 0)
                {
                    MessageBox.Show("Đơn giá không thể bé hơn 0 VND !", "Thông báo", MessageBoxButtons.OK);
                    txtDonGiaChiTietPhieuXuat.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            string cauTruyVanHoanTac = "";
            drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
            String maNhanVien = drv["MANV"].ToString();
            if (Program.userName != maNhanVien)
            {
                MessageBox.Show("Không xóa chi tiết phiếu xuất không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsChiTietPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì có chi tiết phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DateTime ngay = ((DateTime)drv["NGAY"]);

            cauTruyVanHoanTac = "INSERT INTO DBO.PHIEUXUAT(MAPX, NGAY, HOTENKH, MANV, MAKHO) " +
                "VALUES( '" + drv["MAPX"].ToString().Trim() + "', '" +
                ngay.ToString("yyyy-MM-dd") + "', '" +
                drv["HOTENKH"].ToString() + "', '" +
                drv["MANV"].ToString() + "', '" +
                drv["MAKHO"].ToString() + "')";
            undoList.Push(cauTruyVanHoanTac);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bds.Position;
                    bdsPhieuXuat.RemoveCurrent();
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.QLVT_DATHANGDataSet.PhieuXuat);
                    this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietPhieuXuatTableAdapter.Update(this.QLVT_DATHANGDataSet.CTPX);
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnPhucHoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa!. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.QLVT_DATHANGDataSet.PhieuXuat);

                    this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietPhieuXuatTableAdapter.Update(this.QLVT_DATHANGDataSet.CTPX);
                    bds.Position = viTri;
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuXuatTableAdapter.Fill(this.QLVT_DATHANGDataSet.PhieuXuat);
                this.chiTietPhieuXuatTableAdapter.Fill(this.QLVT_DATHANGDataSet.CTPX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi lam moi \n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
