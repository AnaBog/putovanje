using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Putovanje2
{
    public partial class DodajKartuForm : Form
    {
        private Karta karta;
        

        public Karta mojaKarta
        {
            get { return karta; }
            set { karta = value; }
        }
        public DodajKartuForm(Karta postojecaKarta)
        {
            InitializeComponent();

            this.mojaKarta = postojecaKarta;


        }

        private void SacuvajKartu_Click(object sender, EventArgs e)
        {
            string tipKarte = tipKarteBox.SelectedItem.ToString();
            string mestoPolaska = mestoPolBox.Text;
            string mestoDolaska = mestoDolBox.Text;
            int udaljenostGradova = Int32.Parse(rastojanjeBox.Text);
            int duzinaPutovanja = Int32.Parse(duzinaPutBox.Text);
            int masaKofera = Int32.Parse(masaKoferaBox.Text);


            if (tipKarte == "Vozna")
            {
                // VoznaKarta vk = new VoznaKarta();
            }
            else if (tipKarte == "Avionska")
            {

                this.mojaKarta = new AvioKarta(9, mestoPolaska, mestoDolaska, udaljenostGradova, duzinaPutovanja, 5, masaKofera);

                
            }
            

            
        }

        
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DodajKartuForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
