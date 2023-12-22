using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo.Formlar
{
    public partial class frmDepolar : Form
    {
        public frmDepolar()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            Formlar.frmMalzemeDeposuİşlemleri frm = new Formlar.frmMalzemeDeposuİşlemleri(); 
            frm.Show();
            this.Hide();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
