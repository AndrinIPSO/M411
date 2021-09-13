using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingCalc calc = new TrainingCalc();
            for (int i = 0; i < 12; i++)
            {
                calc.add(i + (i + 01) * 12);
            }

            foreach (double zeit in calc.Zeiten)
            {
                Console.WriteLine(zeit);
            }
            Console.WriteLine("------");
            Console.WriteLine(calc.GetMin());
            Console.Read();
        }
    }
}
