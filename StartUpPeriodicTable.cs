using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    /*You are given an n number of chemical compounds. You need to keep track of all chemical elements used in the compounds and at the end print all unique ones in ascending order: */
    class StartUpPeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sortSet = new SortedSet<string>();
            var strB = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                var chemicalEl = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (var el in chemicalEl)
                {
                    sortSet.Add(el+" ");

                }
            }

            foreach (var str in sortSet)
            {
                Console.Write(str);
            }
            Console.WriteLine();

        }
    }
}
