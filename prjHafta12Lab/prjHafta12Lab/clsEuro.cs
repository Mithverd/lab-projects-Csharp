using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsEuro : clsDoviz
{
    public clsEuro(double dAdet)
    {
        _dAdet = dAdet;
    }

    public static implicit operator clsLira(clsEuro euro)
    {
        return new clsLira(euro.dAdet * clsPariteler._dPariteEuro);
    }
}
