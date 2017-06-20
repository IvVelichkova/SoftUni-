using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUsernames
{
    class Program
    {
        /*On the first line you will be given an integer N. On the next N lines you will receive one username per line. Write a simple program that reads from the console a sequence of N usernames and keeps a collection only of the unique ones. Print the collection on the console in order of insertion: */

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sort = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                sort.Add(Console.ReadLine().ToString());
            }
            foreach (var s in sort)
            {
                Console.WriteLine(s);
            }
        }
    }
}
