using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Putovanje2
{
    public class Put
    {
        string imePutnika;
        string prezimePutnika;
        // int BrojKarata;
        public int novacPutnika { get; set; }

        ArrayList karte = new ArrayList();




        public Put(string imePutnika, string prezimePutnika, int novacPutnika)
        {
            this.imePutnika = imePutnika;
            this.prezimePutnika = prezimePutnika;
            this.novacPutnika = novacPutnika;
        }

        public void IscitajSveKarte()
        {
            Console.WriteLine(karte);
        }

        public void DodajKartu(Karta karta)
        {

            karte.Add(karta);
            //napravi listu
            //dodaje u listu kupljenih karata ili vraca gresku ako putnik nema vise novca, proveriti koliko putnik ima novca, ukoliko ima novca, kupiti kartu, ako nema novca, error
        }

        public void NajskupljaKarta()
        {
            //sortiraj listu


        }

        public void Ispravnost(string mestoPolaska, string mestoDolaska)
        {
            //proveri da li je MestoPolaska = MestoDolaska, ako jeste, karta je neispravna



            if (mestoPolaska == mestoDolaska)
            {
                Console.WriteLine("\nDoslo je do greske. Odaberite drugacije mesto polaska i/ili mesto dolaska.");
            }


        }
    }
}
