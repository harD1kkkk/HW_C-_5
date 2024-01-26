// See https://aka.ms/new-console-template for more information
namespace Myspace
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>(5);
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);
            Console.WriteLine("Peek: " + intStack.Peek());
            Console.WriteLine("Pop: " + intStack.Pop());
            Console.WriteLine("Peek: " + intStack.Peek());
            Console.WriteLine();

            Stack<string> stringStack = new Stack<string>(3);
            stringStack.Push("Hello");
            stringStack.Push("World");
            Console.WriteLine("Peek: " + stringStack.Peek());
            Console.WriteLine("Pop: " + stringStack.Pop());
            Console.WriteLine("Peek: " + stringStack.Peek());
        }
    }
}
