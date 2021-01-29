using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var personArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var person = new Person
                {
                    Name = personArgs[0],
                    Age = int.Parse(personArgs[1])
                };
                people.Add(person);
            }
            var filter = Console.ReadLine();
            var ages = int.Parse(Console.ReadLine());
            Func<Person, bool> myFilter = filter switch
            {
                "older" => p => p.Age >= ages,
                "younger" => p => p.Age < ages,
                _ => p => true
            };
            var outputFormat = Console.ReadLine();
            Func<Person, string> outputFunc = outputFormat switch
            {
                "name age" => p => $"{p.Name} - {p.Age}",
                "name" => p => p.Name,
                "age" => p => p.Age.ToString(),
                _ => null
            };
            var sortingFormat = Console.ReadLine();
            var sortFunc = sortingFormat switch
            {
                "name" => people.OrderBy(p => p.Name),
                "age" => people.OrderBy(p => p.Age),
                _ => people.OrderBy(p => p)
            };


            people
                .Where(myFilter)
                .Select(outputFunc)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}