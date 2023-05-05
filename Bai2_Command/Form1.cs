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
        const int STATE_NO_CHANGE = 0;
        const int STATE_ADD = 1;
        const int STATE_EDIT = 2;

        private int state = STATE_NO_CHANGE;

        public Frm_main()
        {
            InitializeComponent();
        }

        private void load_lv()
        {
            try
            {
                SqlDataReader rdr = Sql_service.get_cmdLoadLv().ExecuteReader();

                lv_data.Clear();
                lv_data.Columns.Add("Mã khách hàng");
                lv_data.Columns.Add("Tên khách hàng");
                lv_data.Columns.Add("Địa chỉ");
                lv_data.Columns.Add("Số điện thoại");

                while(rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr.GetValue(0).ToString());

                    for(int i=1; i<rdr.FieldCount; ++i)
                    {
                        item.SubItems.Add(rdr.GetValue(i).ToString());
                    }

                    lv_data.Items.Add(item);
                    lv_data.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }

                rdr.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Load data của list view thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        private void load_txts()
        {
            try
            {
                ListViewItem item;

                if (lv_data.SelectedIndices.Count == 0){
                    item = lv_data.Items[0];
                }

                else                {
                    item = lv_data.Items[lv_data.SelectedIndices[0]];
                }

                txt_maKH.Text = item.SubItems[0].Text;
                txt_tenKH.Text = item.SubItems[1].Text;
                txt_diaChi.Text = item.SubItems[2].Text;
                txt_SDT.Text = item.SubItems[3].Text;
            }

            catch( Exception ex )
            {
                MessageBox.Show("Load textboxes thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        private void enable_txts()
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = true;
                }
            }
        }

        private void disable_txts()
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = false;
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
            Sql_service.add_KH(
                float.Parse(txt_maKH.Text),
                txt_tenKH.Text,
                txt_diaChi.Text,
                txt_SDT.Text
             );
        }

        private void edit_data()
        {
            float maKH_prv = float.Parse(lv_data.SelectedItems[0].SubItems[0].Text);

            Sql_service.edit_KH(
                maKH_prv,
                float.Parse(txt_maKH.Text),
                txt_tenKH.Text,
                txt_diaChi.Text,
                txt_SDT.Text
             );
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Sql_service.disconnect_sql();
            this.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            Sql_service.connect_sql();
            load_lv();
            load_txts();
        }

        private void lv_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_txts();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            enable_txts();
            clear_txts();
            state = STATE_ADD;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(state == STATE_NO_CHANGE)
            {
                MessageBox.Show("Chưa có thay đổi cần lưu");
                return;
            }    

            if(state == STATE_ADD){
                add_data();
            }    

            else if(state == STATE_EDIT){
                edit_data();
            }

            disable_txts();
            load_lv();
            load_txts();
            state = STATE_NO_CHANGE;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lv_data.SelectedItems.Count == 0)
            {
                MessageBox.Show("Sửa dữ liệu thất bại. Nguyên nhân:\nBạn chưa chọn dòng cần sửa");
                return;
            }

            enable_txts();
            state = STATE_EDIT;
        }

        private void btn_rmv_Click(object sender, EventArgs e)
        {
            try
            {
                Sql_service.rmv_KH(float.Parse(lv_data.SelectedItems[0].SubItems[0].Text));
                load_lv();
                load_txts();
                state = STATE_NO_CHANGE;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu thất bại. Nguyên nhân:\nBạn chưa chọn dòng cần xóa");
            }
        }
    }
}
