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
    public partial class frmFirmalar : Form
    {
        public frmFirmalar()
        {
            InitializeComponent();
        }
        YilmazKafeEntities3 db = new YilmazKafeEntities3();
        void listele()
        {

            var deger = from x in db.TblFirmalar
                        select new
                        {
                            x.ID,
                            x.isim,
                            x.sektor,
                            x.telefon,
                            x.email,
                            x.adres
                        };
            gridControl1.DataSource = deger.ToList();
        }
        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAdi.Text = gridView1.GetFocusedRowCellValue("isim").ToString();
            txtAdres.Text = gridView1.GetFocusedRowCellValue("adres").ToString();
            txtSektor.Text = gridView1.GetFocusedRowCellValue("sektor").ToString();
            txtTel.Text = gridView1.GetFocusedRowCellValue("telefon").ToString();
            txtEmail.Text = gridView1.GetFocusedRowCellValue("email").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtId.Text);
                var deger = db.TblFirmalar.Find(x);
                deger.isim = txtAdi.Text;
                deger.sektor = txtSektor.Text;
                deger.telefon = txtTel.Text;
                deger.email = txtEmail.Text;
                deger.adres = txtAdres.Text;
                db.SaveChanges();
                XtraMessageBox.Show(" Güncelleme İşlemi Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen Gerekli Yerleri Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            int x = int.Parse(txtId.Text);
            var deger = db.TblFirmalar.Find(x);
            db.TblFirmalar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show(" Silme İşlemi Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
            txtId.Text = "";
        }
    }
}
