using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        private static void Dump(IEnumerable<int> enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        private static IEnumerable<int> QuickSort(IEnumerable<int> enumerable)
        {
            if(enumerable.Count() < 2)
                return enumerable;
 
            var pivot = enumerable.First();
            var less = enumerable.Where(i => i < pivot);
            var greater = enumerable.Where(i => i > pivot);
            return QuickSort(less).Concat(new []{pivot}).Concat(QuickSort(greater));
        }


        public static void Main(string[] args)
        {
            var unsorted = new List<int>(){5,7,82,3,54,67,32,45,11,-11};
            var sorted = QuickSort(unsorted); 
            Dump(unsorted);
            Dump(sorted);
        }
    }
}
