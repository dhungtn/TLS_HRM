using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraTabbedMdi;
using System.Data;
namespace QLNhanSu
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string flag1 = "1";
        public delegate void Thoat();
        public Thoat thoat;
        DataTable dt = new DataTable();
        public fMain()
        {
            InitializeComponent();
            InitSkinGallery();
        }
        public fMain(DataTable dt)
        {
            InitializeComponent();
            InitSkinGallery();
            this.dt = dt;
        }

        private void loadSkin()
        {
            string s = BUS.BUS_hethong.loadSkin();
            thaydoigiaodien.LookAndFeel.SkinName = s;
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rb_Skin,true);
        }
        #region Phân quyền
        public void phanquyen()
        {
            if (dt.Rows[0]["quyen"].ToString() == "0")
            {
                //bt_dmBophan.Enabled = false;
                //bt_dmChucvu.Enabled = false;
                //bt_dmLoaicong.Enabled = false;
                //bt_dmPhucap.Enabled = false;
                //bt_dmLoaica.Enabled = false;
                //bt_dmTinh.Enabled = false;
                //barbt_saoluu.Enabled = false;
                //barbt_phuchoi.Enabled = false;
                //barbt_taikhoan.Enabled = false;
                //navBarItem_DMTinh.Enabled = false;
                //navBarItem_DMbophan.Enabled = false;
                //navBarItem_DMChucvu.Enabled = false;
                //navBarItem_DMLoaicong.Enabled = false;
                //navBarItem_DMPhucap.Enabled = false;
                //navBarItem_taikhoan.Enabled = false;
                //navBarItem_phuchoi.Enabled = false;
                //navBarItem_Saoluu.Enabled = false;
            }
            else
            {
                //bt_dmBophan.Enabled = true;
                //bt_dmChucvu.Enabled = true;
                //bt_dmLoaicong.Enabled = true;
                //bt_dmPhucap.Enabled = true;
                //bt_dmLoaica.Enabled = true;
                //bt_dmTinh.Enabled = true;
                //barbt_saoluu.Enabled = true;
                //barbt_phuchoi.Enabled = true;
                //barbt_taikhoan.Enabled = true;
                //navBarItem_DMTinh.Enabled = true;
                //navBarItem_DMbophan.Enabled = true;
                //navBarItem_DMChucvu.Enabled = true;
                //navBarItem_DMLoaicong.Enabled = true;
                //navBarItem_DMPhucap.Enabled = true;
                //navBarItem_taikhoan.Enabled = true;
                //navBarItem_phuchoi.Enabled = true;
                //navBarItem_Saoluu.Enabled = true;
            }
        }
        #endregion
        

        private void btbaocaonhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            thaydoigiaodien.LookAndFeel.SkinName = "Whiteprint";
        }
        private void navBarItemQLSV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement();
            foreach (fEmployeeManagement f in this.MdiChildren)
            {
                if(f.Name == qlsv.Name)
                    f.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

       
        private void btbaocaoluong_ItemClick(object sender, ItemClickEventArgs e)
        {
            dockPanel1.Show();
        }

        
        private void navBarItemQLSV_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void btQuanlynhanvien_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
            fEmployeeManagement qlsv = new fEmployeeManagement(0);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void btquanlybaocao_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btbaocaoluong_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            thaydoigiaodien.LookAndFeel.SkinName = "Office 2010 Blue";
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            fNhapXuatNhanvienExcel nx = new fNhapXuatNhanvienExcel();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (nx.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            nx.MdiParent = this;
            nx.Show();
        }

        private void barbt_nvchuakyhopdonglannao_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement(1);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void barbt_nvsaphethopdong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement(3);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void barbt_nvdahethopdong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement(2);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void barbt_nvdangconhieuluchopdong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement(4);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void barbt_nvchuacobaohiemlannao_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement(5);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void barbt_nvdahethanbaohiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement(6);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void barbt_nvsaphethanbaohiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement(7);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void barbt_nvdangconhieulucbaohiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement(8);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void nvnghiviec_bar_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement qlsv = new fEmployeeManagement(9);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlsv.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void bt_baocaonhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            fBaocaoNV bcnv = new fBaocaoNV();
            bcnv.Show();
        }

        private void fMainForm_Load(object sender, EventArgs e)
        {
            loadSkin();
            XtraTabbedMdiManager mdiManager = new XtraTabbedMdiManager();
            mdiManager.MdiParent = this;
            check_chucnang.Checked = true;
        }

        private void btBaocaoNVdenhanhopdong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.f_sapkiHD frm = new Report.f_sapkiHD();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btThemcong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fThemcong themcong = new fThemcong();
            themcong.Show();
        }
        private void btLoaicong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fLoaicong loaicong = new fLoaicong();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (loaicong.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            loaicong.MdiParent = this;
            loaicong.Show();
        }

        private void bt_NvVaolamtheongay_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rpt_bctheongaylamviec frm = new Rpt_bctheongaylamviec();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_NvNghiviectheongay_ItemClick(object sender, ItemClickEventArgs e)
        {
            f_rpt_nghiviec frm = new f_rpt_nghiviec();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            radialMenu1.ShowPopup(new Point(100, 100));
        }

        private void navBarItemNhapxuatTufileExcel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fNhapXuatNhanvienExcel nx = new fNhapXuatNhanvienExcel();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (nx.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            nx.MdiParent = this;
            nx.Show();
        }

        private void navBarItem_BcNvVaolamNgay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fBaocaoNV bcnv = new fBaocaoNV();
            bcnv.Show();
        }

        private void navBarItem_BcNcDathoiviec_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            f_rpt_nghiviec frm = new f_rpt_nghiviec();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void fMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            thoat();
        }

        private void btPhucap_ItemClick(object sender, ItemClickEventArgs e)
        {
            fPhucap frm = new fPhucap();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void ribbon_Click_1(object sender, EventArgs e)
        {

        }

        private void btBangcong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fTimesheets frm = new fTimesheets();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btNvTangca_ItemClick(object sender, ItemClickEventArgs e)
        {
            fQltangca frm = new fQltangca();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if(frm.Name==_mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btThemTangca_ItemClick(object sender, ItemClickEventArgs e)
        {
            fThemtangca frm = new fThemtangca();
            frm.Show();
        }

        private void btNvUngluong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fSalaryAdvance frm = new fSalaryAdvance();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }
        private void btNhanviennghiviec_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.f_Nhanvienngiviectrongthang frm = new Report.f_Nhanvienngiviectrongthang();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btKhautru_ItemClick(object sender, ItemClickEventArgs e)
        {
            fKhautru frm = new fKhautru();
            frm.Show();
        }

        private void btNvDitre_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.fNhanvienditre frm = new Report.fNhanvienditre();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_Bcbangcongthang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.f_rptBangcong frm = new Report.f_rptBangcong();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_nhap_excel_ItemClick(object sender, ItemClickEventArgs e)
        {
            fNhapExcelBangCong FRM = new fNhapExcelBangCong();
            FRM.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            fCongdoan frm = new fCongdoan();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btChitietphucap_ItemClick(object sender, ItemClickEventArgs e)
        {
            fPhucapNhanvien frm = new fPhucapNhanvien();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btBar_DMLoaica_ItemClick(object sender, ItemClickEventArgs e)
        {
            fDMTangca frm = new fDMTangca();
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            fBangluong frm = new fBangluong();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBar_NvDenhanKyhopdong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Report.f_sapkiHD frm = new Report.f_sapkiHD();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBar_NvVaoLam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Rpt_bctheongaylamviec frm = new Rpt_bctheongaylamviec();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBar_Congdoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fCongdoan frm = new fCongdoan();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_Bangcong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fTimesheets frm = new fTimesheets();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItemQLTangca_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fQltangca frm = new fQltangca();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_NvUngluong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fSalaryAdvance frm = new fSalaryAdvance();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_Khautru_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fKhautru frm = new fKhautru();
            frm.Show();
        }

        private void navBarItem_Loaicong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fLoaicong loaicong = new fLoaicong();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (loaicong.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            loaicong.MdiParent = this;
            loaicong.Show();
        }

        private void navBar_phucap_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fPhucap frm = new fPhucap();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barbt_saoluu_ItemClick(object sender, ItemClickEventArgs e)
        {
            fBackup frm = new fBackup();
            frm.Show();
        }

        private void barbt_phuchoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            fRestore frm = new fRestore();
            frm.Show();
        }

        private void barbt_taikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            fAccount frm = new fAccount(dt.Rows[0]["ten"].ToString(), dt.Rows[0]["quyen"].ToString());
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bar_ThoatFRM_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bar_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            // mo lai frm dang nhap
        }

        private void bar_DoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            fChangePassword frm = new fChangePassword();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string ngay = "Ngày: "+DateTime.Now.Day.ToString()+"/";
            ngay += DateTime.Now.Month.ToString() + "/";
            ngay += DateTime.Now.Year.ToString();
            string gio = "Giờ: " + DateTime.Now.Hour.ToString() + ":";
            gio += DateTime.Now.Minute.ToString() + ":";
            gio += DateTime.Now.Second.ToString();
            string nguoidung = "Đăng nhập dưới tên: " + dt.Rows[0]["ten"].ToString();
            bar_user.Caption = nguoidung;
            bar_ngay.Caption = ngay;
            bar_gio.Caption = gio;
        }

        private void bt_dmNhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            fEmployeeManagement frm = new fEmployeeManagement();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_dmCongdoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            fCongdoan frm = new fCongdoan();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_dmBophan_ItemClick(object sender, ItemClickEventArgs e)
        {
            fDepartment frm = new fDepartment();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_dmChucvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            fChucvu frm = new fChucvu();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_dmLoaicong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fLoaicong frm = new fLoaicong();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_dmPhucap_ItemClick(object sender, ItemClickEventArgs e)
        {
            fPhucap frm = new fPhucap();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_dmLoaica_ItemClick(object sender, ItemClickEventArgs e)
        {
            fDMTangca frm = new fDMTangca();
            frm.Show();
        }

        private void check_chucnang_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (check_chucnang.Checked == true)
                dockPanel1.Show();
            else
                dockPanel1.Hide();
        }

        private void bt_dmTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            fTinh frm = new fTinh();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bt_doimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            fChangePassword frm = new fChangePassword(dt);
            frm.Show();
        }

        private void bt_thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void navBarItem_QlDMLuong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fBangluong frm = new fBangluong();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_DMTinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fTinh frm = new fTinh();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_DMNhanvien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fEmployeeManagement frm = new fEmployeeManagement();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_DMbophan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fDepartment frm = new fDepartment();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_DMChucvu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fChucvu frm = new fChucvu();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_DMLoaicong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fLoaicong frm = new fLoaicong();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_DMPhucap_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fPhucap frm = new fPhucap();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void bt_congdong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fCongdoan frm = new fCongdoan();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_taikhoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fAccount frm = new fAccount();
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (frm.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem_phuchoi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fRestore frm = new fRestore();
            frm.Show();
        }

        private void navBarItem_Saoluu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fBackup frm = new fBackup();
            frm.Show();
        }

        private void rb_Skin_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            if (BUS.BUS_hethong.updateSkin(e.Item.Caption)=="true")
            { }
            else
                BUS.BUS_hethong.updateSkin("Liquid Sky");
        }
    }
}