using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsBankaIslemi
{
    double _dTutar;
    bool _bOnayDurumu;
    int _iTur;
    double _dSonBakiye;

    public clsBankaIslemi(double dTutar, int iTur,ref double dBakiye)
    {
        _dTutar = dTutar;
        _iTur = iTur;
        
        if(_iTur == (int)BankaIslemTuru.ParaGirisi)
        {
            dBakiye += dTutar;
            _bOnayDurumu = true;
        }
        else
        {
            if(dBakiye>=dTutar)
            {
                dBakiye -= dTutar;
                _bOnayDurumu = true;
            }
            else
            {
                _bOnayDurumu = false;
            }
        }

        _dSonBakiye = dBakiye;
    }

    public string Yazdir()
    {
        string sSatir = "";
        sSatir = this.iTur == (int)BankaIslemTuru.ParaGirisi ? "Para Girişi " : "Para Çıkışı ";
        sSatir = sSatir + "Tutar:" + this.dTutar.ToString() + " ";
        sSatir = sSatir + "Son Bakiye:" + this.dSonBakiye.ToString() + " ";
        sSatir = sSatir + "Onay Durumu:" + (this.bOnayDurumu ? "Onaylandı. " : "Reddedildi. ");
        return sSatir;
    }

    public double dTutar
    {
        get
        {
            return _dTutar;
        }
    }

    public bool bOnayDurumu
    {
        get
        {
            return _bOnayDurumu;
        }
    }

    public int iTur
    {
        get
        {
            return _iTur;
        }
    }

    public double dSonBakiye
    {
        get
        {
            return _dSonBakiye;
        }
    }
}