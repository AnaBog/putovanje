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
    public partial class PutovanjeForm : Form
    {
        private Put Putovanje;
        public Put putovanje
        {
            get { return Putovanje; }
            set { Putovanje = value; }
        }

        public PutovanjeForm()
        {
            InitializeComponent();
        }

        private void Dodaj_Kartu(object sender, EventArgs e)
        {           
            using (DodajKartuForm dodaj = new DodajKartuForm(null))
            {
                if (dodaj.ShowDialog() == DialogResult.OK)
                    ListaKarata.Items.Add(dodaj.mojaKarta);
            }
        }

        private void Azuriraj_Kartu(object sender, EventArgs e)
        {




            using (DodajKartuForm dodaj = new DodajKartuForm(ListaKarata.Items[ListaKarata.SelectedIndex]))
            {
                if (dodaj.ShowDialog() == DialogResult.OK)
                    ListaKarata.Items.Add(dodaj.mojaKarta.mestoPolaska + " - " + dodaj.mojaKarta.mestoDolaska);
            }

        }

        private void Obrisi_Kartu(object sender, EventArgs e)
        {

            using (Potvrda okej = new Potvrda())
            {
                if (okej.ShowDialog() == DialogResult.OK)
                    ListaKarata.Items.RemoveAt(ListaKarata.SelectedIndex);
            }

        }

        private void PutovanjeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
