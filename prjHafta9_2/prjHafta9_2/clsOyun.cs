using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class clsOyun
{
    int _iAlanW, _iAlanH;
    Timer _timer;
    clsTop _top;

    public clsOyun(Panel pnl)
    {
        _iAlanW = pnl.Width;
        _iAlanH = pnl.Height;
        _timer = new Timer();
        _timer.Interval = 1;
        _timer.Enabled = false;
        _timer.Tick += _timer_Tick;
        _top = new clsTop(541, 583, 45, pnl);
    }

    public void Baslat()
    {
        _timer.Enabled = true;
    }

    private void HareketEttir()
    {
        int iYeniX, iYeniY, iYeniAci;

        iYeniAci = iKontrol();
        _top.iAci = iYeniAci;
        iYeniX = _top.iX;
        iYeniY = _top.iY;

        switch (_top.iAci)
        {
            case 45:
                iYeniX += 1;
                iYeniY -= 1;
                break;
            case 135:
                iYeniX -= 1;
                iYeniY -= 1;
                break;
            case 225:
                iYeniX -= 1;
                iYeniY += 1;
                break;
            case 315:
                iYeniX += 1;
                iYeniY += 1;
                break;
        }

        _top.iX = iYeniX;
        _top.iY = iYeniY;
    }

    private int iKontrol()
    {
        int iYeniX, iYeniY, iYeniAci;
        iYeniAci = _top.iAci;
        iYeniX = _top.iX;
        iYeniY = _top.iY;
        switch (iYeniAci)
        {
            case 45:
                iYeniX += 1;
                iYeniY -= 1;
                break;
            case 135:
                iYeniX -= 1;
                iYeniY -= 1;
                break;
            case 225:
                iYeniX -= 1;
                iYeniY += 1;
                break;
            case 315:
                iYeniX += 1;
                iYeniY += 1;
                break;
        }
        
        if (iYeniX < 0
            || iYeniX + _top.iW > _iAlanW
            || iYeniY < 0
            || iYeniY + _top.iW > _iAlanH
           )
        {
            iYeniAci += 90;
            iYeniAci = iYeniAci % 360;
        }
        return iYeniAci;
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
        HareketEttir();
    }
}
