using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory02Osoba
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private int numerEdiwencyjny;
        public Adres adresZamieszkania { get; set; }

        /*Zakładając, że najczęściej spotykanym nazwiskiem jest Kowalski, firma znajduje się w Warszawie 
        i ma mieszkania pracownicze przy ulicy Aleje Jerozolimskie, stwórz odpowiednie konstruktory. 
        Dodaj też możliwość kopiowania płytkiego i kopiowania głębokiego do klasy Osoba.*/

        public Osoba(string imie, string nazwisko, int numer, string ulica, string miejscowosc, int nrDomu,int nrMieszkania )
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            numerEdiwencyjny = numer;
            adresZamieszkania = new Adres(ulica, miejscowosc, nrDomu, nrMieszkania);
        }

        public Osoba(string imie, string nazwisko, int numer, Adres adres)
        : this(imie, nazwisko, numer, adres.nazwaUlicy, adres.miejscowosc,
              adres.numerDomu, adres.numerMieszkania)
        { }

        public Osoba(string imie, string nazwisko, int numer)
        : this(imie, nazwisko, numer, "Aleje Jerozolimskie", "Warszawa",
              132,10)
        { }

        public Osoba(string imie,  int numer)
        : this(imie, "Kowalski", numer)
        { }

        //kopia głeboka osoby
        public Osoba(Osoba klon)
            :this(klon.imie, klon.nazwisko, klon.numerEdiwencyjny, klon.adresZamieszkania)
        {
        }
        public Osoba Klonuj()
        {
            return (Osoba)this.MemberwiseClone();
        }

        public object Clone()
        {
            return new Osoba(this);
        }

        public string PobierzInformacje()
        {
            Adres a = adresZamieszkania;
            return $"osoba\n {imie} {nazwisko}\n numer: {numerEdiwencyjny}\n" +
                    $"zamieszkała: {a.nazwaUlicy} {a.numerDomu}/{a.numerDomu} " +
                    $"{a.miejscowosc}\n";

        }

    }
}
