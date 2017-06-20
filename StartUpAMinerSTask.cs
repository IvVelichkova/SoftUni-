using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerSTask
{
    /*You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on) , and every even – quantity. Keep reading lines from the console until you receive the command "stop". Your task is to collect the resources and print them each on a new line. 
Print the resources and their quantities in format:   “{resource} –> {quantity}”
The quantities inputs will be in the range [1 … 2 000 000 000] */

    class StartUpAMinerSTask
    {
        static void Main(string[] args)
        {
            var input = String.Empty;
            var dictionary = new Dictionary<string, long>();
            while ((input=Console.ReadLine())!="stop")
            {
                var quantity = long.Parse(Console.ReadLine());
                if (dictionary.ContainsKey(input))
                {
                    dictionary[input] += quantity;
                }
                else
                {
                    dictionary.Add(input, quantity);
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
