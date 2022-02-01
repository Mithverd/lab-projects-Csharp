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
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clsKullanici.MesajlariYazdir(txtMesajlar);
        }

        private void frmChat_KeyUp(object sender, KeyEventArgs e)
        {
            string sMesajMetni;
            if (e.KeyCode == Keys.Enter)
            {
                sMesajMetni = txtMesaj.Text;
                if (sMesajMetni != "")
                {
                    clsKullanici.MesajGonder(sMesajMetni, clsKullanici._sTakmaIsim=="ahmet" ? "burak" : "ahmet");
                    txtMesaj.Text = "";
                }
            }
        }
    }
}
