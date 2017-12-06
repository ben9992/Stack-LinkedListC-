using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stack//the class that will handle the stack functions
    {

        private LinkedList list;

        public Stack()
        {
            list = new LinkedList(); //create a new instance of linkedlist to work with

        }
        public void push(int s)
        {
            list.Insert(s);
        }
        public int pop() //returning an int value when I pop from the stack
        {
            return list.takeOut();
        }
        public void DisplayStack()//this method displays the stack in its entirety
        {
            Console.WriteLine("Stack (from top to bottom): ");
            list.Display();
        }
        public int Peek()
        {
            return list.head.item;
        }
    }
}