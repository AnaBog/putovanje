using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putovanje2
{
    public abstract class Karta
    {
        private string MestoPolaska;

        public string mestoPolaska
        {
            get { return MestoPolaska; }
            set { MestoPolaska = value; }
        }

        private string MestoDolaska;
        public string mestoDolaska
        {
            get { return MestoDolaska; }
            set { MestoDolaska = value; }
        }

        protected int udaljenostGradova;
        protected int duzinaPutovanja;

        protected Karta(string mestoPolaska, string mestoDolaska, int udaljenostGradova, int duzinaPutovanja)
        {
            this.mestoPolaska = mestoPolaska; //varijabla mozda ne moze isto da se zove, ovde ima get;set
            this.mestoDolaska = mestoDolaska;
            this.udaljenostGradova = udaljenostGradova;
            this.duzinaPutovanja = duzinaPutovanja;
        }


        public void Print()
        {
            Console.WriteLine($"\nVasa karta od mesta {mestoPolaska} do mesta {mestoDolaska}, u trajanju od {duzinaPutovanja}h, razdaljine {udaljenostGradova}km. ");
        }

        //abstract CenaKarte metoda 
        abstract public int CenaKarte();
    }
}
