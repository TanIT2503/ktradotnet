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
    public partial class frm_DanhMucHang : Form
    {
        LopDungChung lopDungChung;
        public frm_DanhMucHang()
        {
            InitializeComponent();
            lopDungChung = new LopDungChung();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaHang.Text == "")
                {
                    MessageBox.Show("Chua Nhap ma NCC");
                }
                else
                {
                    string sqlThem = "insert into DANHMUCHANG values ('" + txt_MaHang.Text + "', N'" + txt_TenHang.Text + "', '" + cbx_TenNCC.SelectedValue.ToString() + "', N'" + cbx_DonViTinh.Text + "')";
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
            string sqlLoad = "select * from DANHMUCHANG";
            dataGridView1.DataSource = lopDungChung.LoadGrid(sqlLoad);
        }

        public void LoadCombo()
        {
            string sqlLoadCombo = "Select * from NHACUNGCAP";
            cbx_TenNCC.DataSource = lopDungChung.LoadCombo(sqlLoadCombo);
            cbx_TenNCC.DisplayMember = "TenNhaCC";
            cbx_TenNCC.ValueMember = "MaNhaCC";
        }

        private void frm_DanhMucHang_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCombo();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "Update DANHMUCHANG set TenHang = '" + txt_TenHang.Text + "', MaNhaCC = '" + cbx_TenNCC.SelectedValue.ToString() + "', DonViTinh =  N'" + cbx_DonViTinh.Text + "' where MaHang = '" + txt_MaHang.Text + "'";
            lopDungChung.NonQuery(sqlSua);
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "Delete from DANHMUCHANG where MaHang = '" + txt_MaHang.Text + "'";
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
            txt_MaHang.Text = dataGridView1.CurrentRow.Cells["MaHang"].Value.ToString();
            txt_TenHang.Text = dataGridView1.CurrentRow.Cells["TenHang"].Value.ToString();
            cbx_TenNCC.SelectedValue = dataGridView1.CurrentRow.Cells["MaNhaCC"].Value.ToString();
            cbx_DonViTinh.Text = dataGridView1.CurrentRow.Cells["DonViTinh"].Value.ToString();
        }
    }
}
