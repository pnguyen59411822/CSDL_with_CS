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

namespace Bai2_Command
{
    public partial class Frm_main : Form
    {
        private string get_connectionString()
        {
            const string DEFAULT_SERVER = "DESKTOP-L72T38U\\SQLEXPRESS";
            const string DEFAULT_DATABASE = "HoaDon";

            string str = "Server=" + DEFAULT_SERVER
                       + ";database=" + DEFAULT_DATABASE
                       + ";integrated security=true";

            return str;
        }
        private void connect_sql()
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = get_connectionString();
                cnn.Open();

                MessageBox.Show("Kết nối sql thành công");
                cnn.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Kết nối sql thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        public Frm_main()
        {
            InitializeComponent();
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            connect_sql();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
