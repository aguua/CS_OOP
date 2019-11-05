using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory02Osoba
{
    class Adres
    {
        public string nazwaUlicy
        { get; set; } // wlaswiwosci klasy

        public string miejscowosc
        { get; set; }
        public int numerDomu
        { get; set; }
        public int numerMieszkania
        { get; set; }

        public Adres(string nazwaUlicy, string miejscowosc, int nrDomu, int nrMieszkania)
        {
            this.nazwaUlicy = nazwaUlicy;
            this.miejscowosc = miejscowosc;
            this.numerDomu = nrDomu;
            this.numerMieszkania = nrMieszkania;
        }

    }
}
