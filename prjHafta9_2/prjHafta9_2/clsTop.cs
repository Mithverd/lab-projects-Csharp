using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
public class clsTop
{
    int _iX;
    int _iY;
    int _iW =  50;
    int _iAci;
    int _iHareketMiktari;
    Label _lbl;

    public clsTop(int iX,int iY, int iAci, Panel pnl)
    {
        _iX = iX;
        _iY = iY;
        _iAci = iAci;
        _iHareketMiktari = 1;
        _lbl = new Label();
        _lbl.AutoSize = false;
        _lbl.BorderStyle = BorderStyle.FixedSingle;
        _lbl.Width = _iW;
        _lbl.Height = _iW;
        _lbl.Text = "";
        _lbl.Location = new Point(_iX, _iY);
        pnl.Controls.Add(_lbl);
    }

    public int iX
    {
        get
        {
            return _iX;
        }
        set
        {
            _iX = value;
            _lbl.Location = new Point(_iX, _iY);
        }
    }

    public int iY
    {
        get
        {
            return _iY;
        }
        set
        {
            _iY = value;
            _lbl.Location = new Point(_iX, _iY);
        }
    }

    public int iW
    {
        get
        {
            return _iW;
        }
        set
        {
            _iW = value;
        }
    }

    public int iAci
    {
        get
        {
            return _iAci;
        }
        set
        {
            _iAci = value;
        }
    }
}
