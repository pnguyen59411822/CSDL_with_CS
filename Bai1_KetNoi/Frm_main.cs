using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_KetNoi
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            lb_user.ForeColor = Color.LightSteelBlue;
            lb_pass.ForeColor = Color.LightSteelBlue;

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
            
        }
    }
}
