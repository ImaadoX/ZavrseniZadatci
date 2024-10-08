using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisi ime: ");

            string userName = Console.ReadLine();

            Console.WriteLine("Zdravo! " + userName);
        }
    }
}