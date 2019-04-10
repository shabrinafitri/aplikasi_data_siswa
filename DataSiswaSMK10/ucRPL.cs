using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSiswaSMK10
{
    public partial class ucRPL : MetroFramework.Controls.MetroUserControl
    {
        public ucRPL()
        {
            InitializeComponent();
        }

        private void btnTambahUbah2019_Click(object sender, EventArgs e)
        {
            using (frmTambahUbahRPL2019 frm = new frmTambahUbahRPL2019()) {
                frm.ShowDialog();
            }
        }
    }
}
