using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListSimple listSimple = new LinkedListSimple();
            listSimple.Add("tim");
            listSimple.Add("muchachodude");
            listSimple.Add("vodidude");
            listSimple.Add("dudeldude");
            listSimple.Add("haramdude");

            if (listSimple.contains("tim"))
            {
                Console.WriteLine("Yeehaw");
            }
            else
            {
                Console.WriteLine("waheey");
            }

            Console.ReadLine();

        }
    }
}
