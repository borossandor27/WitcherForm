using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitcherForm
{

    class Karakter
    {
        int id;
        string nev;
        decimal ero;
        string nem;
        string gyengeseg;
        string kep;

        public Karakter(int id, string nev, decimal ero, string nem, string gyengeseg, string kep)
        {
            this.id = id;
            this.nev = nev;
            this.ero = ero;
            this.nem = nem;
            this.gyengeseg = gyengeseg;
            this.kep = kep;
        }

        public int Id { get => id; }
        public string Nev { get => nev; }
        public decimal Ero { get => ero; }
        public string Nem { get => nem; }
        public string Gyengeseg { get => gyengeseg;}
        public string Kep { get => kep; }

        public override string ToString()
        {
            return this.nev;
        }
    }
}
