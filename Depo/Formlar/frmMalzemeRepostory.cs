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
    public partial class frmMalzemeRepostory : Form
    {
        public frmMalzemeRepostory()
        {
            InitializeComponent();
        }
        YilmazKafeEntities3 db = new YilmazKafeEntities3();
        private void frmMalzemeRepostory_Load(object sender, EventArgs e)
        {
            listele();
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
          
        }

        private void listele()
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

        

    }
}
