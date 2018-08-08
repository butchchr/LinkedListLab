using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //Non-Generic LinkedList
    class LinkedList
    {
        public LinkedList()
        {
            Head = new Node();
            Current = Head;
        }

        public Node Head;
        public Node Current;
        public int Count = 0;

        public void AddAtStart(object value)
        {
            var newNode = new Node()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value); //If using a reference type (any class/interface), you will need to override ToString for this to work.
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
    }

    //Linked List using Generics
    class LinkedList<T> where T : class
    {
        public LinkedList()
        {
            Head = new Node<T>();
            Current = Head;
        }
        public Node<T> Head;
        public Node<T> Current;
        public int Count = 0;

        public void AddAtStart(T value)
        {
            var newNode = new Node<T>()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node<T> curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }

        bool RemoveAt(int index)
        {
            Node<T> current = Head;
            Node<T> previous = null;

            for (int i = 0; i < index; i++)
            {
                if (current == null)
                {
                    return false;
                }
                previous = current;
                current = current.Next;
            }
            previous.Next = current.Next;
            if (current == Current)
            {
                Current = previous;
            }
            --Count;
            return true;
        }

        bool InsertAt(int index, T value)
        {
            var newNode = new Node<T>()
            {
                Value = value
            };

            for (int i = 0; i < index; i++)
            {
                
            }
            //Step 2: Change pointer from newNode-- (if there is one) to new node
            //Step 3: Assign pointer from newNode to the next node (if there is one)
        }
    }
}
