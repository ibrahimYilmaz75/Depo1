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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_kullaniciAdi.Text == "" || txt_Sifre.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if (txt_kullaniciAdi.Text == "admin" && txt_Sifre.Text == "123")
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");

            }
        }
    }
}
