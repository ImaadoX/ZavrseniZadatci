using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.JavaScript;

namespace ZadatakBroj4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite godinu: ");

            int godina = int.Parse(Console.ReadLine());

            if (PrestupnaGodina(godina))
            {
                Console.WriteLine($"{godina} je prestupna.");
            }
            else
            {
                Console.WriteLine($"{godina} nije prestupna.");
            }
        }

        static bool PrestupnaGodina(int godina)
        {
            if (godina % 400 == 0)
            {
                return true;
            }
            else if (godina % 100 == 0)
            {
                return false;
            }
            else if (godina % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



            