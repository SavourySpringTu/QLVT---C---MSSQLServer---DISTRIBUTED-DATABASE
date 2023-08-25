
namespace QLVT
{
    partial class FormVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.Windows.Forms.Label dVTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
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
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuongTon = new DevExpress.XtraEditors.SpinEdit();
            this.txtTenVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.ctpxTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTPXTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.ctpnTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.ctddhTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAVTLabel.Location = new System.Drawing.Point(48, 33);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(54, 17);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã VT:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENVTLabel.Location = new System.Drawing.Point(347, 41);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(57, 17);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên VT:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGTONLabel.Location = new System.Drawing.Point(308, 117);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(96, 17);
            sOLUONGTONLabel.TabIndex = 4;
            sOLUONGTONLabel.Text = "Số Lượng Tồn:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dVTLabel.Location = new System.Drawing.Point(24, 113);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(85, 17);
            dVTLabel.TabIndex = 6;
            dVTLabel.Text = "Đơn Vị Tính:";
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager2.DockControls.Add(this.barDockControlTop);
            this.barManager2.DockControls.Add(this.barDockControlBottom);
            this.barManager2.DockControls.Add(this.barDockControlLeft);
            this.barManager2.DockControls.Add(this.barDockControlRight);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnThoat});
            this.barManager2.MainMenu = this.bar2;
            this.barManager2.MaxItemId = 9;
            this.barManager2.StatusBar = this.bar3;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
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
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 60);
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(100, 60);
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 60);
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(100, 60);
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 6;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 60);
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
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
            this.barDockControlTop.Manager = this.barManager2;
            this.barDockControlTop.Size = new System.Drawing.Size(1264, 81);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 620);
            this.barDockControlBottom.Manager = this.barManager2;
            this.barDockControlBottom.Size = new System.Drawing.Size(1264, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 81);
            this.barDockControlLeft.Manager = this.barManager2;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 539);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1264, 81);
            this.barDockControlRight.Manager = this.barManager2;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 539);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 81);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1264, 100);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(149, 36);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(212, 25);
            this.cmbChiNhanh.TabIndex = 1;
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
            // 
            // QLVT_DATHANGDataSet
            // 
            this.QLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.QLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.QLVT_DATHANGDataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.bdsVatTu;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVatTu.Location = new System.Drawing.Point(0, 181);
            this.gcVatTu.MainView = this.gridView1;
            this.gcVatTu.MenuManager = this.barManager2;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(1264, 220);
            this.gcVatTu.TabIndex = 6;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.gcVatTu;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.OptionsColumn.ReadOnly = true;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.OptionsColumn.ReadOnly = true;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(dVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtDonViTinh);
            this.panelNhapLieu.Controls.Add(sOLUONGTONLabel);
            this.panelNhapLieu.Controls.Add(this.txtSoLuongTon);
            this.panelNhapLieu.Controls.Add(tENVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtTenVT);
            this.panelNhapLieu.Controls.Add(mAVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaVT);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 401);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1264, 254);
            this.panelNhapLieu.TabIndex = 7;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "DVT", true));
            this.txtDonViTinh.Location = new System.Drawing.Point(115, 110);
            this.txtDonViTinh.MenuManager = this.barManager2;
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Properties.Appearance.Options.UseFont = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(141, 24);
            this.txtDonViTinh.TabIndex = 7;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "SOLUONGTON", true));
            this.txtSoLuongTon.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuongTon.Location = new System.Drawing.Point(417, 110);
            this.txtSoLuongTon.MenuManager = this.barManager2;
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuongTon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuongTon.Size = new System.Drawing.Size(138, 24);
            this.txtSoLuongTon.TabIndex = 5;
            // 
            // txtTenVT
            // 
            this.txtTenVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "TENVT", true));
            this.txtTenVT.Location = new System.Drawing.Point(417, 34);
            this.txtTenVT.MenuManager = this.barManager2;
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVT.Properties.Appearance.Options.UseFont = true;
            this.txtTenVT.Size = new System.Drawing.Size(138, 24);
            this.txtTenVT.TabIndex = 3;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(115, 30);
            this.txtMaVT.MenuManager = this.barManager2;
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Properties.Appearance.Options.UseFont = true;
            this.txtMaVT.Size = new System.Drawing.Size(141, 24);
            this.txtMaVT.TabIndex = 1;
            // 
            // ctpxTableAdapter
            // 
            this.ctpxTableAdapter.ClearBeforeFill = true;
            // 
            // ctpnTableAdapter
            // 
            this.ctpnTableAdapter.ClearBeforeFill = true;
            // 
            // ctddhTableAdapter
            // 
            this.ctddhTableAdapter.ClearBeforeFill = true;
            // 
            // FormVatTu
            // 
            this.ClientSize = new System.Drawing.Size(1264, 640);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormVatTu";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
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
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private QLVT_DATHANGDataSet QLVT_DATHANGDataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelNhapLieu;
        private DevExpress.XtraEditors.TextEdit txtDonViTinh;
        private DevExpress.XtraEditors.SpinEdit txtSoLuongTon;
        private DevExpress.XtraEditors.TextEdit txtTenVT;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private QLVT_DATHANGDataSetTableAdapters.CTPXTableAdapter ctpxTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter ctpnTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter ctddhTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
    }
}