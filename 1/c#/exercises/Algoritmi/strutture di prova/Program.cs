using System;
using System.Collections;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        /* Stack
        Stack<string> numbers = new Stack<string>();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        // A stack can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("The number of elements in the stack=" + numbers.Count);
       // Console.WriteLine("Does the stack contain the element 3=" + numbers.Contains(3));
      */

        /* Queue
        Queue myQ = new Queue();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World");
        myQ.Enqueue("!");

        foreach (Object obj in myQ)
        { 
            Console.Write("    {0}", obj);
            Console.WriteLine();
        }

        Console.WriteLine("The number of elements in the queue: " + myQ.Count);
        Console.WriteLine("does the queue contain: " + myQ.Contains("!"));
        */

        /* LinkedList
        LinkedList<int> lk = new LinkedList<int>();
        lk.AddFirst(1);
        var node2 = new LinkedListNode<int>(2);
        lk.AddLast(node2);
        lk.AddLast(3);
        lk.AddAfter(node2, 5);

        foreach (int n in lk)
        {
            Console.WriteLine(n);
        }
        */

        Hashtable ht = new Hashtable();

        ht.Add("001", ".Net");
        ht.Add("002", "c#");
        ht.Add("003", "ASP.Net");

        ICollection keys = ht.Keys;

        foreach (String k in keys)
        {
            Console.WriteLine(ht[k]);
        }

        Console.ReadKey();
    }               
}

