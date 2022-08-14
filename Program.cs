namespace StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Stack and Queue using Linked List");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.enqueue(56);
            linkedListQueue.enqueue(30);
            linkedListQueue.enqueue(70);
            linkedListQueue.Display();

        }
    }
}