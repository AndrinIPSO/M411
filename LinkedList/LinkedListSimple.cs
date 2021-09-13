using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListSimple
    {
        public int Count { get; set; }
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

        public override string ToString()
        {
            string s = "";
            Node node = first;

            while (node != null)
            {
                s += node.Item.ToString() + " -> ";
                node = node.Next;
            }
            s += "null, Count: " + Count.ToString();

            return s;
        }

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
            Count++;
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
                curr = curr.Next;
            }
            return null;
        }

        public bool Remove(object item)
        {
            Node node = find(item);

            if (node == null)
                return false;
            if (node == first)
            {
                first = first.Next;
                Count--;
                return true;
            }
            else
            {
                Node Previous = findPrevious(item);
                if (Previous != null)
                {
                    Previous.Next = node.Next;
                    if (node == last)
                    {
                        last = Previous;
                    }
                }
            }
            if (first == null)
            {
                last = null;
            }
                Count--;
                return true;
        }

        private Node findPrevious(object item)
        {
            Node curr = first;
            Node prev = null;
            while (curr != null)
            {
                if (curr.Item.Equals(item))
                {
                    return prev;
                }
                prev = curr;
                curr = curr.Next;
            }
            return null;
        }
        public Object FindByIndex(int index)
        {
            Node node = first;
            for (int i = 1; i < index; i++)
            {
                if (node.Next == null)
                {
                    break;
                }
                node = node.Next;
            }
            return node.Item;
        }
    }
}
