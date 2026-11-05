using System;
using System.Collections.Generic;

class Task1
{
    static T Max<T>(T a, T b, T c) where T : IComparable
    {
        T max = a;
        if (b.CompareTo(max) > 0) max = b;
        if (c.CompareTo(max) > 0) max = c;
        return max;
    }

    static void Main()
    {
        Console.WriteLine(Max(5, 10, 3));
    }
}

class Task2
{
    static T Min<T>(T a, T b, T c) where T : IComparable
    {
        T min = a;
        if (b.CompareTo(min) < 0) min = b;
        if (c.CompareTo(min) < 0) min = c;
        return min;
    }

    static void Main()
    {
        Console.WriteLine(Min(5, 10, 3));
    }
}

class Task3
{
    static T Sum<T>(T[] array)
    {
        dynamic sum = 0;

        foreach (T x in array)
            sum += x;

        return sum;
    }

    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        Console.WriteLine(Sum(a));
    }
}

class MyStack<T>
{
    List<T> items = new List<T>();

    public void Push(T x)
    {
        items.Add(x);
    }

    public T Pop()
    {
        T x = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return x;
    }

    public T Peek()
    {
        return items[items.Count - 1];
    }

    public int Count
    {
        get { return items.Count; }
    }
}

class Task4
{
    static void Main()
    {
        MyStack<int> s = new MyStack<int>();

        s.Push(10);
        s.Push(20);

        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Peek());
        Console.WriteLine(s.Count);
    }
}
class Task6
{
    static List<T> FilterByTwoCriteria<T>(List<T> list, Predicate<T> a, Predicate<T> b)
    {
        List<T> result = new List<T>();

        foreach (T x in list)
            if (a(x) && b(x))
                result.Add(x);
        return result;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        List<int> result = FilterByTwoCriteria(numbers, x => x > 2, x => x % 2 == 0);

        foreach (int x in result)
            Console.WriteLine(x);
    }
}