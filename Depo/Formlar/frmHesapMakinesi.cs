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
    public partial class frmHesapMakinesi : Form
    {
        bool opdDurum = false;
        double sonuc = 0;
        string opt = "";
        public frmHesapMakinesi()
        {
            InitializeComponent();
        }

        private void rakamOlay(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || opdDurum)
                txtSonuc.Clear();
            opdDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void frmHesapMakinesi_Load(object sender, EventArgs e)
        {

        }

        private void optHesap(object sender, EventArgs e)
        {

            opdDurum= true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            lblSonuc.Text = lblSonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break; 
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break; 
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break; 
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break; 
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSonuc.Text= "0";
            lblSonuc.Text = "";
            opt = "";
            sonuc = 0;
            opdDurum = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            opdDurum= true;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text=="0")
            {
                txtSonuc.Text = "0";
            }
            else if (opdDurum)
            {
                txtSonuc.Text = "0";
            }
            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ","; 
            }
            opdDurum= false;
        }
    }
}
