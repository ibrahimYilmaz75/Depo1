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
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }
        YilmazKafeEntities3 db = new YilmazKafeEntities3();
        void listele()
        {
            var deger = from x in db.tblPersonel
                        select new
                        {
                            x.ID,
                            x.AdiSoyadi,
                            x.Telefon,
                            x.Email,
                            x.Adres
                        };
            gridControl1.DataSource = deger.ToList();
        }

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAdiSoyadi.Text = gridView1.GetFocusedRowCellValue("AdiSoyadi").ToString();
            txtTel.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
            txtAdress.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtId.Text);
                var deger = db.tblPersonel.Find(x);
                deger.AdiSoyadi = txtAdiSoyadi.Text;
                deger.Telefon = txtTel.Text;
                deger.Email = txtMail.Text;
                deger.Adres = txtAdress.Text;
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
            var deger = db.tblPersonel.Find(x);
            db.tblPersonel.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show(" Silme İşlemi Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
            txtId.Text = "";
        }
    }
}
