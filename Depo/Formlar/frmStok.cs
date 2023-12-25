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

      
    }
}
