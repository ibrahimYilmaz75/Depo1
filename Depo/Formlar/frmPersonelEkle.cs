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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }
        YilmazKafeEntities3 db = new YilmazKafeEntities3();
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            tblPersonel t = new tblPersonel();
            t.AdiSoyadi = txtAdi.Text;
            t.Email = txtEmail.Text;
            t.Telefon = txtTel.Text;
            t.Adres = txtAdres.Text;
           
            db.tblPersonel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Personel Başarıyla Eklendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            personeller();

            txtAdi.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
        }

        private void personeller()
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
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
