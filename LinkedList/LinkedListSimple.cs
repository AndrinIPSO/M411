using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListSimple
    {
        private sealed class Node
        {
            public object Item { get; set; }
            public Node Next { get; set; }

            public Node()
            {

            }

            public Node(object it)
            {
                Item = it;
            }
        }

        private Node first = null;
        private Node last = null;

        public void Add(object item)
        {
            Node n = new Node() {Item = item, Next = null};
            if (first == null)
            {
                first = n;
                last = n;
            }
            else
            {
                last.Next = n;
                last = n;
                
                // oder ohne last
                //Node curr = first;
                //while (curr.Next != null)
                //{
                //    curr = curr.Next;
                //}
                //curr.Next = n;
            }
        }

        public bool contains(object item)
        {
            return find(item) != null;
            //if (find(item) != null)
            //    return true;
            //else
            //    return false;
        }



        private Node find(object item)
        {
            Node curr = first;
            while (curr.Next != null)
            {
                if (curr.Item.Equals(item))
                {
                    return curr;
                }

            }
            return null;

        }
    }
}
