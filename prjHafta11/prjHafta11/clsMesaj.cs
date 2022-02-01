using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsMesaj
{
    string _sGonderenTakmaIsim;
    string _sAliciTakmaIsim;
    string _sMesajMetni;
    DateTime _dtGonderimZamani;

    public clsMesaj(string sGonderenTakmaIsim, string sAliciTakmaIsim, string sMesajMetni, DateTime dtGonderimZamani)
    {
        this._sGonderenTakmaIsim = sGonderenTakmaIsim;
        this._sAliciTakmaIsim = sAliciTakmaIsim;
        this._sMesajMetni = sMesajMetni;
        this._dtGonderimZamani = dtGonderimZamani;
    }

    public string sGonderenTakmaIsim
    {
        get
        {
            return _sGonderenTakmaIsim;
        }
    }

    public string sAliciTakmaIsim
    {
        get
        {
            return _sAliciTakmaIsim;
        }
    }

    public string sMesajMetni
    {
        get
        {
            return _sMesajMetni;
        }
    }

    public DateTime dtGonderimZamani
    {
        get
        {
            return _dtGonderimZamani;
        }
    }
}
