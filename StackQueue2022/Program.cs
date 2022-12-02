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
            Console.WriteLine("Enter the stack element");
            LinkedListStack StackOperation = new LinkedListStack();
            StackOperation.Push(70);
            StackOperation.Push(30);
            StackOperation.Push(56);
            StackOperation.Display();
            StackOperation.Peak();
            StackOperation.Pop();
            StackOperation.IsEmpty();
            StackOperation.Display();
            Console.ReadLine();
        }
    }
}
