using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta12Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            object oDoviz1 = null, oDoviz2 = null;
            clsLira oSonuc=null;
            double dAdet1, dPariteDolar,  dAdet2,dPariteEuro;

            dAdet1 = double.Parse(txtAdet1.Text);
            dAdet2 = double.Parse(txtAdet2.Text);

            dPariteDolar = double.Parse(txtPariteDolar.Text);
            dPariteEuro = double.Parse(txtPariteEuro.Text);

            clsPariteler._dPariteDolar = dPariteDolar;
            clsPariteler._dPariteEuro = dPariteEuro;

            switch (cbDoviz1.SelectedIndex)
            {
                case 0: //dolar
                    oDoviz1 = new clsDolar(dAdet1);
                    break;
                case 1: //euro
                    oDoviz1 = new clsEuro(dAdet1);
                    break;
                case 2: //turk lirasi
                    oDoviz1 = new clsLira(dAdet1);
                    break;
            }

            switch (cbDoviz2.SelectedIndex)
            {
                case 0: //dolar
                    oDoviz2 = new clsDolar(dAdet2);
                    break;
                case 1: //euro
                    oDoviz2 = new clsEuro(dAdet2);
                    break;
                case 2: //turk lirasi
                    oDoviz2 = new clsLira(dAdet2);
                    break;
            }

            oSonuc = (oDoviz1 is clsDolar ? (clsDolar)oDoviz1 : (oDoviz1 is clsEuro ? (clsEuro)oDoviz1 : (clsLira)oDoviz1)) +
                     (oDoviz2 is clsDolar ? (clsDolar)oDoviz2 : (oDoviz2 is clsEuro ? (clsEuro)oDoviz2 : (clsLira)oDoviz2));
            
            lblSonuc.Text = oSonuc.Yazdir();

        }
    }
}
