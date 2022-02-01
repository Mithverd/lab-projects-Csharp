using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

public class clsOyun
{
    int _iPuan;
    int _YeniDusmanGelmeSuresi;
    List<object> _nesneler = new List<object>();
    Label _lblPuan;
    Panel _pnlAlan;
    Timer _timer;
    public clsOyun(Panel pnlAlan,Form frm,Label lblPuan)
    {
        clsKus kus;
        _iPuan = 0;
        _lblPuan = lblPuan;
        _pnlAlan = pnlAlan;

        _timer = new Timer();
        _timer.Interval = 10;
        _timer.Enabled = true;
        _timer.Tick += _timer_Tick;

        kus = new clsKus(100, pnlAlan.Height/ 2, 70, 49, 5, pnlAlan);

        _nesneler.Add(kus);

        frm.KeyPress += Frm_KeyPress;
    }

    private void Frm_KeyPress(object sender, KeyPressEventArgs e)
    {
       switch(e.KeyChar)
        {
            case 'w':
            case 'W':
                (_nesneler[0] as clsKus).HareketEttir((int)Yonler.Yukari);
                break;
            case 's':
            case 'S':
                (_nesneler[0] as clsKus).HareketEttir((int)Yonler.Asagi);
                break;
        }
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
        int iSayac = 0;
        clsDusman dusman;
        Random rnd = new Random();

        for (iSayac = 1; iSayac < _nesneler.Count; iSayac++)
        {
            dusman = (clsDusman)_nesneler[iSayac];
            if (dusman != null)
            {
                dusman.HareketEttir();

                if (((clsKus)_nesneler[0])*dusman)
                {
                    _timer.Enabled = false;
                    MessageBox.Show("Oyun bitti :(");
                    break;
                }
                else if (dusman.iX+dusman.iW <=0)
                {
                    ((clsDusman)_nesneler[iSayac]).Dispose();
                    _nesneler[iSayac] = null;
                    _iPuan += 10;
                    _lblPuan.Text = _iPuan.ToString();
                }
            }
        }

        _YeniDusmanGelmeSuresi--;
        if (_YeniDusmanGelmeSuresi <= 0)
        {
            _YeniDusmanGelmeSuresi = rnd.Next(5*30);
            dusman = new clsDusman(_pnlAlan.Width, rnd.Next(_pnlAlan.Height - 50), 50,65,5,_pnlAlan);
            _nesneler.Add(dusman);
        }
    }
}
