namespace StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Stack and Queue using Linked List");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
        }
    }
}