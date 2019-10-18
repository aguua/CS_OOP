using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autka
{
    /* Wzorując się na przykładzie 01Czolg stworzyć zestaw klas o podobnej funkcjonalności dotyczący samochodu.
Samochód posiada:
- położenie na mapie 
- markę i model
- silnik o zadanej pojemności
Podobnie jak w przypadku czołgu samochód powinien być wyposażony w odpowiednie konstuktory, w tym w realizację wzorca prototyp.
*/

    class Samochod
    {
        private int numerSamochodu;
        private string model;
        private string marka;
        private Polozenie polozenie;
        private Silnik silnik;

        public Samochod(int nrSamochodu, string model, string marka, double poj_silnika,
            double dlugosc, double szerokosc)
        {
            this.numerSamochodu = nrSamochodu;
            this.marka = marka;
            this.model = model;
            polozenie = new Polozenie(dlugosc, szerokosc);
            silnik = new Silnik(poj_silnika);
        }

        public Samochod(int nrSamochodu, string model, string marka, Silnik silnik, Polozenie pol)
            : this(nrSamochodu, model, marka, silnik.GetPojemnosc(), pol.GetDlugosc(), pol.GetSzerokosc())
        {
        }
        public Samochod(int nrSamochodu, string model, string marka, Silnik silnik, double dlug, double szer)
             : this(nrSamochodu, model, marka,silnik.GetPojemnosc(), dlug, szer)
        {
        }
        public Samochod(int nrSamochodu, string model, string marka, Silnik silnik)
            : this(nrSamochodu, model, marka, silnik.GetPojemnosc(), 5,5)
        {

        }

        public Samochod(int nrSamochodu, string model, string marka)
            : this(nrSamochodu, model, marka, new Silnik(1.9))
        {
        }
        public Samochod(int nrSamochodu)
             : this(nrSamochodu, "Focus", "Ford")
        {
        }

        public Samochod()
            : this(100)
        {
        }
        public string PobierzInformacje()
        {
            return $"Samochod\n nr:\t{numerSamochodu}\n model, marka {model}, {marka}\t hash: {this.GetHashCode()}" +
                $"\n ma silnik  : {silnik.GetPojemnosc()}" +
                $"\n znajduje się w punkcie: {polozenie.GetDlugosc()}, {polozenie.GetSzerokosc()}";

        }
    }
}
