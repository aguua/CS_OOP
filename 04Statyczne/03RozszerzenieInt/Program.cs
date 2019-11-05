using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ZADANIA //
namespace _03RozszerzenieInt
{

    static class RozszerzenieTypuInt
    {
        public static int Silnia(this int x)
        {
            int sil = 1;
            for (int i = 1; i <= x; i++)
            {
                sil *= i;
            }
            return sil;
        }
        // Dwumian Newtona - obliczna n nad k
        public static double Dwumian(this int n, int k)
        {
            double npok = n.Silnia() / (k.Silnia() * (n - k).Silnia());
            return npok;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"{x}! = {x.Silnia()}");

            int n = 10;
            int k = 5;
            Console.WriteLine($"Dwumian {n} nad {k} = {n.Dwumian(k)}");
            Console.ReadLine();
        }
    }
}
