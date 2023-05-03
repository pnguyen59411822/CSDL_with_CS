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

namespace Bai1_KetNoi
{
    public partial class frm_main : Form
    {
        private string get_connectionString()
        {
            string str = "Server=" + txt_server.Text
                       + ";database=" + txt_database.Text;

            if (rbtn_win.Checked == true)
            {
                str += ";integrated security=true";
            }

            else
            {
                str += ";uid=" + txt_user.Text
                    + ";pwd=" + txt_pass.Text;
            }

            return str;
        }

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            const string DEFAULT_SERVER = "DESKTOP-L72T38U\\SQLEXPRESS";
            const string DEFAULT_DATABASE = "";

            lb_user.ForeColor = Color.LightSteelBlue;
            lb_pass.ForeColor = Color.LightSteelBlue;

            txt_server.Text = DEFAULT_SERVER;
            txt_database.Text = DEFAULT_DATABASE;

            txt_user.Enabled = false;
            txt_pass.Enabled = false;

        }


        private void rbtn_win_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_win.Checked == false) { return; }

            lb_user.ForeColor = Color.LightSteelBlue;
            lb_pass.ForeColor = Color.LightSteelBlue;

            txt_user.Enabled = false;
            txt_pass.Enabled = false;
        }

        private void rbtn_sql_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_sql.Checked == false) { return; }

            lb_user.ForeColor = Color.RoyalBlue;
            lb_pass.ForeColor = Color.RoyalBlue;

            txt_user.Enabled = true;
            txt_pass.Enabled = true;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = get_connectionString();
                cnn.Open();

                MessageBox.Show("Kết nối sql thành công");
                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Kết nối sql thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }
    }
}
