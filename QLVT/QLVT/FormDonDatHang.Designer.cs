namespace QLVT
{
    partial class FormDonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonDatHang));
            this.masoDDHLabel = new System.Windows.Forms.Label();
            this.nGAYLabel = new System.Windows.Forms.Label();
            this.nhaCCLabel = new System.Windows.Forms.Label();
            this.mANVLabel = new System.Windows.Forms.Label();
            this.mAKHOLabel = new System.Windows.Forms.Label();
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
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLVT.QLVT_DATHANGDataSet();
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.gcDH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.btnChonKho = new System.Windows.Forms.Button();
            this.nhaCCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dateNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaDDH = new DevExpress.XtraEditors.TextEdit();
            this.mAKHOTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.gcCTDDH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATTU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MAVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsCTDDH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGhi = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieuNhapTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.vattuTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            this.cmsCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            this.masoDDHLabel.AutoSize = true;
            this.masoDDHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masoDDHLabel.Location = new System.Drawing.Point(39, 22);
            this.masoDDHLabel.Name = "masoDDHLabel";
            this.masoDDHLabel.Size = new System.Drawing.Size(65, 17);
            this.masoDDHLabel.TabIndex = 0;
            this.masoDDHLabel.Text = "Mã DDH";
            // 
            // nGAYLabel
            // 
            this.nGAYLabel.AutoSize = true;
            this.nGAYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nGAYLabel.Location = new System.Drawing.Point(52, 63);
            this.nGAYLabel.Name = "nGAYLabel";
            this.nGAYLabel.Size = new System.Drawing.Size(40, 17);
            this.nGAYLabel.TabIndex = 2;
            this.nGAYLabel.Text = "Ngày";
            // 
            // nhaCCLabel
            // 
            this.nhaCCLabel.AutoSize = true;
            this.nhaCCLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhaCCLabel.Location = new System.Drawing.Point(298, 22);
            this.nhaCCLabel.Name = "nhaCCLabel";
            this.nhaCCLabel.Size = new System.Drawing.Size(57, 17);
            this.nhaCCLabel.TabIndex = 4;
            this.nhaCCLabel.Text = "Nhà CC";
            // 
            // mANVLabel
            // 
            this.mANVLabel.AutoSize = true;
            this.mANVLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANVLabel.Location = new System.Drawing.Point(298, 62);
            this.mANVLabel.Name = "mANVLabel";
            this.mANVLabel.Size = new System.Drawing.Size(54, 17);
            this.mANVLabel.TabIndex = 6;
            this.mANVLabel.Text = "Mã NV";
            // 
            // mAKHOLabel
            // 
            this.mAKHOLabel.AutoSize = true;
            this.mAKHOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAKHOLabel.Location = new System.Drawing.Point(41, 111);
            this.mAKHOLabel.Name = "mAKHOLabel";
            this.mAKHOLabel.Size = new System.Drawing.Size(57, 17);
            this.mAKHOLabel.TabIndex = 8;
            this.mAKHOLabel.Text = "Mã Kho";
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
            this.barButtonItem7,
            this.barButtonItem8,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
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
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(100, 60);
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 60);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phuc hoi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(100, 60);
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
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
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 10;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 60);
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1217, 81);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 613);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1217, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 81);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 532);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1217, 81);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 532);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Đơn đặt hàng";
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Chi tiết đơn đặt hàng";
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(200, 18);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(189, 25);
            this.cmbCHINHANH.TabIndex = 4;
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1217, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 633);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1217, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 633);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1217, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 633);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbCHINHANH);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 81);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1217, 69);
            this.panelControl1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chi Nhánh";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "DatHang";
            this.bdsDH.DataSource = this.dS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcDH
            // 
            this.gcDH.DataSource = this.bdsDH;
            this.gcDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcDH.Location = new System.Drawing.Point(0, 150);
            this.gcDH.MainView = this.gridView1;
            this.gcDH.MenuManager = this.barManager1;
            this.gcDH.Name = "gcDH";
            this.gcDH.Size = new System.Drawing.Size(1217, 242);
            this.gcDH.TabIndex = 22;
            this.gcDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcDH;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.AllowEdit = false;
            this.colMasoDDH.OptionsColumn.ReadOnly = true;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.OptionsColumn.ReadOnly = true;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.OptionsColumn.AllowEdit = false;
            this.colNhaCC.OptionsColumn.ReadOnly = true;
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.OptionsColumn.ReadOnly = true;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.OptionsColumn.ReadOnly = true;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.btnChonKho);
            this.panelNhapLieu.Controls.Add(this.mAKHOLabel);
            this.panelNhapLieu.Controls.Add(this.mANVLabel);
            this.panelNhapLieu.Controls.Add(this.nhaCCLabel);
            this.panelNhapLieu.Controls.Add(this.nhaCCTextEdit);
            this.panelNhapLieu.Controls.Add(this.nGAYLabel);
            this.panelNhapLieu.Controls.Add(this.dateNgay);
            this.panelNhapLieu.Controls.Add(this.masoDDHLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaDDH);
            this.panelNhapLieu.Controls.Add(this.mAKHOTextEdit);
            this.panelNhapLieu.Controls.Add(this.txtMaNV);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 392);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(696, 221);
            this.panelNhapLieu.TabIndex = 31;
            // 
            // btnChonKho
            // 
            this.btnChonKho.Location = new System.Drawing.Point(376, 122);
            this.btnChonKho.Name = "btnChonKho";
            this.btnChonKho.Size = new System.Drawing.Size(104, 41);
            this.btnChonKho.TabIndex = 10;
            this.btnChonKho.Text = "Chọn Kho";
            this.btnChonKho.UseVisualStyleBackColor = true;
            this.btnChonKho.Click += new System.EventHandler(this.btnChonKho_Click);
            // 
            // nhaCCTextEdit
            // 
            this.nhaCCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "NhaCC", true));
            this.nhaCCTextEdit.Location = new System.Drawing.Point(376, 19);
            this.nhaCCTextEdit.MenuManager = this.barManager1;
            this.nhaCCTextEdit.Name = "nhaCCTextEdit";
            this.nhaCCTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhaCCTextEdit.Properties.Appearance.Options.UseFont = true;
            this.nhaCCTextEdit.Size = new System.Drawing.Size(164, 24);
            this.nhaCCTextEdit.TabIndex = 5;
            // 
            // dateNgay
            // 
            this.dateNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "NGAY", true));
            this.dateNgay.EditValue = null;
            this.dateNgay.Location = new System.Drawing.Point(129, 60);
            this.dateNgay.MenuManager = this.barManager1;
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgay.Properties.Appearance.Options.UseFont = true;
            this.dateNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgay.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dateNgay.Size = new System.Drawing.Size(142, 24);
            this.dateNgay.TabIndex = 3;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "MasoDDH", true));
            this.txtMaDDH.Location = new System.Drawing.Point(129, 19);
            this.txtMaDDH.MenuManager = this.barManager1;
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDDH.Properties.Appearance.Options.UseFont = true;
            this.txtMaDDH.Size = new System.Drawing.Size(142, 24);
            this.txtMaDDH.TabIndex = 1;
            // 
            // mAKHOTextEdit
            // 
            this.mAKHOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "MAKHO", true));
            this.mAKHOTextEdit.Location = new System.Drawing.Point(129, 108);
            this.mAKHOTextEdit.MenuManager = this.barManager1;
            this.mAKHOTextEdit.Name = "mAKHOTextEdit";
            this.mAKHOTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAKHOTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAKHOTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mAKHOTextEdit.Size = new System.Drawing.Size(142, 24);
            this.mAKHOTextEdit.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "MANV", true));
            this.txtMaNV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaNV.Location = new System.Drawing.Point(376, 60);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtMaNV.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMaNV.Size = new System.Drawing.Size(104, 24);
            this.txtMaNV.TabIndex = 7;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.AllowNew = true;
            this.bdsCTDDH.DataMember = "FK_DatHang_CTDDH";
            this.bdsCTDDH.DataSource = this.bdsDH;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.AllowUserToAddRows = false;
            this.gcCTDDH.AllowUserToDeleteRows = false;
            this.gcCTDDH.AutoGenerateColumns = false;
            this.gcCTDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcCTDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.VATTU,
            this.MAVT,
            this.SOLUONG,
            this.DONGIA});
            this.gcCTDDH.ContextMenuStrip = this.cmsCTDDH;
            this.gcCTDDH.DataSource = this.bdsCTDDH;
            this.gcCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTDDH.Location = new System.Drawing.Point(696, 392);
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.RowHeadersWidth = 51;
            this.gcCTDDH.RowTemplate.Height = 24;
            this.gcCTDDH.Size = new System.Drawing.Size(521, 221);
            this.gcCTDDH.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasoDDH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MasoDDH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // VATTU
            // 
            this.VATTU.DataPropertyName = "MAVT";
            this.VATTU.DataSource = this.vattuBindingSource;
            this.VATTU.DisplayMember = "TENVT";
            this.VATTU.HeaderText = "VATTU";
            this.VATTU.MinimumWidth = 6;
            this.VATTU.Name = "VATTU";
            this.VATTU.ValueMember = "MAVT";
            this.VATTU.Width = 125;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.dS;
            // 
            // MAVT
            // 
            this.MAVT.DataPropertyName = "MAVT";
            this.MAVT.HeaderText = "MAVT";
            this.MAVT.MinimumWidth = 6;
            this.MAVT.Name = "MAVT";
            this.MAVT.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "SOLUONG";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "DONGIA";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 125;
            // 
            // cmsCTDDH
            // 
            this.cmsCTDDH.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCTDDH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThem,
            this.menuGhi,
            this.xoáToolStripMenuItem});
            this.cmsCTDDH.Name = "cmsCTDDH";
            this.cmsCTDDH.Size = new System.Drawing.Size(129, 70);
            // 
            // menuThem
            // 
            this.menuThem.Name = "menuThem";
            this.menuThem.Size = new System.Drawing.Size(128, 22);
            this.menuThem.Text = "Thêm mới";
            this.menuThem.Click += new System.EventHandler(this.menuThem_Click);
            // 
            // menuGhi
            // 
            this.menuGhi.Name = "menuGhi";
            this.menuGhi.Size = new System.Drawing.Size(128, 22);
            this.menuGhi.Text = "Ghi";
            this.menuGhi.Click += new System.EventHandler(this.menuGhi_Click);
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.xoáToolStripMenuItem.Text = "Xoá";
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // FormDonDatHang
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 633);
            this.Controls.Add(this.gcCTDDH);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcDH);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDonDatHang";
            this.Text = "frmDonDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            this.cmsCTDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bdsDH;
        private QLVT_DATHANGDataSet dS;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl panelNhapLieu;
        private DevExpress.XtraEditors.TextEdit nhaCCTextEdit;
        private DevExpress.XtraEditors.DateEdit dateNgay;
        private DevExpress.XtraEditors.TextEdit txtMaDDH;
        private DevExpress.XtraEditors.ComboBoxEdit mAKHOTextEdit;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.DataGridView gcCTDDH;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.ContextMenuStrip cmsCTDDH;
        private System.Windows.Forms.ToolStripMenuItem menuThem;
        private System.Windows.Forms.ToolStripMenuItem menuGhi;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn VATTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.Label masoDDHLabel;
        private System.Windows.Forms.Label nGAYLabel;
        private System.Windows.Forms.Label nhaCCLabel;
        private System.Windows.Forms.Label mANVLabel;
        private System.Windows.Forms.Label mAKHOLabel;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.Button btnChonKho;
        private System.Windows.Forms.Label label1;
    }
}