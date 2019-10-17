using System;
using System.Collections.Generic;
using System.Text;

namespace Konstruktory02Samochod
{
    struct Polozenie
    {
        private double dlugosc;
        private double szerokosc;

        public Polozenie(double dlugosc, double szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }
        public double GetDlugosc()
        {
            return dlugosc;
        }
        public double GetSzerokosc()
        {
            return szerokosc;
        }
    }
}
