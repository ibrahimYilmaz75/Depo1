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
    public partial class frmMalzemeKabul : Form
    {
        public frmMalzemeKabul()
        {
            InitializeComponent();
        }
        YilmazKafeEntities3 db = new YilmazKafeEntities3();
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            tblMalzeme t = new tblMalzeme();
            t.personel = int.Parse(cbPersonel.SelectedValue.ToString());
            t.firma = int.Parse(cbFirma.SelectedValue.ToString());
            t.urun = txtUrun.Text;
            t.fiyat = txtFiyat.Text;
            t.miktar = int.Parse(txtMiktar.Text);
            t.tarih = DateTime.Parse(dtTarih.Text);
            db.tblMalzeme.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Ürün Başarıyla Eklendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            malzeme();
            cbFirma.Text = "";
            cbPersonel.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
            txtUrun.Text = "";
            dtTarih.Text = "";
        }
        void malzeme()
        {
            var item = from x in db.tblMalzeme
                       select new
                       {
                           x.ID,
                           x.personel,
                           x.firma,
                           x.urun,
                           x.fiyat,
                           x.miktar,
                           x.tarih
                       };
        }

        private void frmMalzemeKabul_Load(object sender, EventArgs e)
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
    }
}
