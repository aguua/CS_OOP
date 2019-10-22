using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory02Osoba
{
    class Program
    {
        static void Main(string[] args)
        {
            Adres adres1 = new Adres("Willeńska", "Wawka", 10, 12);
            Adres adres2 = new Adres("Akacjowa", "Poznań", 99, 13);

            Osoba s1 = new Osoba("Agnieszka", "Malinowska", 190612, adres1);
            Osoba s2 = new Osoba("Piort", "Mazur", 989898);
            Osoba s3 = new Osoba("Marek", 233232);
            Osoba s4 = new Osoba(s3);
            s4.adresZamieszkania = adres2;
            // ? Osoba s5 = s1.Clone();
            Osoba s6 = s1.Klonuj();


                Console.WriteLine(s1.PobierzInformacje());
                Console.WriteLine(s2.PobierzInformacje());
                Console.WriteLine(s3.PobierzInformacje());
                Console.WriteLine(s4.PobierzInformacje());
                Console.WriteLine(s6.PobierzInformacje());
            s6.adresZamieszkania = adres2;
                Console.WriteLine(s6.PobierzInformacje());

            Console.ReadKey();


            
        }
    }
}
