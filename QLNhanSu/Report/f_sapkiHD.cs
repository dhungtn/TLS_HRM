using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNhanSu.Report.ds_sapkiHDTableAdapters;
using BUS;

namespace QLNhanSu.Report
{
    public partial class f_sapkiHD : DevExpress.XtraEditors.XtraForm
    {
        public f_sapkiHD()
        {
            InitializeComponent();
        }

        private void f_sapkiHD_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            Report.Rpt_sapkiHD Rp = new Rpt_sapkiHD();
            //Report.ds_sapkiHD ds = new ds_sapkiHD();
            //Report_Nhanvien_saphetHDTableAdapter sapki = new Report_Nhanvien_saphetHDTableAdapter();
            //sapki.Fill(ds.Report_Nhanvien_saphetHD);
            DataTable dt = BUS_Report.Report_Nhanvien_saphetHD();

            Rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = Rp;
        }
    }
}