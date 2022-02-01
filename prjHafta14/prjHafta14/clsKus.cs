using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public class clsKus
{ 
    int _iX;
    int _iY;
    int _iW;
    int _iH;
    int _iHareketMiktari;
    int _iResimNo;
    PictureBox _pbKus;
    Panel _pnlAlan;
    Timer _timer;

    public clsKus(int iX,int iY, int iW, int iH, int iHareketMiktari, Panel pnlAlan)
    {
        _iX = iX;
        _iY = iY;
        _iW = iW;
        _iH = iH;
        _iHareketMiktari = iHareketMiktari;
        _iResimNo = 1;
        _pnlAlan = pnlAlan;

        _pbKus = new PictureBox();
        _pbKus.Location = new Point(_iX, _iY);
        _pbKus.Size = new Size(_iW, _iH);
        _pbKus.Image = Image.FromFile("kus_1.png");
        _pbKus.SizeMode = PictureBoxSizeMode.StretchImage;
        pnlAlan.Controls.Add(_pbKus);

        _timer = new Timer();
        _timer.Interval = 50;
        _timer.Enabled = true;
        _timer.Tick += _timer_Tick;
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
        _iResimNo++;
        if (_iResimNo > 8)
            _iResimNo = 1;
        _pbKus.Image = Image.FromFile("kus_"+ _iResimNo.ToString() +".png");
    }

    public void HareketEttir(int iYon)
    {
        switch (iYon)
        {
            case (int)Yonler.Asagi:
                if (_iY+ _iH<=_pnlAlan.Height)
                {
                    iY += _iHareketMiktari;
                }
                break;
            case (int)Yonler.Yukari:
                if (_iY- _iHareketMiktari>=0)
                {
                    iY -= _iHareketMiktari;
                }
                break;
        }
    }

    public static bool operator *(clsKus kus,clsDusman dusman)
    {
        Rectangle recdusman, reckus;
        recdusman = new Rectangle(dusman.iX, dusman.iY, dusman.iW, dusman.iH);
        reckus = new Rectangle(kus.iX, kus.iY, kus.iW, kus.iH);

        return recdusman.IntersectsWith(reckus);
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
            _pbKus.Left = _iX;
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
            _pbKus.Top = _iY;
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
}
