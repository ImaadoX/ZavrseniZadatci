using System;

namespace Zadatakbroj5

{
    class Project
    {
        static void Main()
        {
            Console.WriteLine("Napisi string: ");

            string input = Console.ReadLine();

            int letterCount = 0;
            int numberCount = 0;
            int specialCharCount = 0;

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    letterCount++;
                }
                else if (char.IsDigit(ch))
                {
                    numberCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine($"Slova: {letterCount}");
            Console.WriteLine($"Brojevi: {numberCount}");
            Console.WriteLine($"Specijalni znakovi: {specialCharCount}");
                }

            }
}