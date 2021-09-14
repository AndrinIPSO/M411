using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public class Figuren<T>
    {
        /// <summary>
        /// Element Klasse
        /// </summary>
        private sealed class Node
        {
            /// <summary>
            /// Item im Element
            /// </summary>
            public T Item { get; set; }
            /// <summary>
            /// Nächstes Element in Liste
            /// </summary>
            public Node Next { get; set; }
            /// <summary>
            /// Leeres Element erstellen
            /// </summary>
            public Node()
            {

            }
            /// <summary>
            /// Element mit Item erstellen
            /// </summary>
            /// <param name="it"></param>
            public Node(T it)
            {
                Item = it;
            }
        }
        /// <summary>
        /// Leztes Element
        /// </summary>
        private Node first = null;
        /// <summary>
        /// Erstes Element
        /// </summary>
        private Node last = null;
        /// <summary>
        /// Anzahl Elemente
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Element am ende Hinzufügen
        /// </summary>
        /// <param name="f"></param>
        public void Add(T f)
        {
            Node n = new Node() { Item = f, Next = null };
            if (first == null)
            {
                first = n;
                last = n;

            }
            else
            {
                last.Next = n;
                last = n;

            }
            Count++;
        }
        /// <summary>
        /// Index eines Elements fidnen
        /// </summary>
        /// <param name="f">Element</param>
        /// <returns></returns>
        private Node IndexOf(T f)
        {
            Node curr = first;
            while (curr.Next != null)
            {
                if (curr.Item.Equals(f))
                {
                    return curr;
                }
                curr = curr.Next;
            }
            return null;
        }
        /// <summary>
        /// Element löschen
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool Remove(T f)
        {
            Node node = IndexOf(f);

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
                Node Previous = findPrevious(f);
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
        /// <summary>
        /// Vorheriges Item finden
        /// </summary>
        /// <param name="f">Aktuelles item</param>
        /// <returns></returns>
        private Node findPrevious(T f)
        {
            Node curr = first;
            Node prev = null;
            while (curr != null)
            {
                if (curr.Item.Equals(f))
                {
                    return prev;
                }
                prev = curr;
                curr = curr.Next;
            }
            return null;
        }
        /// <summary>
        /// Item per Index finden
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns></returns>
        public T FindByIndex(int index)
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

        /// <summary>
        /// Löscht alle Elemente
        /// </summary>
        public void Clear()
        {
            first = null;
            Count = 0;
        }
        /// <summary>
        /// Aufruf per Index
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                    throw new IndexOutOfRangeException("Index out of range");

                return FindByIndex(index);
            }

            set
            {
                if (index < 0 || index >= this.Count)
                    throw new IndexOutOfRangeException("Index out of range");

                AddBetween(value, index);
            }
        }
        /// <summary>
        /// Item in der Mitte hinzufügen
        /// </summary>
        /// <param name="f">Item</param>
        /// <param name="index">Index</param>
        private void AddBetween(T f, int index)
        {
            if (index == Count)
            {
                Add(f);
            }
            else
            {
                Node n = new Node() { Item = f };
                n.Next = findPrevious(f).Next;
                findPrevious(f).Next = n;
                Count++;
            }
        }
    }
}
