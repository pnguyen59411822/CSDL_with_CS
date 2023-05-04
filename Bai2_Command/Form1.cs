using DevExpress.Xpo.Logger;
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
        SqlConnection cnn = new SqlConnection();

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
                cnn.ConnectionString = get_connectionString();
                cnn.Open();

                MessageBox.Show("Kết nối sql thành công");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Kết nối sql thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        private SqlCommand get_sqlCommand(string text)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = text;
                cmd.CommandTimeout = 60;
                cmd.Connection = cnn;

                return cmd;
            }

            catch (Exception ex)
            {
                MessageBox.Show("get_sqlCommand thất bại. Nguyên nhân:\n" + ex.Message);
                return new SqlCommand();
            }
        }

        private void load_lvData()
        {
            try
            {
                SqlCommand cmd = get_sqlCommand("select * from KhachHang");
                SqlDataReader rdr = cmd.ExecuteReader();

                lv_data.Clear();
                lv_data.Columns.Add("Mã khách hàng");
                lv_data.Columns.Add("Tên khách hàng");
                lv_data.Columns.Add("Địa chỉ");
                lv_data.Columns.Add("Số điện thoại");

                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr.GetValue(0).ToString());
                    item.SubItems.Add(rdr.GetValue(1).ToString());
                    item.SubItems.Add(rdr.GetValue(2).ToString());
                    item.SubItems.Add(rdr.GetValue(3).ToString());

                    lv_data.Items.Add(item);
                }

                rdr.Close();
                lv_data.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            catch(Exception ex) 
            {
                MessageBox.Show("load_lvData thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        private void load_txts()
        {
            try
            {
                ListViewItem item = lv_data.Items[0];

                txt_maKH.Text = item.SubItems[0].Text;
                txt_tenKH.Text = item.SubItems[1].Text;
                txt_diaChi.Text = item.SubItems[2].Text;
                txt_SDT.Text = item.SubItems[3].Text;
            }

            catch (Exception ex)
            {
                MessageBox.Show("load_txts thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        private void load_data()
        {
            load_lvData();
            load_txts();
        }

        public Frm_main()
        {
            InitializeComponent();
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            connect_sql();
            load_data();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
