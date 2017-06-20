using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class StartUpSetsOfElements
    {
        /*On the first line you are given the length of two sets n and m. On the next n + m lines there are n numbers that are in the first set and m numbers that are in the second one. Find all non-repeating elements that appear in both of them, and print them at the console:
        Set with length n = 4: {1, 3, 5, 7}
        Set with length m = 3: {3, 4, 5}
        Set that contains all repeating elements -> {3, 5} */
        static void Main(string[] args)
        {
            var nm = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = nm[0];
            int m = nm[1];
            var nSet = new HashSet<int>();
            var mSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                
                nSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
               
                mSet.Add(int.Parse(Console.ReadLine()));

            }
            foreach (var num in nSet)
            {
                if (mSet.Contains(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
