using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsPersonel
{
    string _sAdi;
    int _iCalismaSuresi;
    string _sResimYolu;
    double _dMaasi;

    public clsPersonel()
    {
        _sAdi = "";
        _iCalismaSuresi = 0;
        _sResimYolu = "";
        _dMaasi = 0;
    }

    public string sAdi
    {
        get
        {
            return _sAdi;
        }
        set
        {
            _sAdi = value;
        }
    }

    public int iCalismaSuresi
    {
        get
        {
            return _iCalismaSuresi;
        }
        set
        {
            _iCalismaSuresi = value;
        }
    }

    public string sResimYolu
    {
        get
        {
            return _sResimYolu;
        }
        set
        {
            _sResimYolu = value;
        }
    }

    public double dMaasi
    {
        get
        {
            return _dMaasi;
        }
        set
        {
            _dMaasi = value;
        }
    }

    public double KidemTazminatiHesapla()
    {
        double dSonuc;
        dSonuc = dMaasi * iCalismaSuresi;
        return dSonuc;
    }

    public string Yazdir()
    {
        string sSonuc = "";
        sSonuc = _sAdi + 
            " Çalışma Süresi "+ _iCalismaSuresi.ToString() +
            " yıl Resim Yolu "+ _sResimYolu +
            " Maaşı " + _dMaasi.ToString() + 
            " Alacağı Kıdem Tazminatı " + KidemTazminatiHesapla().ToString();
        return sSonuc;
    }
}
