using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putovanje2
{
    public class VoznaKarta : Karta
    {
        protected int cenaPokm;

        public VoznaKarta(string mestoPolaska, string mestoDolaska, int udaljenostGradova, int duzinaPutovanja, int cenaPokm) : base(mestoPolaska, mestoDolaska, udaljenostGradova, duzinaPutovanja)
        {
            this.cenaPokm = cenaPokm;
        }

        public override int CenaKarte()
        {
            return udaljenostGradova * this.cenaPokm;
        }
    }
}
