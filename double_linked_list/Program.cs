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

   