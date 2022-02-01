using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

public class clsBankaHesabi
{
    double _dBakiye;
    List<clsBankaIslemi> _islemler= new List<clsBankaIslemi>();
    Label _lblBakiye;
    ListBox _lbIslemler;

    public clsBankaHesabi(double dBakiye, Label lblBakiye, ListBox lbIslemler)
    {
        string[] sData;
        clsBankaIslemi islem;
        _dBakiye = dBakiye;
        _lblBakiye = lblBakiye;
        _lbIslemler = lbIslemler;

        FileStream fs = new FileStream("bankakayitlari.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        while(!sr.EndOfStream)
        {
            sData=sr.ReadLine().Split('*');
            if(sData.Length==2)
            {
                islem = new clsBankaIslemi(double.Parse(sData[0]), int.Parse(sData[1]), ref _dBakiye);
                _islemler.Add(islem);
            }
        }

        sr.Close();
        fs.Close();
    }

    public void IslemGecmisiniGoruntule()
    {
        foreach (clsBankaIslemi islem in _islemler)
        {
            _lbIslemler.Items.Add(islem.Yazdir());
        }

        _lblBakiye.Text = _dBakiye.ToString();
    }
}