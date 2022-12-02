using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue2022
{
    internal class LinkedListQueue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} inserted into Queue ", newNode.data);
        }
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Queue is empty");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
