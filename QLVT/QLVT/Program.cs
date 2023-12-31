﻿using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVT
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr = "";
        public static String connstrPublisher = "Data Source=DESKTOP-9U8SQD3\\SQLSERVER01;Initial Catalog=QLVT_DATHANG;User ID=sa;Password=123";
        public static SqlDataReader myReader;//myReader

        public static String serverName = "";//servername
        public static String serverNameLeft = "";
        public static String userName = "";//username

        public static String loginName = "";//mlogin
        public static String loginPassword = "";//password

        public static String database = "QLVT_DATHANG";

        public static String remoteLogin = "HTKN";//remotelogin
        public static String remotePassword = "123";//remotepassword

        public static String currentLogin = "";//mloginDN
        public static String currentPassword = "";//passwordDN

        public static String role = "";// mGroup
        public static String staff = "";//mHoten
        public static int brand = 0;//mChiNhanh

        public static string maKhoDuocChon = "";
        public static string maVatTuDuocChon = "";

        public static int soLuongVatTu = 0;
        public static string maDonDatHangDuocChon = "";
        public static string maDonDatHangDuocChonChiTiet = "";
        public static int donGia = 0;

        public static string maNhanVienDuocChon = "";
        public static string hoTen = "";
        public static string diaChi = "";
        public static string ngaySinh = "";

        public static BindingSource bindingSource = new BindingSource();//bds_dspm
 
        public static Login login;
        public static FormChinh formChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.serverName + ";Initial Catalog="+Program.database + ";User ID="+Program.loginName + ";Password=" + Program.loginPassword;
                Console.WriteLine("Data Source=" + Program.serverName + ";Initial Catalog=" + Program.database + ";User ID=" + Program.loginName + ";Password=" + Program.loginPassword);

                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                //Console.WriteLine(e.Message);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;

            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.login = new Login();
            Application.Run(login);
        }
    }
}
