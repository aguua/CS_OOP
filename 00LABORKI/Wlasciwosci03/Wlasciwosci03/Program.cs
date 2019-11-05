using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wlasciwosci03Jednostki
{
    public struct Ilosc
    {
        public Ilosc(int sztuki) : this()
        {
            Sztuki = sztuki;
        }

        public int Sztuki { get; set; }

        public int Kopa 
        { 
            set { Sztuki = 60 * value; }
            get { return Sztuki / 60; }
        }
        public int Tuzin
        {
            set { Sztuki = 12 * value; }
            get { return Sztuki / 12; }
        }
        public int Mendel
        {
            set { Sztuki = 15 * value; }
            get { return Sztuki / 15; }
        }


    }

    /*	metr
milimetr - 0,001 metra
cal - 25,4 milimetra
yard - 0,9144 metra
mila morska - 1 852 metrów
mila angielska - 1609,344 metra*/
    public struct Dlugosc {
        public Dlugosc(double metr) : this()
        {
            Metr = metr;
        }
        public double Metr { get; set; }
        public double Milimetr
        {
            set { Metr = 0.001 * value;}
            get { return Metr / 0.001; }
        }
        public double Cal
        {
            set { Milimetr = 25.4 * value; }
            get { return Milimetr /25.4; }
        }
        public double Yard
        {
            set { Metr = 0.9144 * value; }
            get { return Metr / 0.9144; }
        }
        public double MilaMorska
        {
            set { Metr = 1852 * value; }
            get { return Metr / 1852; }
        }
        public double MilaAng
        {
            set { Metr = 1609.344 * value; }
            get { return Metr / 1609.344; }
        }

    }

    public struct Masa
    {
        public Masa(double kg) : this()
        { 
            Kilogram = kg; 
        }
        public double Kilogram { get; set; }
        public double Gram
        {
            set { Kilogram = 0.001 * value; }
            get { return Kilogram / 0.001; }

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Ilosc il = new Ilosc(120);
            Console.WriteLine($"Sztuki = {il.Sztuki}, kopy= {il.Kopa}, tuziny = {il.Tuzin}, mendle = {il.Mendel}");
            il.Mendel = 5;
            Console.WriteLine($"Sztuki = {il.Sztuki}, kopy= {il.Kopa}, tuziny = {il.Tuzin}, mendle = {il.Mendel}");
            Console.ReadKey();

            Masa m = new Masa(10);
            Console.WriteLine($"Kg = {m.Kilogram}, gram = {m.Gram}");
            m.Gram = 1000;
            Console.WriteLine($"Kg = {m.Kilogram}, gram = {m.Gram}");
            Console.ReadKey();

            Dlugosc dl = new Dlugosc(1500);
            Console.WriteLine($"m = {dl.Metr}, mm = {dl.Milimetr}, cal = {dl.Cal}, mila m = {dl.MilaMorska}, yard = {dl.Yard}");
            dl.MilaAng = 1000;
            Console.WriteLine($"m = {dl.Metr}, mm = {dl.Milimetr}, cal = {dl.Cal}, mila m = {dl.MilaMorska}, yard = {dl.Yard}");
            Console.ReadKey();


        }
    }
}
