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
            LinkedListStack stacklist = new LinkedListStack();
            stacklist.Push(70);
            stacklist.Push(30);
            stacklist.Push(56);
            stacklist.Display();
            Console.ReadLine();
        }
    }
}
