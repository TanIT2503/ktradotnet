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
    public partial class frm_NhaCungCap : Form
    {
        LopDungChung lopDungChung;
        public frm_NhaCungCap()
        {
            InitializeComponent();
            lopDungChung = new LopDungChung();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_MaNhaCC.Text == "")
                {
                    MessageBox.Show("Chua Nhap ma NCC");
                }
                else
                {
                    string sqlThem = "insert into NHACUNGCAP values('" + txt_MaNhaCC.Text + "', N'" + txt_TenNhaCC.Text + "', N'" + txt_DiaChi.Text + "', '" + txt_SoDT.Text + "')";
                    lopDungChung.NonQuery(sqlThem);
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("Ma NCC bi trung");
            }
        }

        public void LoadData()
        {
            string sqlLoad = "select * from NHACUNGCAP";
            dataGridView1.DataSource = lopDungChung.LoadGrid(sqlLoad);
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "update NHACUNGCAP set TenNhaCC = N'" + txt_TenNhaCC.Text + "', DiaChi = N'" + txt_DiaChi.Text + "', SoDienThoai = '" + txt_SoDT.Text + "' where MaNhaCC = '" + txt_MaNhaCC.Text + "'";
            lopDungChung.NonQuery(sqlSua);
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "Delete from NHACUNGCAP where MaNhaCC = '" + txt_MaNhaCC.Text + "'";
            lopDungChung.NonQuery(sqlXoa);
            LoadData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Ban co muon thoat chuong trinh?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNhaCC.Text = dataGridView1.CurrentRow.Cells["MaNhaCC"].Value.ToString();
            txt_TenNhaCC.Text = dataGridView1.CurrentRow.Cells["TenNhaCC"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_SoDT.Text = dataGridView1.CurrentRow.Cells["SoDienThoai"].Value.ToString();
        }
    }
}
