using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsLira : clsDoviz
{
    public clsLira(double dAdet)
    {
        _dAdet = dAdet;
    }

    public static clsLira operator +(clsLira lira1, clsLira lira2)
    {
        return new clsLira(lira1._dAdet + lira2._dAdet);
    }

    public string Yazdir()
    {
        return _dAdet.ToString() + " Türk Lirası";
    }
}
