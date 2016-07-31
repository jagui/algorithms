using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        private static int FindBiggestIndex(List<int> list)
        {
            int max = list[0];
            int maxPos = 0;
            
            for(int i=1; i<list.Count;i++)
            {
                if(list[i]>max)
                {
                    maxPos = i;
                    max = list[i];
                }
            }
            return maxPos;
        }

        public static void Main(string[] args)
        {
            var unsorted = new List<int>{5,7,82,3,54,67,32,45,11,-11};
            var sorted = new List<int>();

            Console.Write ("Unsorted ");
            unsorted.ForEach(i=>Console.Write("{0} ",i));
            Console.WriteLine();

            int loops = unsorted.Count;

            for(var i = 0; i < loops; i++)
            {
                var maxPos = FindBiggestIndex(unsorted);
                sorted.Add(unsorted[maxPos]);
                unsorted.RemoveAt(maxPos);
            }

            Console.Write ("Sorted {0} elememts ", loops);
            sorted.ForEach(i=>Console.Write("{0} ",i));
            Console.WriteLine();
        }
    }
}