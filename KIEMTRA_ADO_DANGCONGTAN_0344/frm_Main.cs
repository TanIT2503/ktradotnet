using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIEMTRA_ADO_DANGCONGTAN_0344
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void nhaCungCapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhaCungCap"] == null)
            {
                frm_NhaCungCap frm = new frm_NhaCungCap();
                frm.MdiParent = this;
                frm.Show();
            }
            
            
        }

        private void danhMucHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DanhMucHang"] == null)
            {
                frm_DanhMucHang frm = new frm_DanhMucHang();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Ban co muon thoat chuong trinh?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
