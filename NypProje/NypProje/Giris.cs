using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NypProje
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(txtID.Text=="admin"&&txtSifre.Text=="1")
            {
                frmYonetici form = new frmYonetici();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
                txtID.Clear();  
                txtSifre.Clear();
            }

        }
    }
}
