using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8DictionariesandMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonebook();
        }

        private static void Phonebook()
        {
            int n = Convert.ToInt32(Console.In.ReadLine());

            Dictionary<string, int> phonebook = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] tmp = Array.ConvertAll(Console.In.ReadLine().Split(' '), x => x);
                phonebook.Add(tmp[0], Convert.ToInt32(tmp[1]));
            }

            string[] lookup = new String[n];

            for (int i = 0; i < n; i++)
            {
                lookup[i] = Console.In.ReadLine();
            }


            lookup.ToList().ForEach(contact =>
            {
                Console.WriteLine(FindContact(phonebook, contact));
            });

            Console.ReadLine();
        }

        private static string FindContact(Dictionary<string, int> phonebook, string _contact)
        {
            if (!phonebook.ContainsKey(_contact))
            {
                return "Not found";

            }
            else
            {
                var contactValue = phonebook[_contact];

                return $"{_contact}={contactValue}";
            }
        }
    }
}
