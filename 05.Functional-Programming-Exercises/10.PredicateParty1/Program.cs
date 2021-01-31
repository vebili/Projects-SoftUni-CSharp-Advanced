using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "Party!")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                string criteria = arguments[1];
                string parametar = arguments[2];
                command = Console.ReadLine();
                Func<string, int, bool> lengthFunc = (name, length) => name.Length == length;
                Func<string, string, bool> startsWithFunc = (name, param) => name.StartsWith(param);
                Func<string, string, bool> endsWithFunc = (name, param) => name.EndsWith(param);
                if (action == "Double")
                {
                    if (criteria == "Length")
                    {
                        int length = int.Parse(parametar);
                        var currentNames = names.Where(name => lengthFunc(name, length)).ToList();
                        AddMethod(names, currentNames);

                    }
                    else if (criteria == "StartsWith")
                    {
                        var currentNames = names.Where(name => startsWithFunc(name, parametar)).ToList();
                        AddMethod(names, currentNames);

                    }
                    else if (criteria == "EndsWith")
                    {
                        var currentNames = names.Where(name => endsWithFunc(name, parametar)).ToList();
                        AddMethod(names, currentNames);

                    }
                }
                else if (action == "Remove")
                {
                    if (criteria == "Length")
                    {
                        int length = int.Parse(parametar);
                        names = names.Where(name => !lengthFunc(name, length)).ToList();
                    }
                    else if (criteria == "StartsWith")
                    {
                        names = names.Where(name => !startsWithFunc(name, parametar)).ToList();
                    }
                    else if (criteria == "EndsWith")
                    {
                        names = names.Where(name => !endsWithFunc(name, parametar)).ToList();
                    }
                }
            }
            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
        }
        private static void AddMethod(List<string> names, List<string> currentNames)
        {
            foreach (var name in currentNames)
            {
                int index = names.IndexOf(name);
                names.Insert(index, name);
            }
        }
    }
}