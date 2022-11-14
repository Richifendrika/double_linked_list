using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /*Node class represents the node of doubly linked list,
        * it consist of the information part and links to
        * its succeding and proceding
        * in tores of next and previous */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the proceeding node
        public Node prev;

    }

    class DoubleLinkedList
    {
        Node START;

        //constructor

        public DoubleLinkedList()
        {
            START = null;
        }

        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("\Enter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.name = nm;
            newNode.noMhs = nim;
        }

        class Program
        {

            static void Main(string[] args)
            {
            }
        }
    }
