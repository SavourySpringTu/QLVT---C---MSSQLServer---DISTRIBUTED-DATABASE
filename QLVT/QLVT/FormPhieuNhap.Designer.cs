namespace QLVT
{
    partial class FormPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuNhap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.QLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.ctpnTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.menuCTPN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuBtnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnGhi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtMaDDH = new System.Windows.Forms.ComboBox();
            this.dATHANGKHONGPHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tENKHOComboBox = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.SpinEdit();
            this.dateNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.gcChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENVT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            this.dATHANGKHONGPHIEUNHAPTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DATHANGKHONGPHIEUNHAPTableAdapter();
            this.vattuTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            this.menuCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dATHANGKHONGPHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPNLabel.Location = new System.Drawing.Point(60, 53);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(52, 17);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "Mã PN";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(63, 174);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(60, 114);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(65, 17);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Mã DDH";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(373, 53);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(54, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã NV";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOLabel.Location = new System.Drawing.Point(370, 114);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(57, 17);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã Kho";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHOLabel.Location = new System.Drawing.Point(363, 177);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(64, 18);
            tENKHOLabel.TabIndex = 10;
            tENKHOLabel.Text = "Tên Kho";
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
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            this.btnGhi.Id = 1;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(100, 60);
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 60);
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Hoàn tác";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 60);
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1378, 81);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 723);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1378, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 81);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 642);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1378, 81);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 642);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 81);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1378, 94);
            this.panelControl1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(281, 35);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(212, 25);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // QLVT_DATHANGDataSet
            // 
            this.QLVT_DATHANGDataSet.DataSetName = "DS";
            this.QLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PhieuNhap";
            this.bdsPhieuNhap.DataSource = this.QLVT_DATHANGDataSet;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.ctpnTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // ctpnTableAdapter
            // 
            this.ctpnTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.AllowNew = true;
            this.bdsCTPN.DataMember = "FK_PhieuNhap_CTPN";
            this.bdsCTPN.DataSource = this.bdsPhieuNhap;
            // 
            // menuCTPN
            // 
            this.menuCTPN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuCTPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnThem,
            this.menuBtnGhi,
            this.menuBtnXoa});
            this.menuCTPN.Name = "menuCTPN";
            this.menuCTPN.Size = new System.Drawing.Size(105, 70);
            // 
            // menuBtnThem
            // 
            this.menuBtnThem.Name = "menuBtnThem";
            this.menuBtnThem.Size = new System.Drawing.Size(104, 22);
            this.menuBtnThem.Text = "Thêm";
            this.menuBtnThem.Click += new System.EventHandler(this.menuBtnThem_Click);
            // 
            // menuBtnGhi
            // 
            this.menuBtnGhi.Name = "menuBtnGhi";
            this.menuBtnGhi.Size = new System.Drawing.Size(104, 22);
            this.menuBtnGhi.Text = "Ghi";
            this.menuBtnGhi.Click += new System.EventHandler(this.menuBtnGhi_Click_1);
            // 
            // menuBtnXoa
            // 
            this.menuBtnXoa.Name = "menuBtnXoa";
            this.menuBtnXoa.Size = new System.Drawing.Size(104, 22);
            this.menuBtnXoa.Text = "Xoá";
            this.menuBtnXoa.Click += new System.EventHandler(this.menuBtnXoa_Click);
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.DataSource = this.bdsPhieuNhap;
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuNhap.Location = new System.Drawing.Point(0, 175);
            this.gcPhieuNhap.MainView = this.gridView1;
            this.gcPhieuNhap.MenuManager = this.barManager1;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(1378, 252);
            this.gcPhieuNhap.TabIndex = 15;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPhieuNhap;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.txtMaDDH);
            this.panelNhapLieu.Controls.Add(tENKHOLabel);
            this.panelNhapLieu.Controls.Add(this.tENKHOComboBox);
            this.panelNhapLieu.Controls.Add(mAKHOLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaKho);
            this.panelNhapLieu.Controls.Add(mANVLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaNV);
            this.panelNhapLieu.Controls.Add(masoDDHLabel);
            this.panelNhapLieu.Controls.Add(nGAYLabel);
            this.panelNhapLieu.Controls.Add(this.dateNgay);
            this.panelNhapLieu.Controls.Add(mAPNLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaPN);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 427);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(927, 296);
            this.panelNhapLieu.TabIndex = 16;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MasoDDH", true));
            this.txtMaDDH.DataSource = this.dATHANGKHONGPHIEUNHAPBindingSource;
            this.txtMaDDH.DisplayMember = "MasoDDH";
            this.txtMaDDH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDDH.FormattingEnabled = true;
            this.txtMaDDH.Location = new System.Drawing.Point(148, 113);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(140, 25);
            this.txtMaDDH.TabIndex = 12;
            // 
            // dATHANGKHONGPHIEUNHAPBindingSource
            // 
            this.dATHANGKHONGPHIEUNHAPBindingSource.DataMember = "DATHANGKHONGPHIEUNHAP";
            this.dATHANGKHONGPHIEUNHAPBindingSource.DataSource = this.QLVT_DATHANGDataSet;
            // 
            // tENKHOComboBox
            // 
            this.tENKHOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoBindingSource, "TENKHO", true));
            this.tENKHOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.QLVT_DATHANGDataSet, "PhieuNhap.MAKHO", true));
            this.tENKHOComboBox.DataSource = this.khoBindingSource;
            this.tENKHOComboBox.DisplayMember = "TENKHO";
            this.tENKHOComboBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENKHOComboBox.FormattingEnabled = true;
            this.tENKHOComboBox.Location = new System.Drawing.Point(470, 169);
            this.tENKHOComboBox.Name = "tENKHOComboBox";
            this.tENKHOComboBox.Size = new System.Drawing.Size(159, 26);
            this.tENKHOComboBox.TabIndex = 11;
            this.tENKHOComboBox.ValueMember = "MAKHO";
            this.tENKHOComboBox.SelectedIndexChanged += new System.EventHandler(this.tENKHOComboBox_SelectedIndexChanged);
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.QLVT_DATHANGDataSet;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuNhap, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(470, 111);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKho.Properties.Appearance.Options.UseFont = true;
            this.txtMaKho.Size = new System.Drawing.Size(159, 24);
            this.txtMaKho.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuNhap, "MANV", true));
            this.txtMaNV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaNV.Location = new System.Drawing.Point(470, 50);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaNV.Size = new System.Drawing.Size(159, 24);
            this.txtMaNV.TabIndex = 7;
            // 
            // dateNgay
            // 
            this.dateNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuNhap, "NGAY", true));
            this.dateNgay.EditValue = null;
            this.dateNgay.Location = new System.Drawing.Point(148, 171);
            this.dateNgay.MenuManager = this.barManager1;
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgay.Properties.Appearance.Options.UseFont = true;
            this.dateNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Size = new System.Drawing.Size(140, 24);
            this.dateNgay.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuNhap, "MAPN", true));
            this.txtMaPN.Location = new System.Drawing.Point(148, 50);
            this.txtMaPN.MenuManager = this.barManager1;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Properties.Appearance.Options.UseFont = true;
            this.txtMaPN.Size = new System.Drawing.Size(140, 24);
            this.txtMaPN.TabIndex = 1;
            // 
            // gcChiTietPhieuNhap
            // 
            this.gcChiTietPhieuNhap.AllowUserToAddRows = false;
            this.gcChiTietPhieuNhap.AutoGenerateColumns = false;
            this.gcChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TENVT,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gcChiTietPhieuNhap.ContextMenuStrip = this.menuCTPN;
            this.gcChiTietPhieuNhap.DataSource = this.bdsCTPN;
            this.gcChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietPhieuNhap.Location = new System.Drawing.Point(927, 427);
            this.gcChiTietPhieuNhap.Name = "gcChiTietPhieuNhap";
            this.gcChiTietPhieuNhap.Size = new System.Drawing.Size(451, 296);
            this.gcChiTietPhieuNhap.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPN";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // TENVT
            // 
            this.TENVT.DataPropertyName = "MAVT";
            this.TENVT.DataSource = this.vattuBindingSource;
            this.TENVT.DisplayMember = "TENVT";
            this.TENVT.HeaderText = "Tên VT";
            this.TENVT.Name = "TENVT";
            this.TENVT.ValueMember = "MAVT";
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.QLVT_DATHANGDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // dATHANGKHONGPHIEUNHAPTableAdapter
            // 
            this.dATHANGKHONGPHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 743);
            this.Controls.Add(this.gcChiTietPhieuNhap);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcPhieuNhap);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            this.menuCTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dATHANGKHONGPHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private QLVT_DATHANGDataSet QLVT_DATHANGDataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter ctpnTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private System.Windows.Forms.ContextMenuStrip menuCTPN;
        private System.Windows.Forms.ToolStripMenuItem menuBtnThem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnGhi;
        private System.Windows.Forms.ToolStripMenuItem menuBtnXoa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.DataGridView gcChiTietPhieuNhap;
        private DevExpress.XtraEditors.PanelControl panelNhapLieu;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.SpinEdit txtMaNV;
        private DevExpress.XtraEditors.DateEdit dateNgay;
        private DevExpress.XtraEditors.TextEdit txtMaPN;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.ComboBox tENKHOComboBox;
        private System.Windows.Forms.ComboBox txtMaDDH;
        private System.Windows.Forms.BindingSource dATHANGKHONGPHIEUNHAPBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.DATHANGKHONGPHIEUNHAPTableAdapter dATHANGKHONGPHIEUNHAPTableAdapter;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn TENVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}