using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue2022
{
    internal class LinkedListStack
    {
        private Node top;

        public LinkedListStack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed in the stack value", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + "\n");
                temp = temp.next;
            }
        }
        internal void Peak()
        {
            if (this.top == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Console.WriteLine("Top element is" +this.top.data);
            }
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty deletion is not possible");
                return;

            }

            Console.WriteLine("value is popped" + this.top.data);
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Pop();
            }
            Console.WriteLine(this.top + "No element to pop");
        }
    }
}
