﻿using System.Transactions;

namespace ExercicioEcUri1036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta,r1, r2;

            String[] v = Console.ReadLine().Split(' ');
            a = double.Parse(v[0]);
            b = double.Parse(v[1]);
            c = double.Parse(v[2]);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("R1 = " + r1.ToString("F5"));
                Console.WriteLine("R2 = " + r2.ToString("F5"));
            }

        }
    }
}
