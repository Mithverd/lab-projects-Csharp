using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjYLHafta7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyayiOku_Click(object sender, EventArgs e)
        {
            string sSatir = "";
            string[] sDegerler;
            FileStream fs = new FileStream("personeller.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            clsPersonel personel;
            while (!sr.EndOfStream)
            {
                sSatir = sr.ReadLine();
                sDegerler = sSatir.Split(',');

                if (sDegerler.Length < 4)
                    continue;

                personel = new clsPersonel();
                personel.sAdi = sDegerler[0];
                personel.iCalismaSuresi = int.Parse(sDegerler[1]);
                personel.sResimYolu = sDegerler[2];
                personel.dMaasi = double.Parse(sDegerler[3]);

                lbPersoneller.Items.Add(personel.Yazdir());
            }

            sr.Close();
            fs.Close();
        }
    }
}
