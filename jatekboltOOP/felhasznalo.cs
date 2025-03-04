using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatekboltOOP
{
    internal class felhasznalo
    {
        private string nev;
        private int egyenleg;
        private List<Jatek> konyvtar;

        public felhasznalo(string nev, int egyenleg)
        {
            this.nev = nev;
            this.egyenleg = egyenleg;
            this.konyvtar = new List<Jatek>();
        }

        public string Nev { get => nev; set => nev = value; }
        public int Egyenleg { get => egyenleg;}
        internal List<Jatek> Konyvtar { get => konyvtar; set => konyvtar = value; }
 
    
        public bool JatekVasarlas(Jatek jatek)
        {
            bool b = false;
            if (jatek.Ar < this.egyenleg && !this.konyvtar.Contains(jatek))
            {
                b = true;
                this.egyenleg -= jatek.Ar;
                this.konyvtar.Add(jatek);
                Console.WriteLine($"Sikeres vásárlás: {jatek.Cim}");
            }
            else
            {
                b = false;
                Console.WriteLine("Sikertelen vásárlás");
            }

            return b;
        }

        public void KonyvtarMegtekint()
        {
            foreach (var item in this.konyvtar)
            {
                Console.WriteLine(item);
            }
        }

        public void PenzFeltoltes(int amount)
        {
            if (amount > 0)
            {
                this.egyenleg += amount;
                Console.WriteLine($"Sikeres pénzfeltöltés + {amount}");
            }
            else
            {
                Console.WriteLine("Sikertelen pénzfeltöltés");
            }
        }

    
    
    }
}
