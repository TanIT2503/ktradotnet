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
    public partial class frm_DangNhap : Form
    {
        LopDungChung lopDungChung;
        public frm_DangNhap()
        {
            InitializeComponent();
            lopDungChung = new LopDungChung();
        }
        int count;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sqlDangNhap = "select count (*) from DANGNHAP where UserName = '" + txt_TenDangNhap.Text + "' and Password = '" + txt_MatKhau.Text + "'";
            int ketQua = (int)lopDungChung.Scalar(sqlDangNhap);
            if (ketQua >= 1)
            {
                frm_Main frm = new frm_Main();
                count = 0;
                frm.Show();
            }
            else
            {
                count++;
                lbl_ThongBao.Text ="Sai tai khoan hoac mat khau, vui long nhap lai.";
                if (count == 3)
                {
                    
                    MessageBox.Show("Ban da nhap sai qua 3 lan. Chuong trinh da thoat.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Ban co muon thoat chuong trinh?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_DangNhap;
        }
    }
}
