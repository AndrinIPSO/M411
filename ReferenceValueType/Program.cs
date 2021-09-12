using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceValueType
{
    class Program
    {
        //Git Test
        static void Main(string[] args)
        {
            int z1 = 0;
            int z2 = z1;

            // Call by Value
            z1 = 0;
            change(z1);
            Console.WriteLine($"Werttyp: z1= {z1}");

            //Call by Reference
            z1 = 0;
            change(ref z1);
            Console.WriteLine($"reftyp: z1= {z1}");

            //class als referenz typ
            var zClass = new ZahlClass();
            zClass.zahl1 = z1;
            change(zClass);
            Console.WriteLine($"reftyp klasse: z1= {zClass.zahl1}");

            //zuweisung mit referenztyp
            zClass.zahl1 = 100;
            ZahlClass zClass2 = zClass;
            zClass.zahl1 = 200;
            Console.WriteLine($"reftyp klasse von klasse: z1= {zClass.zahl1}");

            //Struct (werttyp)
            var zStruct = new ZahlStruct();
            zStruct.zahl1 = 0;
            Console.WriteLine($"werttyp struct {zStruct.zahl1}");

            //zuweisung werttyp
            zStruct.zahl1 = 100;
            ZahlStruct zStruct2 = zStruct;
            zStruct.zahl1 = 200;
            Console.WriteLine($"werttyp kopie{zClass.zahl1}");

            double[] zs = new double[111111111];
            double[] zss = zs;


            Console.Read();
        }

        public static void change(int zahl1)
        {
            zahl1 = 100;
        }

        public static void change(ref int zahl1)
        {
            zahl1 = 100;
        }

        public static void change(ZahlClass zahl)
        {
            zahl.zahl1 = 100;
        }

        public static void change(ZahlStruct zahl)
        {
            zahl.zahl1 = 100;
        }
    }
}
