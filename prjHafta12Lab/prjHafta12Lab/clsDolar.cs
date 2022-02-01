using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsDolar : clsDoviz
{
    public clsDolar(double dAdet)
    {
        _dAdet = dAdet;
    }
    
    public static implicit operator clsLira(clsDolar dolar)
    {
        return new clsLira(dolar.dAdet * clsPariteler._dPariteDolar);
    }
}
