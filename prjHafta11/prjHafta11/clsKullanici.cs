using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

public static class clsKullanici
{
    public static string _sTakmaIsim;
    public static List<clsMesaj> _lMesajlar = new List<clsMesaj>();
    public static DateTime _dtSonMesajAlmaZamani;

    public static void Olustur(string sTakmaIsim)
    {
        _sTakmaIsim = sTakmaIsim;
        MesajlariOku();
    }

    public static void MesajlariOku()
    {
        string[] sVeri;
        clsMesaj mesaj;
        FileStream fs = new FileStream("mesajlar.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        _lMesajlar.Clear();
        while (!sr.EndOfStream)
        {
            sVeri = sr.ReadLine().Split('-');
            if (sVeri.Length == 4)
            {
                mesaj = new clsMesaj(sVeri[0], sVeri[1], sVeri[2], DateTime.Parse(sVeri[3]));
                _lMesajlar.Add(mesaj);

                _dtSonMesajAlmaZamani = mesaj.dtGonderimZamani;
            }
        }

        sr.Close();
        fs.Close();
    }

    public static void MesajlariYazdir(TextBox txtMesajlar)
    {
        StringBuilder sMesajlar = new StringBuilder();
        MesajlariOku();
        foreach (clsMesaj mesaj in _lMesajlar)
        {
            if (mesaj.sAliciTakmaIsim == _sTakmaIsim || mesaj.sGonderenTakmaIsim == _sTakmaIsim)
            {
                sMesajlar.AppendLine(mesaj.sGonderenTakmaIsim + ":" + mesaj.sMesajMetni);
                sMesajlar.AppendLine(mesaj.dtGonderimZamani.ToShortDateString() + " " + mesaj.dtGonderimZamani.ToShortTimeString());
            }
        }

        txtMesajlar.Text = sMesajlar.ToString();
    }


    public static void MesajGonder(string sMesajMetni,string sAliciTakmaIsim)
    {
        FileStream fs = new FileStream("mesajlar.txt", FileMode.Append, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine(_sTakmaIsim + "-" + 
            sAliciTakmaIsim + "-" + 
            sMesajMetni + "-" + 
            DateTime.Now.ToShortDateString() + 
            " " + DateTime.Now.ToShortTimeString());
        sw.Close();
        fs.Close();
    }
}
