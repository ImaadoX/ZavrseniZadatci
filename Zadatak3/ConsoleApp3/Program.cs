using System;

 namespace Zadatakbroj3
 {
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Napisi broj: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {

                Console.WriteLine("Broj je paran.");
            }

            else

            {
                Console.WriteLine("Broj nije paran.");
            }
        }
    }
 }