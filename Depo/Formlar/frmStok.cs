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
    public partial class frmStok : Form
    {
        public frmStok()
        {
            InitializeComponent();
        }
        YilmazKafeEntities3 db = new YilmazKafeEntities3();
       

        private void frmStok_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtPersonel.Text = gridView1.GetFocusedRowCellValue("personel").ToString();
            txtFirma.Text = gridView1.GetFocusedRowCellValue("firma").ToString();
            txtUrun.Text = gridView1.GetFocusedRowCellValue("urun").ToString();
            txtMiktar.Text = gridView1.GetFocusedRowCellValue("miktar").ToString();
            txtFiyat.Text = gridView1.GetFocusedRowCellValue("fiyat").ToString();
            dtTarih.Text = gridView1.GetFocusedRowCellValue("tarih").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtId.Text);
                var deger = db.tblYiyecek.Find(x);
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

        private void listele()
        {
            var urunler = from x in db.tblYiyecek
                          select new
                          {
                              x.ID,
                              x.firma,
                              x.personel,
                              x.urun,
                              x.miktar,
                              x.fiyat,
                              x.tarih
                          };
            gridControl1.DataSource = urunler.ToList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var deger = db.tblYiyecek.Find(x);
            db.tblYiyecek.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show(" Silme İşlemi Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }
    }
}
