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
    public partial class Frm_detail : Form
    {
        public Frm_detail()
        {
            InitializeComponent();
        }

        public Frm_detail(BindingSource source)
        {
            InitializeComponent();

            BindingSource bds = source;

            txt_maKH.DataBindings.Clear();
            txt_tenKH.DataBindings.Clear();
            txt_diaChi.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();

            txt_maKH.DataBindings.Add("Text", bds, "MaKH", true, DataSourceUpdateMode.OnPropertyChanged);
            txt_tenKH.DataBindings.Add("Text", bds, "TenKH", true, DataSourceUpdateMode.OnPropertyChanged);
            txt_diaChi.DataBindings.Add("Text", bds, "DCKH", true, DataSourceUpdateMode.OnPropertyChanged);
            txt_SDT.DataBindings.Add("Text", bds, "DTKH", true, DataSourceUpdateMode.OnPropertyChanged);
        }    

        private void Frm_detail_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Sql_service.upd_tbKH();
        }
    }
}
