using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIslemGecmisiniGoster_Click(object sender, EventArgs e)
        {
            clsBankaHesabi hesap = new clsBankaHesabi(20,lblSonBakiye,lbKayitlar);
            hesap.IslemGecmisiniGoruntule();
        }
    }
}
