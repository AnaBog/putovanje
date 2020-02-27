using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putovanje2
{
    public class AvioKarta : Karta
    {
        protected int cenaPrevoza;

        protected int cenaDoplate;

        protected int doplataZaPrtljag;

        protected int MasaKofera;
        protected int masaKofera

        {
            get
            {
                return MasaKofera;
            }
            set
            {
                MasaKofera = value;
            }
        }



        public AvioKarta(int cenaPrevoza, string mestoPolaska, string mestoDolaska, int udaljenostGradova, int duzinaPutovanja, int doplataZaPrtljag, int masaKofera) : base(mestoPolaska, mestoDolaska, udaljenostGradova, duzinaPutovanja)
        {


            this.cenaPrevoza = cenaPrevoza;
            this.doplataZaPrtljag = doplataZaPrtljag;
            this.masaKofera = masaKofera;

        }

        public override int CenaKarte()
        {


            if (masaKofera > 10)
            {
                cenaDoplate = (masaKofera - 10) * doplataZaPrtljag;
            }
            else
            {
                cenaDoplate = 0;
            }



            return cenaPrevoza + cenaDoplate; // cena prevoza + cena doplate za prtljag, ako tezina prelazi 10 kg, doplata je po kilogramu prekoracenja
        }
    }
}
