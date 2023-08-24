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

namespace QLVT
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn = new SqlConnection();
        public Login()
        {
            InitializeComponent();
        }
        private void layDanhSachPhanManh(String cmd)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);


            conn.Close();
            Program.bindingSource.DataSource = dt;


            comboBox1.DataSource = Program.bindingSource;
            comboBox1.DisplayMember = "TENCN";
            comboBox1.ValueMember = "TENSERVER";
           
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private int KetNoiDatabaseGoc()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.ConnectionString = Program.connstrPublisher;
                conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void Combox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = comboBox1.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            Program.loginName = textBox1.Text.Trim();
            Program.loginPassword = textBox2.Text.Trim();
            Program.serverName = comboBox1.SelectedValue.ToString();
            if (Program.KetNoi() == 0)
                return;

            Program.brand = comboBox1.SelectedIndex;
            Program.currentLogin = Program.loginName;
            Program.currentPassword = Program.loginPassword;

            String statement = "EXEC sp_DangNhap '" + Program.loginName + "'";
            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null)
                return;
            Program.myReader.Read();

            Program.userName = Program.myReader.GetString(0);// lấy userName
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }

            Program.staff = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);

            Program.formChinh = new FormChinh();
            Program.formChinh.Show();
            Program.myReader.Close();
            Program.conn.Close();

            this.Visible = false;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            if (KetNoiDatabaseGoc() == 0)
                return;
            layDanhSachPhanManh("SELECT TOP 2 * FROM view_DanhSachPhanManh");
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(1);
        }
    }
}
