using System;
using System.Collections.Generic;
using System.Text;

namespace Konstruktory02Samochod
{
    class Silnik
    {
        private double pojemnosc;
        public Silnik(double pojemnosc)
        {
            this.pojemnosc = pojemnosc;
        }
        public double GetPojemnosc()
        {
            return pojemnosc;
        }
    }
}
