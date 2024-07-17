using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_04_Boguszewski_Dominik
{
    public partial class Wynik : Form
    {
        int wynik;
        public Wynik(int wyn)
        {
            InitializeComponent();
            this.wynik = wyn;
        }

        private void Wynik_Load(object sender, EventArgs e)
        {
            Bitmap Obrazek;
            string link1 = "szczescie.png";
            string link2 = "smutek.png";

            if (this.wynik >= 3) 
            {
                label1.Text = "Jesteś szczęśliwy!";
                Obrazek = new Bitmap(link1);
                Obraz.Image = Obrazek;
            } 
            else
            {
                label1.Text = "Jesteś smutny!";
                Obrazek = new Bitmap(link2);
                Obraz.Image = Obrazek;
            }

        }
    }
}
