using System;

class Program
{
    static int ComputeGCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static void Main()
            {
                Console.WriteLine("Napisi prvi broj: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Napisi drugi broj: ");
                int num2 = int.Parse(Console.ReadLine());

                int gcd = ComputeGCD(num1, num2);

                Console.WriteLine($"Najveci zajednicki djelilac od {num1} i {num2} je {gcd}.");
            }
        }
   