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
    public partial class frmFirmaEkleme : Form
    {
        public frmFirmaEkleme()
        {
            InitializeComponent();
        }
        YilmazKafeEntities3 db = new YilmazKafeEntities3();
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            TblFirmalar t = new TblFirmalar();
            t.isim = txtAdi.Text;
            t.sektor = txtSektor.Text;
            t.telefon = txtTel.Text;
            t.email = txtEmail.Text;
            t.adres = txtAdres.Text;
            db.TblFirmalar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Firma Başarıyla Eklendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalar();

            txtAdi.Text = "";
            txtSektor.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
        }

        private void firmalar()
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
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSektor.Text = "";
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
