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

        public Frm_detail(BindingSource bds)
        {
            InitializeComponent();
        }    

        private void Frm_detail_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}
