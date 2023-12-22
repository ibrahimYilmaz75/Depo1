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
    public partial class frmMalzemeDeposuİşlemleri : Form
    {
        public frmMalzemeDeposuİşlemleri()
        {
            InitializeComponent();
        }
        YilmazKafeEntities3 db = new YilmazKafeEntities3();
        void listele()
        {
            var x = from item in db.tblMalzeme
                    select new
                    {
                        item.ID,
                        item.personel,
                        item.firma,
                        item.urun,
                        item.miktar,
                        item.fiyat,
                        item.tarih
                    };
            gridControl1.DataSource = x.ToList();

        }
        private void frmMalzemeDeposuİşlemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            cbPersonel.Text = gridView1.GetFocusedRowCellValue("personel").ToString();
            cbFirma.Text = gridView1.GetFocusedRowCellValue("firma").ToString();
            txtUrun.Text = gridView1.GetFocusedRowCellValue("urun").ToString();
            txtMiktar.Text = gridView1.GetFocusedRowCellValue("miktar").ToString();
            txtFiyat.Text = gridView1.GetFocusedRowCellValue("fiyat").ToString();
            dtTarih.Text = gridView1.GetFocusedRowCellValue("tarih").ToString();
        }

        private void btnEksiltme_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtId.Text);
                var deger = db.tblMalzeme.Find(x);
                deger.miktar= int.Parse(txtMiktar.Text);
                db.SaveChanges();
                XtraMessageBox.Show(" Güncelleme İşlemi Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen Gerekli Yerleri Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txturun_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var deger = db.tblMalzeme.Find(x);
            db.tblMalzeme.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show(" Silme İşlemi Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtId.Text);
                var deger = db.tblMalzeme.Find(x);
                //deger.firma = int.Parse(cbFirma.Text);
                //deger.personel = int.Parse(cbPersonel.Text);
                deger.urun = txtUrun.Text;
                deger.miktar = int.Parse(txtMiktar.Text);
                deger.fiyat = txtFiyat.Text;
                deger.tarih = DateTime.Parse(dtTarih.Text);
                db.SaveChanges();
                XtraMessageBox.Show(" Güncelleme İşlemi Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen Gerekli Yerleri Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
