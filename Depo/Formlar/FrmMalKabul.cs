using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Depo.Entity;
using DevExpress.XtraEditors;

namespace Depo.Formlar
{
    public partial class FrmMalKabul : Form
    {
        public FrmMalKabul()
        {
            InitializeComponent();
        }
        YilmazKafeEntities3 db = new YilmazKafeEntities3();
       

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbFirma.Text = "";
            cbPersonel.Text = "";
            txtMiktar.Text = "";
            txtUrun.Text = "";
            timeTarih.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMalKabul_Load(object sender, EventArgs e)
        {
            var item = from x in db.tblPersonel
                       select new
                       {
                           x.ID,
                           x.AdiSoyadi
                       };
            cbPersonel.DataSource = item.ToList();
            cbPersonel.ValueMember = "ID";
            cbPersonel.DisplayMember = "AdiSoyadi";

            var item1 = from x in db.TblFirmalar
                       select new
                       {
                           x.ID,
                           x.isim
                       };
            cbFirma.DataSource = item1.ToList();
            cbFirma.ValueMember = "ID";
            cbFirma.DisplayMember = "isim";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            tblYiyecek t = new tblYiyecek();
            t.personel = int.Parse(cbPersonel.SelectedValue.ToString());
            t.firma = int.Parse(cbFirma.SelectedValue.ToString());
            t.urun = txtUrun.Text;
            t.fiyat = txtFiyat.Text;
            t.miktar = int.Parse(txtMiktar.Text);
            t.tarih = DateTime.Parse(timeTarih.Text);
            db.tblYiyecek.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Ürün Başarıyla Eklendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            yiyecek();
            cbFirma.Text = "";
            cbPersonel.Text = "";
            txtMiktar.Text = "";
            txtUrun.Text = "";
            timeTarih.Text = "";

        }

        private void yiyecek()
        {
            var deger = from x in db.tblYiyecek
                        select new
                        {
                            x.ID,
                            x.tblPersonel,
                            x.TblFirmalar,
                            x.fiyat,
                            x.miktar,
                           x.tarih
                        };
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
