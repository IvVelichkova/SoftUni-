using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class StartUpPhonebook
    {
        /*Write a program that receives some info from the console about people and their phone numbers.
        You are free to choose the manner in which the data is stored. A valid entry should have just one name and one number (both of them strings). If you receive a name that already exists in the phonebook, simply update its number.
        After filling this simple phonebook, upon receiving the command "search", your program should be able to perform a search of a contact by name and print his details in the format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist."  Search for contacts until you receive the command "stop". */
        static void Main(string[] args)
        {
            var input = String.Empty;
            var phoneBook = new Dictionary<string, string>();
            var searchContackt = String.Empty;
            var searchList = new List<string>();

            while ((input = Console.ReadLine()) != "search")
            {
                var contacts = input.Trim().Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                var name = contacts[0];
                var phone = contacts[1];
                if (phoneBook.ContainsKey(name))
                {
                    phoneBook[name] = phone;
                }
                else
                {
                    phoneBook.Add(name, phone);
                }


            }
            while ((input = Console.ReadLine()) != "stop") 
            {



                if (phoneBook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phoneBook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }

            }
        }
    }
}

