using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class ReportHDNV : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHDNV(String manv,DateTime bd,DateTime kt)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = manv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = bd;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = kt;
            this.sqlDataSource1.Fill();
        }

    }
}
