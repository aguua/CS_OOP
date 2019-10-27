using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Zadanie 2
-------------
Napisać klasę, przechowującą w tablicy liczby dni w poszczególnych miesiącach.
Klasę wyposażyć w indeksator umożliwiający odczyt i zmianę liczby dni w danym miesiącu odwołując się do niego po nazwie.
*/
namespace DniMiesiaca
{
    class MonthCollection
    {
        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private int GetNrMonth(string testMonth)
        {
            
                    for (int j = 0; j < months.Length; j++)
                {
                    if (months[j] == testMonth)
                    {
                        return j;
                    }
                }
            throw new IndexOutOfRangeException();
        }

        private int GetQuantDays(string testMonth)
        {
            /*dobre ale tylko do odczytywanie, nie do zmieniania
             * string[] list31 = { "Jan", "Mar", "May", "Jul", "Aug", "Oct", "Dec" };
            if (list31.Contains(testMonth))
            {
                return 31;
            }
            else if(testMonth == "Feb"){ return 28; }
            else { return 30; }*/
            return days[GetNrMonth(testMonth)];

        }
        public int this[string month]
        {
            get => GetQuantDays(month);
            set { days[GetNrMonth(month)]= value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MonthCollection month = new MonthCollection();
            try
            {
                System.Console.WriteLine(month["Jan"]);
                System.Console.WriteLine(month["Feb"]);
                System.Console.WriteLine(month["Jun"]);
                
                month["Feb"] = 29;
                System.Console.WriteLine(month["Feb"]);

                System.Console.WriteLine(month["Jddn"]);


            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Month not recognised");
            }
            System.Console.ReadLine();
        }
    }
}
