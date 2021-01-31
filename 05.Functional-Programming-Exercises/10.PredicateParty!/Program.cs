using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split()
                .ToList();
            Action<List<string>> Print = g => Console.WriteLine(string.Join(", ", g) + " are going to the party!");
            Predicate<string> predicate;
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "Party!")
                {
                    break;
                }
                string command = input[0];
                string predicateInput = input[1];
                string value = input[2];
                predicate = GetPredicate(predicateInput, value);
                if (command == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else
                {
                    List<string> filteredGuests = guests.FindAll(predicate);

                    foreach (var guest in filteredGuests)
                    {
                        int index = guests.IndexOf(guest);
                        guests.Insert(index + 1, guest);
                    }
                }
            }
            if (guests.Count > 0)
            {
                Print(guests);
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        private static Predicate<string> GetPredicate(string predicateInput, string value)
        {
            if (predicateInput == "StartsWith")
            {
                return p => p.StartsWith(value);
            }
            else if (predicateInput == "EndsWith")
            {
                return p => p.EndsWith(value);
            }
            else if (predicateInput == "Length")
            {
                return p => p.Length == int.Parse(value);
            }
            return null;
        }
    }
}