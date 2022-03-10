using System;
using System.Collections;

namespace day_14_linkedlist_stack_and_queue
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Pushing values to Stack");
            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.push(70);
            //linkedListStack.push(30);
            //linkedListStack.push(56);
            //linkedListStack.Display();
           
            //Console.WriteLine("Using Peek and Pop Till Stack is Empty");
            //linkedListStack.Peek();
            //linkedListStack.Pop();
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();
            
            Console.WriteLine("Enqueue value in a Queue");
            LinkedListQueue listQueue = new LinkedListQueue();
            listQueue.Enqueue(56);
            listQueue.Enqueue(30);
            listQueue.Enqueue(70);
            listQueue.Display();

            Console.WriteLine("Dequeue Elements in Queue");
            listQueue.Dequeue(56);
            listQueue.Dequeue(36);
            listQueue.Dequeue(70);
            listQueue.Display();




        }
    }
}
