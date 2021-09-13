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
            listSimple.Add("tom");
            listSimple.Add("vodidude");
            listSimple.Add("dudeldude");
            listSimple.Add("haramdude");

            Console.WriteLine(listSimple.ToString());
            listSimple.Remove("tom");
            Console.WriteLine(listSimple.ToString());

            Console.ReadLine();

        }
    }
}
