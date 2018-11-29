using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_paskaita_2018_11_22.Classes
{
    class Paukstis : Gyvunas
    {
        private string pavadinimas;
        protected bool arPlesrus ;
        public int kojuIlgis;

        public Paukstis(string pavadinimas, bool arPlesrus, int kojuIlgis, string rusis, string spalva, int amzius) : base(pavadinimas,arPlesrus,kojuIlgis)
        {
            this.pavadinimas = pavadinimas;
            this.arPlesrus = arPlesrus;
            this.kojuIlgis = kojuIlgis;
        }
    }
}
