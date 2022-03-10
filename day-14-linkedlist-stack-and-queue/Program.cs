using System;

namespace day_14_linkedlist_stack_and_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PushING values to Stack");          
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);
            linkedListStack.Display();
           
        }
    }
}
