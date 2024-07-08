using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace CSharp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------1-------
            //int maxInt = MaxOfThree(3, 7, 5);
            //Console.WriteLine($"Max of ints: {maxInt}");

            //-------2-------
            //int minInt = MinOfThree(3, 7, 5);
            //Console.WriteLine($"Min of ints: {minInt}");

            //-------3-------
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //int sum = Sum(intArray);
            //Console.WriteLine($"Sum of int array: {sum}");

            //-------4-------
            //Stack<int> intStack = new Stack<int>();
            //intStack.Push(1);
            //intStack.Push(2);
            //intStack.Push(3);

            //Console.WriteLine($"Count: {intStack.Count}"); 

            //Console.WriteLine($"Peek: {intStack.Peek()}"); 

            //Console.WriteLine($"Pop: {intStack.Pop()}");   
            //Console.WriteLine($"Count: {intStack.Count}"); 

            //Console.WriteLine($"Pop: {intStack.Pop()}");   
            //Console.WriteLine($"Count: {intStack.Count}"); 

            //Console.WriteLine($"Pop: {intStack.Pop()}");   
            //Console.WriteLine($"Count: {intStack.Count}"); 

            //-------5-------
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);

            Console.WriteLine($"Count: {intQueue.Count}"); 

            Console.WriteLine($"Peek: {intQueue.Peek()}"); 

            Console.WriteLine($"Dequeue: {intQueue.Dequeue()}"); 
            Console.WriteLine($"Count: {intQueue.Count}");       

            Console.WriteLine($"Dequeue: {intQueue.Dequeue()}"); 
            Console.WriteLine($"Count: {intQueue.Count}");       

            Console.WriteLine($"Dequeue: {intQueue.Dequeue()}"); 
            Console.WriteLine($"Count: {intQueue.Count}");
        }
        //-------1------- 
        //static T MaxOfThree<T>(T a, T b, T c) where T : IComparable<T>
        //{
        //    T max = a;

        //    if (b.CompareTo(max) > 0)
        //    {
        //        max = b;
        //    }

        //    if (c.CompareTo(max) > 0)
        //    {
        //        max = c;
        //    }
        //    return max;
        //} 

        //-------2------- 
        //static T MinOfThree<T>(T a, T b, T c) where T : IComparable<T>
        //{
        //    T min = a;

        //    if (b.CompareTo(min) < 0)
        //    {
        //        min = b;
        //    }

        //    if (c.CompareTo(min) < 0)
        //    {
        //        min = c;
        //    }

        //    return min;
        //}

        //-------3------- 
        //static int Sum(int[] array)
        //{
        //    int sum = 0;

        //    foreach (int element in array)
        //    {
        //        sum += element;
        //    }

        //    return sum;
        //}
    }

    //-------4------- 
    //public class Stack<T>
    //{
    //    private List<T> _elements = new List<T>();

    //    public int Count
    //    {
    //        get { return _elements.Count; }
    //    }

    //    public void Push(T item)
    //    {
    //        _elements.Add(item);
    //    }

    //    public T Pop()
    //    {
    //        if (_elements.Count == 0)
    //        {
    //            throw new InvalidOperationException("The stack is empty.");
    //        }

    //        T item = _elements[_elements.Count - 1];
    //        _elements.RemoveAt(_elements.Count - 1);
    //        return item;
    //    }

    //    public T Peek()
    //    {
    //        if (_elements.Count == 0)
    //        {
    //            throw new InvalidOperationException("The stack is empty.");
    //        }

    //        return _elements[_elements.Count - 1];
    //    }
    //}

    //-------5------- 
    public class Queue<T>
    {
        private LinkedList<T> _elements = new LinkedList<T>();

        public int Count
        {
            get { return _elements.Count; }
        }

        public void Enqueue(T item)
        {
            _elements.AddLast(item);
        }

        public T Dequeue()
        {
            if (_elements.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            T value = _elements.First.Value;
            _elements.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (_elements.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return _elements.First.Value;
        }
    }
}
