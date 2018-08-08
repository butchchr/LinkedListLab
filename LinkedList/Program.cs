using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        private static readonly List<string> Classmates = new List<string>()
        {
            "Rabin",
            "Aquoinette",
            "Chris",
            "Sean A",
            "Sean S",
            "Ross",
            "Dr. Clark",
            "Mike",
            "Catherine",
            "Bradley",
            "Jacob"
        };
        static void Main(string[] args)
        {
            RunLinkedListExample();
            Console.WriteLine("Press any key to continue to Generic Linked List example");
            Console.ReadKey();
            Console.Clear();
            RunGenericLinkedListExample();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void RunGenericLinkedListExample()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Generic Linked List Example");
            Console.WriteLine("=================================");
            var genericLinkedList = new LinkedList<string>();
            genericLinkedList.PrintAllNodes();
            foreach (var student in Classmates)
            {
                genericLinkedList.AddAtStart(student);
                Console.Write($"After adding {student}: ");
                genericLinkedList.PrintAllNodes();
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("******** Removing Classmates ***********");
            while (true)
            {
                try
                {
                    genericLinkedList.RemoveFromStart();
                    genericLinkedList.PrintAllNodes();
                }
                catch (Exception)
                {
                    genericLinkedList.PrintAllNodes();
                    break;
                }
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }


       
        private static void RunLinkedListExample()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Linked List Example");
            Console.WriteLine("=================================");
            var objectLinkedList = new LinkedList();
            objectLinkedList.PrintAllNodes();
            foreach (var student in Classmates)
            {
                objectLinkedList.AddAtStart(student);
                Console.Write($"After adding {student}: ");
                objectLinkedList.PrintAllNodes();
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("******** Removing Classmates ***********");
            while (true)
            {
                try
                {
                    objectLinkedList.RemoveFromStart();
                    objectLinkedList.PrintAllNodes();
                }
                catch (Exception)
                {
                    objectLinkedList.PrintAllNodes();
                    break;
                }
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
