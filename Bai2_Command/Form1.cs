﻿using System;
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
    }
}
