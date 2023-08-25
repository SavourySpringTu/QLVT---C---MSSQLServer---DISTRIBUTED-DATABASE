
namespace QLVT
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label sOCMNDLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.cbXoa = new DevExpress.XtraEditors.CheckEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCN = new DevExpress.XtraEditors.TextEdit();
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.sOCMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtLuong = new DevExpress.XtraEditors.SpinEdit();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.bdsPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            mANVLabel = new System.Windows.Forms.Label();
            sOCMNDLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbXoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(48, 52);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(56, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV:";
            // 
            // sOCMNDLabel
            // 
            sOCMNDLabel.AutoSize = true;
            sOCMNDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOCMNDLabel.Location = new System.Drawing.Point(381, 102);
            sOCMNDLabel.Name = "sOCMNDLabel";
            sOCMNDLabel.Size = new System.Drawing.Size(56, 17);
            sOCMNDLabel.TabIndex = 2;
            sOCMNDLabel.Text = "CMND:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(34, 102);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(72, 17);
            nGAYSINHLabel.TabIndex = 4;
            nGAYSINHLabel.Text = "Ngày Sinh:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(953, 52);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(56, 17);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Mã CN:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lUONGLabel.Location = new System.Drawing.Point(61, 153);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(50, 17);
            lUONGLabel.TabIndex = 8;
            lUONGLabel.Text = "Lương:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(381, 153);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(56, 17);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "Địa Chỉ:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trangThaiXoaLabel.Location = new System.Drawing.Point(69, 229);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(35, 17);
            trangThaiXoaLabel.TabIndex = 12;
            trangThaiXoaLabel.Text = "Xóa:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(404, 52);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(29, 17);
            hOLabel.TabIndex = 14;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(610, 56);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(34, 17);
            tENLabel.TabIndex = 16;
            tENLabel.Text = "Tên:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnThoat,
            this.btnChuyenCN});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChuyenCN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 60);
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(100, 60);
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 60);
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(100, 60);
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 60);
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnChuyenCN
            // 
            this.btnChuyenCN.Caption = "Chuyển Chi Nhánh";
            this.btnChuyenCN.Id = 8;
            this.btnChuyenCN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenCN.ImageOptions.Image")));
            this.btnChuyenCN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenCN.ImageOptions.LargeImage")));
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.Size = new System.Drawing.Size(130, 60);
            this.btnChuyenCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenCN_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoat";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 60);
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1263, 81);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 707);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1263, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 81);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 626);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1263, 81);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 626);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 81);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1263, 100);
            this.panelControl1.TabIndex = 4;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(149, 36);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(212, 25);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QLVT_DATHANGDataSet
            // 
            this.QLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.QLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NhanVien";
            this.bdsNhanVien.DataSource = this.QLVT_DATHANGDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNhanVien;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.Location = new System.Drawing.Point(0, 181);
            this.gcNhanVien.MainView = this.gridView1;
            this.gcNhanVien.MenuManager = this.barManager1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1263, 280);
            this.gcNhanVien.TabIndex = 6;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colSOCMND,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.gcNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(tENLabel);
            this.panelNhapLieu.Controls.Add(this.txtTen);
            this.panelNhapLieu.Controls.Add(hOLabel);
            this.panelNhapLieu.Controls.Add(this.txtHo);
            this.panelNhapLieu.Controls.Add(trangThaiXoaLabel);
            this.panelNhapLieu.Controls.Add(this.cbXoa);
            this.panelNhapLieu.Controls.Add(dIACHILabel);
            this.panelNhapLieu.Controls.Add(this.txtDiaChi);
            this.panelNhapLieu.Controls.Add(lUONGLabel);
            this.panelNhapLieu.Controls.Add(mACNLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaCN);
            this.panelNhapLieu.Controls.Add(nGAYSINHLabel);
            this.panelNhapLieu.Controls.Add(this.txtNgaySinh);
            this.panelNhapLieu.Controls.Add(sOCMNDLabel);
            this.panelNhapLieu.Controls.Add(this.sOCMNDTextEdit);
            this.panelNhapLieu.Controls.Add(mANVLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaNV);
            this.panelNhapLieu.Controls.Add(this.txtLuong);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 461);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1263, 405);
            this.panelNhapLieu.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(650, 49);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(100, 24);
            this.txtTen.TabIndex = 17;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(454, 49);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(100, 24);
            this.txtHo.TabIndex = 15;
            // 
            // cbXoa
            // 
            this.cbXoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "TrangThaiXoa", true));
            this.cbXoa.Location = new System.Drawing.Point(112, 227);
            this.cbXoa.MenuManager = this.barManager1;
            this.cbXoa.Name = "cbXoa";
            this.cbXoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXoa.Properties.Appearance.Options.UseFont = true;
            this.cbXoa.Properties.Caption = "checkEdit1";
            this.cbXoa.Size = new System.Drawing.Size(131, 21);
            this.cbXoa.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(454, 150);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(435, 24);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtMaCN
            // 
            this.txtMaCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "MACN", true));
            this.txtMaCN.Location = new System.Drawing.Point(1015, 49);
            this.txtMaCN.MenuManager = this.barManager1;
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCN.Properties.Appearance.Options.UseFont = true;
            this.txtMaCN.Size = new System.Drawing.Size(100, 24);
            this.txtMaCN.TabIndex = 7;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "NGAYSINH", true));
            this.txtNgaySinh.EditValue = null;
            this.txtNgaySinh.Location = new System.Drawing.Point(112, 99);
            this.txtNgaySinh.MenuManager = this.barManager1;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Size = new System.Drawing.Size(149, 24);
            this.txtNgaySinh.TabIndex = 5;
            // 
            // sOCMNDTextEdit
            // 
            this.sOCMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "SOCMND", true));
            this.sOCMNDTextEdit.Location = new System.Drawing.Point(454, 99);
            this.sOCMNDTextEdit.MenuManager = this.barManager1;
            this.sOCMNDTextEdit.Name = "sOCMNDTextEdit";
            this.sOCMNDTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOCMNDTextEdit.Properties.Appearance.Options.UseFont = true;
            this.sOCMNDTextEdit.Size = new System.Drawing.Size(226, 24);
            this.sOCMNDTextEdit.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(112, 49);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(149, 24);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtLuong
            // 
            this.txtLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "LUONG", true));
            this.txtLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtLuong.Location = new System.Drawing.Point(112, 150);
            this.txtLuong.MenuManager = this.barManager1;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Properties.Appearance.Options.UseFont = true;
            this.txtLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLuong.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtLuong.Size = new System.Drawing.Size(149, 24);
            this.txtLuong.TabIndex = 9;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.OptionsColumn.ReadOnly = true;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.OptionsColumn.ReadOnly = true;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colSOCMND
            // 
            this.colSOCMND.FieldName = "SOCMND";
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.OptionsColumn.AllowEdit = false;
            this.colSOCMND.OptionsColumn.ReadOnly = true;
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.OptionsColumn.ReadOnly = true;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.OptionsColumn.AllowEdit = false;
            this.colLUONG.OptionsColumn.ReadOnly = true;
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 6;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.OptionsColumn.ReadOnly = true;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.OptionsColumn.AllowEdit = false;
            this.colTrangThaiXoa.OptionsColumn.ReadOnly = true;
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 8;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 727);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbXoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private QLVT_DATHANGDataSet QLVT_DATHANGDataSet;
        private QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelNhapLieu;
        private DevExpress.XtraEditors.CheckEdit cbXoa;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtMaCN;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
        private DevExpress.XtraEditors.TextEdit sOCMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.SpinEdit txtLuong;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhieuXuat;
        private QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
    }
}