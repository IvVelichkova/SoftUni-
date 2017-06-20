using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class StartUpFixEmails
    {
        /*You are given a sequence of strings, each on a new line, unitll you receive the "stop" command. The first string is a name of a person. On the second line you will receive his email. Your task is to collect their names and emails, and remove the entries whose email’s domain ends with "us" or "uk" (case insensitive). 
            Print all the collected people and their emails in the following format: “{name} –> {email}” */
        static void Main(string[] args)
        {
            var input = String.Empty;
            var dictionary = new Dictionary<string, string>();


            while ((input=Console.ReadLine())!="stop")
            {
                var email = Console.ReadLine();
                if (dictionary.ContainsKey(input))
                {
                    dictionary[input] = email;
                }
                else
                {
                    dictionary.Add(input, email);
                }
            }
            
            foreach (var item in dictionary.Keys)
            {
                var email = dictionary[item];
                var domain = email.Substring(email.Length - 2);
                if (domain.ToLower()=="us"||domain.ToLower()=="uk")
                {
                    dictionary.Remove(dictionary[item]);
                    continue;
                }
                Console.WriteLine($"{item} -> {dictionary[item]}");
            }
        }
    }
}
