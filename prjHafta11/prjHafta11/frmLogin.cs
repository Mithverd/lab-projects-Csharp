using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta11
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string sTakmaIsim;
            sTakmaIsim = txtTakmaIsim.Text;
            clsKullanici.Olustur(sTakmaIsim);

            frmChat frm = new frmChat();
            frm.Show();
            this.Hide();
        }
    }
}
