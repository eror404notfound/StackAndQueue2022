using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue2022
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Queue Elements are:");
            LinkedListQueue QueueOperation = new LinkedListQueue();
            QueueOperation.Enqueue(56);
            QueueOperation.Enqueue(30);
            QueueOperation.Enqueue(70);
            QueueOperation.Display();
            Console.ReadLine();
        }
    }
}
