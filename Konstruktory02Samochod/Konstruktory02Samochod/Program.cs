using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autka
{
    class Program
    {
        static void Main(string[] args)
        {
            Polozenie pol1 = new Polozenie(3,4);
            Silnik s20 = new Silnik(2.0);
            Silnik s10 = new Silnik(1.0);

            Samochod s1 = new Samochod(1, "Focus", "Ford", 1.4, 10.0, 20.2);
            Samochod s2 = new Samochod(2, "Astra", "Opel", s20, pol1);
            Samochod s3 = new Samochod(3, "Punto", "Fiat", s10);
            Samochod s4 = new Samochod(4, "C4", "Citroen");
            Samochod s5 = new Samochod(12);
            Samochod s6 = new Samochod();



            Console.WriteLine(s1.PobierzInformacje());
            Console.WriteLine(s2.PobierzInformacje());
            Console.WriteLine(s3.PobierzInformacje());
            Console.WriteLine(s4.PobierzInformacje());
            Console.WriteLine(s5.PobierzInformacje());
            Console.WriteLine(s6.PobierzInformacje());
            Console.ReadKey();


        }
    }
}
