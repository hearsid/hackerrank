using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;

class Solution {

        static int minSweetnessNotPossible = -1;
    static int getCookieSweetness(int cookieOne, int cookieTwo)
    {
        return 1 * cookieOne + 2 * cookieTwo;
    }

    static int cookies(int minSweetness, int[] A)
    {

        // problem is listed in heap
        // create a heap of the values of A
        // values are sorted in increasing order
        // start from the last element and keep applying
        // sweetness = 1* Least sweet cookie + 2*  2nd least sweet cookie
        // mixes only two cookies with the least sweetness
        int totalOperations = 0;
        PrioQueue<int> cookies = new PrioQueue<int>();
        for(int i=0; i<A.Length; i++)
        {
            int curEntry = A[i];
            cookies.Enqueue(curEntry, curEntry);
        }

        // now start to dequeue the list to get the last two elements
        // check if the sweetness of first queue element is greater than minSweetness then return -1
            
        if ((int)cookies.Peek() > minSweetness)
            return 0;

        bool minSweetnessSet = false;
        while(!cookies.IsEmpty())
        {

            int firstElement = (int)cookies.Peek();
            cookies.Dequeue(firstElement);
            if(cookies.IsEmpty())
                break;

            int secondElement = (int)cookies.Peek();
            cookies.Dequeue(secondElement);
            int newCookie = getCookieSweetness(firstElement, secondElement);
            totalOperations += 1;
            cookies.Enqueue(newCookie, newCookie);
            if (newCookie >= minSweetness) {
                minSweetnessSet = true;
                break;
            }
        }

        if(!minSweetnessSet)
            return -1;

        return totalOperations;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int k = Convert.ToInt32(nk[1]);

        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp))
        ;
        int result = cookies(k, A);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


public class PrioQueue<T>
{
    int total_size;
    SortedDictionary<int, Queue<T>> storage;

    public PrioQueue()
    {
        this.storage = new SortedDictionary<int, Queue<T>>();
        this.total_size = 0;
    }

    public bool IsEmpty()
    {
        return (total_size == 0);
    }

    public object Dequeue()
    {
        if (IsEmpty())
        {
            throw new Exception("Please check that priorityQueue is not empty before dequeing");
        }
        else
            foreach (Queue<T> q in storage.Values)
            {
                // we use a sorted dictionary
                if (q.Count > 0)
                {
                    total_size--;
                    return q.Dequeue();
                }
            }

        Debug.Assert(false, "not supposed to reach here. problem with changing total_size");

        return null; // not supposed to reach here.
    }

    // same as above, except for peek.

    public object Peek()
    {
        if (IsEmpty())
            throw new Exception("Please check that priorityQueue is not empty before peeking");
        else
            foreach (Queue<T> q in storage.Values)
            {
                if (q.Count > 0)
                    return q.Peek();
            }

        Debug.Assert(false, "not supposed to reach here. problem with changing total_size");

        return null; // not supposed to reach here.
    }

    public object Dequeue(int prio)
    {
        total_size--;
        return storage[prio].Dequeue();
    }

    public void Enqueue(T item, int prio)
    {
        if (!storage.ContainsKey(prio))
        {
            storage.Add(prio, new Queue<T>());
        }
        storage[prio].Enqueue(item);
        total_size++;
    }
}

