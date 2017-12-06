using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node//a class to handle the node so that it can be used to make the linked list class
    {
        public int item;//item represents a number/data value in a node
        public Node next;
        public Node(int num)
        {
            item = num;
        }
        public void displayNode()
        {
            Console.WriteLine("[ {0} ]", item);//display items in the stack with brackets, I will call this in the linkedlist class
        }
    }
}
