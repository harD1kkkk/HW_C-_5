public class Stack<T>
{
    private T[] elements;
    private int top;

    public Stack(int size)
    {
        elements = new T[size];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == elements.Length - 1)
        {
            Console.WriteLine("Stack overflow!");
        }
        else
        {
            top++;
            elements[top] = item;
        }
    }

    public T Pop()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack is empty!");
        }

        T result = elements[top];
        top--;
        return result;

    }

    public T Peek()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack is empty!");
        }
        return elements[top];
    }
}