using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_Adapter
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void load_dtgrv()
        {
            try
            {
                bds.BindingComplete += new BindingCompleteEventHandler(fnc_bindingComplete);
                bds.DataSource = Sql_service.get_tbKH();

                dtgrv.DataSource = bds;

                dtgrv.Columns.Clear();
                dtgrv.Columns.Add("Mã KH", "Mã KH");
                dtgrv.Columns.Add("Tên KH", "Tên KH");
                dtgrv.Columns.Add("Địa chỉ", "Địa chỉ");
                dtgrv.Columns.Add("Số điện thoại", "Số điện thoại");
            }                

            catch (Exception ex)
            {
                MessageBox.Show("Load dataGridView thất bại. Nguyên nhân:\n" + ex.Message);
            }
        }

        private void fnc_bindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if(e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate
            && e.Exception == null)
            {
                e.Binding.BindingManagerBase.EndCurrentEdit();
            }    
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            Sql_service.connect_sql();
            load_dtgrv();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
