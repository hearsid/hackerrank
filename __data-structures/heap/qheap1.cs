using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


class Solution
{
    enum Operations {
        Add=1,
        Delete,
        Print
    }

    static void Main(String[] args)
    {
        int totalQueries = Convert.ToInt32(Console.ReadLine());
        PrioQueue<int> pq = new PrioQueue<int>();
        for(int i=0; i<totalQueries; i++)
        {
            string[] userInputs = Console.ReadLine().Split(' ');
            string oper = userInputs[0];
            int operIndex = Convert.ToInt32(oper);
            switch((Operations)operIndex)
            {
                case Operations.Add:
                    int val = Convert.ToInt32(userInputs[1]);
                    pq.Enqueue(val, val); //what priority? can be same since I need to return the min value
                    break;

                case Operations.Delete:
                    int val2 = Convert.ToInt32(userInputs[1]);
                    pq.Dequeue(val2); // all have the same priority
                    break;

                case Operations.Print:
                    if(pq.IsEmpty())
                    {
                        throw new Exception("Heap is empty");
                    }
                    int minNum = (int)pq.Peek();
                    Console.WriteLine(minNum);
                    break;

                default:
                    throw new Exception("Operation not in list");
            }
        }

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
