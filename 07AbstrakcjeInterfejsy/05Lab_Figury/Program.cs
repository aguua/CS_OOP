using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Każda z figur musi posiadać nazwę w celu jej identyfikacji oraz metodę zwracającą napis opisującą daną figurę.
W przypadku figur, dla których jest to możliwe, powinieneś również umożliwienie obliczenia długości obwodu oraz pola powierzchni. 
Utwórz również program testujący utworzone figury.
Każdy wielokąt (kwadrat, trojkat) posiada takie cechy jak:
	współrzędne wierzchołków wielokąta
	liczba boków
	długość każdego boku
	posiada obwód oraz pole
*/
namespace _05Lab_Figury
{
     abstract class Figura {
        public string nazwa;
        public override string ToString()
        {
            return nazwa;
        }

    }
    interface IPole
    {
        double poleFigury();
    }


    class Odcinek : Figura {

    }
    class Kolo : Figura {
        public double r;
        public Kolo(double r)
        {
            nazwa = "koło";
            this.r = r;
        }
        public override string ToString()
        {
            return $"{base.ToString()} o promieniu {r}";
        }
        public double poleFigury()
        {
            return Math.PI * r * r;
        }
    }

    class Kwadrat : Figura, IPole {
        public double a;
        public Kwadrat(double a)
        {
            this.nazwa = "kwadrat";
            this.a = a;
        }
        public override string ToString()
        {
            return $"{base.ToString()} o boku {a}";
        }

            public double poleFigury()
        {
            return a * a;
        }

    }

    class Trojkat : Figura { }


    class Program
    {
        static void Main(string[] args)
        {
            Kwadrat k = new Kwadrat(4);
            Kolo kolo = new Kolo(1);

            Console.WriteLine(k);
            Console.WriteLine(k.poleFigury());

            Console.WriteLine(kolo);
            Console.WriteLine(kolo.poleFigury());
            Console.Read();


        }
    }
}
