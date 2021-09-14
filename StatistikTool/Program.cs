using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatistikTool
{
    class Program
    {
        int amount;
        static void Main(string[] args)
        {
            Console.WriteLine($"Dateiname: {args[0]}");
            int[] numbers = readfile(args[0]);
            Console.WriteLine($"Min:{numbers.Min()}");
            Console.WriteLine($"Max:{numbers.Max()}");
            Console.WriteLine($"AVG:{numbers.Average().ToString("0.00")}");
            Console.WriteLine($"Anz:{numbers.Length}");

            Console.ReadLine();
        }

        public static int[] readfile(string filename)
        {
            int[] numbers;
            string[] lines = File.ReadAllLines(filename);
            numbers = new int[lines.Length];
            int i = 0;
            foreach (string line in lines)
            {
                numbers[i] = Convert.ToInt32(line);
                i++;
            }
            return numbers;
        }


    }
}
