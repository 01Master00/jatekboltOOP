using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatekboltOOP
{
    internal class Bolt
    {
        private List<Jatek> jatekok;
        private List<felhasznalo> felhasznalok;

        public Bolt()
        {
            this.jatekok =new List<Jatek>();
            this.felhasznalok = new List<felhasznalo>();
        }

        internal List<Jatek> Jatekok { get => jatekok; }
        internal List<felhasznalo> Felhasznalok { get => felhasznalok;}
    
        public void JatekHozzaadas(Jatek jatek)
        {
            this.jatekok.Add(jatek);
            Console.WriteLine($"Sikeresen Hozzáadta a {jatek.Cim} játékot");
        }

        public void FelhHozzaadas(felhasznalo jatek)
        {
            this.felhasznalok.Add(jatek);
            Console.WriteLine($"Sikeresen Hozzáadta {jatek.Nev} felhasználót");
        }

        public Jatek JatekKeres(string cim)
        {
            Jatek r = null;
            foreach (var item in this.jatekok)
            {
                if (item.Cim == cim)
                {
                    r = item;
                }
            }
            return r;
        }

        public felhasznalo FelhKeres(string nev)
        {
            felhasznalo r = null;
            foreach (var item in this.felhasznalok)
            {
                if (item.Nev == nev)
                {
                    r = item;
                }
            }
            return r;
        }





    }
}
