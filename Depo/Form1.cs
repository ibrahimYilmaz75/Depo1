using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMalKabul_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmMalKabul1 frm = new Formlar.frmMalKabul1();
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmStok frm = new Formlar.frmStok();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmMalzemeRepostory frm = new Formlar.frmMalzemeRepostory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmPersonelEkle frm = new Formlar.frmPersonelEkle();
            frm.Show();
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmPersoneller frm = new Formlar.frmPersoneller();
            frm.MdiParent = this;
            frm.Show(); 
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmFirmaEkleme frm = new Formlar.frmFirmaEkleme();
            frm.Show();     
        }

        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmFirmalar frm = new Formlar.frmFirmalar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmDepolar frm = new Formlar.frmDepolar();
            frm.Show();
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmHesapMakinesi frm = new Formlar.frmHesapMakinesi();
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmMalzemeDeposuİşlemleri frm = new Formlar.frmMalzemeDeposuİşlemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmYiyecekDeposuİslemleri frm = new Formlar.frmYiyecekDeposuİslemleri();
            frm.MdiParent= this;
            frm.Show();
        }
    }
}
