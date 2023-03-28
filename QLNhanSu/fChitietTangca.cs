using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace QLNhanSu
{
    public partial class fChitietTangca : DevExpress.XtraEditors.XtraForm
    {
        private string manv;
        private string thang;
        private string nam;
        public delegate void Reload();
        public Reload reload;
        NhanVien nv = new NhanVien();
        public fChitietTangca()
        {
            InitializeComponent();
        }
        #region load
        public fChitietTangca(string manv,string thang,string nam)
        {
            InitializeComponent();
            this.manv = manv;
            this.thang = thang;
            this.nam = nam;
            //////////
            txtManv.Text = manv;
            txtManv.Enabled = false;
            lbthangnam.Text = thang + "-" + nam;
            txtNgay.Text = thang + "-" + nam;
            nv = BUS.BUS_Nhanvien.Tennv(manv);
            img_anhdaidien.Image = null;
            Image img = BUS_Nhanvien.bingImageNV(manv);
            img_anhdaidien.Image = img;
            txtBophan.Text = nv.Bophan;
            txtTennv.Text = nv.Hoten;

        }
       
        private void fChitietTangca_Load(object sender, EventArgs e)
        {
            loadFull();
        }
        public void loadFull()
        {
            DataTable dt = BUS_Tangca.select_1NV_thang(manv, thang, nam);
            gridChitietTangcaNV.DataSource = dt;
            txtNgay.DataBindings.Clear();
            txtNgay.DataBindings.Add("Text",gridChitietTangcaNV.DataSource,"ngay");

            lbSogio.DataBindings.Clear();
            lbSogio.DataBindings.Add("Text", gridChitietTangcaNV.DataSource, "sogio");

            lbmaloai.DataBindings.Clear();
            lbmaloai.DataBindings.Add("Text", gridChitietTangcaNV.DataSource, "tenca");

            thongke();
        }
        private void thongke()
        {
            int thuong, le, dem, chunhat, tong;
            thuong = le = dem = chunhat = tong = 0;
            DataTable dt = BUS_Tangca.select_1NV_thang(manv, thang, nam);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["maloai"].ToString() == "tct")
                    thuong += int.Parse(dt.Rows[i]["sogio"].ToString());
                if (dt.Rows[i]["maloai"].ToString() == "tcd")
                    dem += int.Parse(dt.Rows[i]["sogio"].ToString());
                if (dt.Rows[i]["maloai"].ToString() == "tccn")
                    chunhat += int.Parse(dt.Rows[i]["sogio"].ToString());
                if (dt.Rows[i]["maloai"].ToString() == "tcl")
                    le += int.Parse(dt.Rows[i]["sogio"].ToString());
            }
            tong = thuong + le + dem + chunhat;
            lbChunhat.Text = chunhat.ToString();
            lbDem.Text = dem.ToString();
            lbLe.Text = le.ToString();
            lbThuong.Text = thuong.ToString();
            lbTong.Text = tong.ToString();
        }
        #endregion
        #region them
        private void them()
        {
            fThemtangca frm = new fThemtangca(manv);
            frm.reload = new fThemtangca.Reload(loadFull);
            frm.Show();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            them();
        }
        private void menuthem_Click(object sender, EventArgs e)
        {
            them();
        }
        #endregion
        #region sua
        private void sua()
        {
            Tangca tc = new Tangca();
            tc.Manv = txtManv.Text;
            tc.Ngay = txtNgay.Text;
            tc.Thang=thang;
            tc.Nam = nam;
            tc.Sogio = lbSogio.Text;
            fSuatangca frm = new fSuatangca(tc,lbmaloai.Text);
            frm.reload = new fSuatangca.Reload(loadFull);
            frm.Show();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            sua();
        }

       
        private void menusua_Click(object sender, EventArgs e)
        {
            sua();
        }
        #endregion
        
        #region xoa
        private void xoa()
        {
            if (gridChitietTangcaNV.MainView.RowCount > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa giờ tăng ca của nhân viên " + txtTennv.Text + " trong ngay " + txtNgay.Text + "/" + thang + "/" + nam + " hay không", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BUS_Tangca.delete_tangCaNgay(txtManv.Text, txtNgay.Text, thang, nam) != "true")
                    {
                        MessageBox.Show("Lỗi từ hệ thống hãy liên hệ với bộ phận kỹ thuật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        loadFull();
                }
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }
        private void menuxoa_Click(object sender, EventArgs e)
        {
            xoa();
        }
        #endregion
        private void menurestart_Click(object sender, EventArgs e)
        {
            loadFull();
        }
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fChitietTangca_FormClosed(object sender, FormClosedEventArgs e)
        {
            reload();
        }
    }
}