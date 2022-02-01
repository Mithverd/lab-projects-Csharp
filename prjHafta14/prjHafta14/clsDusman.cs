using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public class clsDusman:IDisposable
{
    int _iX;
    int _iY;
    int _iW;
    int _iH;
    int _iResimNo;
    int _iHareketMiktari;
    PictureBox _pbDusman;
    Panel _pnlAlan;

    public clsDusman(int iX, int iY, int iW, int iH, int iHareketMiktari, Panel pnlAlan)
    {
        _iX = iX;
        _iY = iY;
        _iW = iW;
        _iH = iH;
        _iResimNo = 1;
        _iHareketMiktari = iHareketMiktari;
        _pnlAlan = pnlAlan;

        _pbDusman = new PictureBox();
        _pbDusman.Location = new Point(_iX, _iY);
        _pbDusman.Size = new Size(_iW, _iH);
        _pbDusman.SizeMode = PictureBoxSizeMode.StretchImage;
        _pbDusman.Image = Image.FromFile("dusman_1.png");

        pnlAlan.Controls.Add(_pbDusman);
    }

    public void HareketEttir()
    {
        _iResimNo++;
        if (_iResimNo > 4)
            _iResimNo = 1;
        _pbDusman.Image = Image.FromFile("dusman_" + _iResimNo.ToString() + ".png");

        iX--;
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
            _pbDusman.Left = _iX;
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
            _pbDusman.Top = _iY;
        }
    }

    public int iW
    {
        get
        {
            return _iW;
        }
    }

    public int iH
    {
        get
        {
            return _iH;
        }
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
