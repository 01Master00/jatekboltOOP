using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatekboltOOP
{
    internal class Jatek
    {
        private string cim;
        private string kategoria;
        private int ar;

        public Jatek(string cim, string kategoria, int ar)
        {
            this.cim = cim;
            this.kategoria = kategoria;
            this.ar = ar;
        }

        public string Cim { get => cim; set => cim = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public int Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            return $"{this.cim}: {this.kategoria}, {this.ar}Ft";
        }

    }
}
