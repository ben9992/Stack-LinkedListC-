using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinkedList//the linkedlist class will act as the main class to handle stack functions
    {
        public Node head;
        private int size;//this will be used to determine how big the list gets and will be used for popping items...
        public LinkedList(int size)
        {
            this.head = null; //null means that the link doesnt point to anything
            this.size = 0;
        }

        public LinkedList()
        {
            //empty constructor, so were are able to create an instance of linkedlist in the class
        }
        public void Insert(int num)
        {
            Node newNode = new Node(num);//passing in a number to the new node
            newNode.next = head;//inserts at the beginning of the linked list
            head = newNode;//head or the first index is equal to the newnode (or the value inserted)
            size++;//keep track of how big the stack is
        }
        public int takeOut()//this will represent the pop functionality
        {
            Node x = head;

            if (size > 0)
            {
                head = head.next;
                size--;
            }
            return x.item;//return a number when we are popping from the stack
        }
        public void Display()//this method will get called when we are displaying the entire stack
        {
            Node current = head;//current node (last one in) is the head, so it will display first
            while (head != null)
            {
                current.displayNode();
                current = current.next;//the get the next node and display those

                if (current == null)
                {
                    return; //so that we get no null reference exceptions, return nothing if that ever happens
                }
            }
        }
    }
}
