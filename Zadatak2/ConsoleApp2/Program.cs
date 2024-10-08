using System;

 namespace ZadatakBroj2
 {
    class Program
    {
        static void Main()
        {
           Console.WriteLine("Napisite prvi broj: ");
           double number1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Napisite drugi broj: ");
           double number2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Napisite treci broj: ");
           double number3 = Convert.ToDouble(Console.ReadLine());

           double average = (number1 + number2 + number3) / 3;

           Console.WriteLine("Srednja vrijednost ovih brojeva je: " + average); 
        }
    }
 }