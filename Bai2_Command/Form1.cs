using DevExpress.Xpo.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_Command
{
    public partial class Frm_main : Form
    {
        SqlConnection cnn = new SqlConnection();
        int state = 0;

        const int STATE_NORMAL = 0;
        const int STATE_ADD    = 1;
        const int STATE_EDIT   = 2;

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

        private void load_txts(int ind_item=0)
        {
            try
            {
                ListViewItem item = lv_data.Items[ind_item];

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

        private void disable_txts()
        {
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = false;
                }    
            }
        }

        private void enable_txts()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = true;
                }
            }
        }

        private void clear_txts()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = "";
                }
            }
        }

        private void add_data()
        {
            string str = "insert into KhachHang (MaKH, TenKH, DCKH, DTKH) "
                     + "values(@MaKH,@TenKH,@DCKH,@DTKH)";

            try
            {
                SqlCommand cmd = get_sqlCommand(str);
                cmd.Parameters.Add("@MaKH", SqlDbType.Float).Value = float.Parse(txt_maKH.Text);
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = txt_tenKH.Text;
                cmd.Parameters.Add("@DCKH", SqlDbType.NVarChar).Value = txt_diaChi.Text;
                cmd.Parameters.Add("@DTKH", SqlDbType.NVarChar).Value = txt_SDT.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex.Message);
            }

            load_data();
        }


        private void edit_data()
        {

        }

        public Frm_main()
        {
            InitializeComponent();
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            connect_sql();
            load_data();
            disable_txts();
        }

        private void lv_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_data.SelectedIndices.Count == 0) { return; }
            load_txts(lv_data.SelectedIndices[0]);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = get_sqlCommand("Select * from KhachHang");
            SqlDataReader rdr = cmd.ExecuteReader();
            string str = "";

            for (int i = 0; i < rdr.FieldCount; ++i)
            {
                str += rdr.GetName(i) + "\t";
            }
            str += "\n";

            while (rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; ++i)
                {
                    str += rdr.GetValue(i) + "\t";
                }
                str += "\n";
            }    

            MessageBox.Show(str);
            rdr.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (state == STATE_ADD)
            {
                add_data();
                disable_txts();
            }
            else if (state == STATE_EDIT)
            {
                edit_data();
                disable_txts();
            }
            else
                MessageBox.Show("Chưa có thay đổi để lưu");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            clear_txts();
            enable_txts();
            state = STATE_ADD;
        }
    }
}
