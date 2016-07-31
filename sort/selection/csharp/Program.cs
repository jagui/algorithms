using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var unsorted = new List<int>{5,7,82,3,54,67,32,45,11,-11};
            var done = false;
            var sorted = new List<int>();
            var ops = 0;

            Console.Write ("Unsorted ");
            unsorted.ForEach(i=>Console.Write("{0} ",i));
            Console.WriteLine();

            while(!done)
            {
                int max = int.MinValue;
                int maxPos = -1;
                for(int i=0; i<unsorted.Count;i++)
                {
                    if(unsorted[i]>max)
                    {
                        maxPos = i;
                        max = unsorted[i];
                    }
                    ops++;
                }
                sorted.Add(max);
                unsorted.RemoveAt(maxPos);
                done = unsorted.Count == 0;
            }

            Console.Write ("Sorted {0} elememts in {1} ops ", sorted.Count,ops);
            sorted.ForEach(i=>Console.Write("{0} ",i));
            Console.WriteLine();
        }
    }
}
