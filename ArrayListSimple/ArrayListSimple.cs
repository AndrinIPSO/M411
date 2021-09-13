using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListSimple
{
    public class ArrayListSimple
    {
        public int Count { get; set; }

        protected int[] items;

        protected const int minl = 11;

        public ArrayListSimple()
        {

            items = new int[11];
        }

        public ArrayListSimple(int lenght)
        {
            items = new int[lenght];
        }
        public void Add(int item)
        {
            items[Count] = item;
            Count++;
        }

        public void Clear()
        {
            items = new int[11];
            Count = 0;
        }

        public int getAt(int index)
        {
            if (index < items.Length && index >= 0)
            {
            return items[index];
            }else
            {
                throw new Exception("Ungültiger Index");
            }
        }

    }
}
