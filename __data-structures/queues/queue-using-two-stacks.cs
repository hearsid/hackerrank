using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    enum Operation
    {
        Enqueue,
        Dequeue,
        Print
    };


    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        /* how to do it?
         * two stacks on enqueue push in one stack 
         * one dequeue pop from the stack1 and start pushing in stack2 remove the last value of stack1 and push the rest of
         * the value back in stack1
         * keep enqueuing 
         */        
        int noOfInterations = Convert.ToInt32(Console.ReadLine());
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        for(int curEntry =0; curEntry< noOfInterations; curEntry++)
        {
            string[] opData = Console.ReadLine().Split(' ');
            int op = Convert.ToInt32(opData[0])-1;
            switch((Operation)op)
            {
                case Operation.Enqueue:
                    int data = Convert.ToInt32(opData[1]);
                    stack1.Push(data);
                    break;

                case Operation.Dequeue:
                    if(stack2.Count != 0)
                    {
                        stack2.Pop(); 
                    }
                    else
                    {
                        while (stack1.Count != 0)
                        {
                            int curVal = stack1.Pop();
                            stack2.Push(curVal);
                        }
                        stack2.Pop(); // remove the first queue element

                    }

                    // put the value back in stack one
                    break;

                case Operation.Print:
                    if (stack2.Count != 0)
                    {
                        Console.WriteLine(stack2.Peek());
                    }
                    else
                    {
                        while (stack1.Count != 0)
                        {
                            int curVal = stack1.Pop();
                            stack2.Push(curVal);
                        }
                        Console.WriteLine(stack2.Peek());
                    }
                    
                    break;

                default:
                    break;

            }

        }
    }
}


