using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_paskaita_2018_11_22.Classes
{
    class Gyvunas
    {
        private string rusis;
        protected string spalva;
        public int amzius;

        public Gyvunas(string rusis, string spalva, int amzius)
        {
            this.rusis = rusis;
            this.spalva = spalva;
            this.amzius = amzius;
        }
    }
}
