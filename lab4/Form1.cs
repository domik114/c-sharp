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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wynik = 0;

            if (radioButton1.Checked)
                wynik++;
            if (radioButton4.Checked)
                wynik++;
            if (radioButton6.Checked)
                wynik++;
            if (radioButton8.Checked)
                wynik++;
            if (radioButton10.Checked)
                wynik++;

            Wynik okno = new Wynik(wynik);
            okno.Show();
        }
    }
}
