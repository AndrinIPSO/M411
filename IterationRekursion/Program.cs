using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationRekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl eingeben:");
            int zahl = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nZ = Factorial(zahl);
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine($"Zahl:\t\t{zahl}\nTicks:\t\t{stopwatch.ElapsedTicks}\nErgebnis:\t{nZ}");
            Console.ReadLine();
        }

        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }

        }
    }
}
