using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05labPunkt3D
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Punkt3D p = new Punkt3D(2, 3, 8);
            Punkt3D p3 = new Punkt3D();
            Console.WriteLine(p3);
            Console.WriteLine($"odleglosc od innego p {p3.dist(p)}");
            Console.ReadLine();
        }
    }
}
