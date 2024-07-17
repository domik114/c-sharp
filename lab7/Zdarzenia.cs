using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_07
{
    class Zdarzenia
    {
        public delegate void Wypadek(int i);
        public event Wypadek OglosWypadek;

        public void OgloszenieWypadku(int i)
        {
            if (OglosWypadek != null)
                OglosWypadek(i);
        }

        public void AnulujSubskrypcje(int anuluj)
        {
            for (int i = 0; i < anuluj; i++)
                OglosWypadek -= OglosWypadek;
        }
    }
}
